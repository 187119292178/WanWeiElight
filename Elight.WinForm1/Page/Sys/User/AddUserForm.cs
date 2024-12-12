using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.Network;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;
using Elight.Utility.Security;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys.User
{
    public partial class AddUserForm : UIForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        #region 标题栏
        private void btnClose_Click(object sender, EventArgs e)
        {
            FormHelper.subForm = null;
            this.Close();
        }
        private Point mPoint;
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 231, 231);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;

        }
        #endregion


        public UserPage ParentPage { get; set; }
        public string Id { get; set; }

        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Id))
            {
                lblTitle.Text = "新增用户";
                txtAccount.Enabled = true;
            }
            else
            {
                lblTitle.Text = "修改用户";
                txtAccount.Enabled = false;
                txtPassword.Enabled = false;
            }
            //获取部门下拉列表的值
            bool flag = GetDepartmentCombox();
            if (!flag)
            {
                btnClose_Click(null, null);
                return;
            }
            flag = GetRoleTrans();
            if (!flag)
            {
                btnClose_Click(null, null);
                return;
            }
            if (StringHelper.IsNullOrEmpty(Id))
            {
                return;
            }

            RetMessage<SysUser> result = WebApiRequest.DoPostJson<SysUser>($"{GlobalConfig.Config.ServerUrl}app/system/user/getForm", new { primaryKey = Id });
            if (result == null)
            {
                this.ShowInfoDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowInfoDialog(result.message, UIStyle.White);
                return;
            }
            SysUser entity = result.data;
            if (entity == null)
            {
                this.ShowWarningDialog("用户信息不存在", UIStyle.White);
                btnClose_Click(null, null);
                return;
            }
            //给文本框赋值
            txtAccount.Text = entity.Account;
            txtNickName.Text = entity.NickName;
            txtName.Text = entity.RealName;
            txtBirthday.Text = entity.StrBirthday;
            if (entity.Gender == "1")
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            txtEmail.Text = entity.Email;
            comboDept.SelectedValue = entity.DepartmentId;
            txtTel.Text = entity.MobilePhone;
            txtAddress.Text = entity.Address;
            uiIntegerUpDown1.Value = entity.SortCode.Value;
            //左边删除已存在的，右边新增这些
            foreach (string id in entity.RoleId)
            {
                string name = roleIdDict[id];
                if (uiTransfer1.ItemsLeft.Contains(name))
                {
                    uiTransfer1.ItemsLeft.Remove(name);
                }
                uiTransfer1.ItemsRight.Add(name);
            }
        }

        Dictionary<string, string> roleNameDict = new Dictionary<string, string>();
        Dictionary<string, string> roleIdDict = new Dictionary<string, string>();


        /// <summary>
        /// 获得角色
        /// </summary>
        /// <returns></returns>
        private bool GetRoleTrans()
        {
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/role/getListTreeSelect";
            RetMessage<List<TreeSelect>> result = WebApiRequest.DoGet<List<TreeSelect>>(url, null);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return false;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return false;
            }

            List<TreeSelect> list = result.data;
            foreach (TreeSelect select in list)
            {
                uiTransfer1.ItemsLeft.Add(select.text);
                roleIdDict.Add(select.id, select.text);
                roleNameDict.Add(select.text, select.id);
            }
            return true;
        }

        /// <summary>
        /// 获得部门下拉列表数据
        /// </summary>
        /// <returns></returns>
        private bool GetDepartmentCombox()
        {
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/getListTreeSelect";
            RetMessage<List<TreeSelect>> result = WebApiRequest.DoGet<List<TreeSelect>>(url, null);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return false;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return false;
            }
            List<TreeSelect> list = result.data;
            List<TreeSelect> list2 = list.Where(it => it.parentId != "0").ToList();
            comboDept.ValueMember = "id";
            comboDept.DisplayMember = "text";
            comboDept.DataSource = list2;
            return true;
        }

        /// <summary>
        /// 确认按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Id))
            {
                DoAdd();
            }
            else
            {
                DoUpdate();
            }
        }

        /// <summary>
        /// 执行更新操作
        /// </summary>
        private void DoUpdate()
        {
            bool flag = ChechEmpty(false);
            if (!flag)
            {
                return;
            }
            SysUser model = new SysUser();
            model.Id = Id;
            model.Account = txtAccount.Text;
            model.NickName = txtNickName.Text;
            model.RealName = txtName.Text;
            model.StrBirthday = txtBirthday.Text;
            model.Gender = rdMale.Checked ? "1" : "0";
            model.Email = txtEmail.Text;
            model.DepartmentId = comboDept.SelectedValue.ToString();
            model.MobilePhone = txtTel.Text;
            model.Address = txtAddress.Text;
            model.SortCode = uiIntegerUpDown1.Value;

            List<string> ids = new List<string>();
            foreach (string item in uiTransfer1.ItemsRight)
            {
                ids.Add(roleNameDict[item]);
            }
            string roleIds = StringHelper.GetStrArray(ids);
            model.roleIds = roleIds;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;

            DateTime defaultDt = DateTime.Today;
            DateTime.TryParse(model.StrBirthday + " 00:00:00", out defaultDt);
            model.Birthday = defaultDt;

            if (model.roleIds == "")
            {
                this.ShowWarningDialog("请选择角色", UIStyle.White);
                return;
            }
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/user/form";
            RetMessage<string> result = WebApiRequest.DoPostJson<string>(url, model);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            ////更新用户基本信息。
            //int row = userLogic.AppUpdateAndSetRole(model, model.roleIds.SplitToList().ToArray(), model.ModifyUser);
            ////更新用户角色信息。
            //if (row == 0)
            //{
            //    this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
            //    return;
            //}

            ParentPage.Init();
            btnClose_Click(null, null);

        }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty(bool checkPassword)
        {
            if (StringHelper.IsNullOrEmpty(txtAccount.Text))
            {
                this.ShowWarningDialog("账号不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtNickName.Text))
            {
                this.ShowWarningDialog("昵称不能为空", UIStyle.White);
                return false;
            }
            if (checkPassword)
            {
                if (StringHelper.IsNullOrEmpty(txtPassword.Text))
                {
                    this.ShowWarningDialog("初始密码不能为空", UIStyle.White);
                    return false;
                }
            }
            if (StringHelper.IsNullOrEmpty(txtName.Text))
            {
                this.ShowWarningDialog("姓名不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtBirthday.Text))
            {
                this.ShowWarningDialog("出生日期不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtEmail.Text))
            {
                this.ShowWarningDialog("邮箱不能为空", UIStyle.White);
                return false;
            }
            if (!txtEmail.Text.IsEmail())
            {
                this.ShowWarningDialog("邮箱格式不正确", UIStyle.White);
                return false;
            }

            if (comboDept.SelectedItem == null)
            {
                this.ShowWarningDialog("所属部门不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(comboDept.SelectedItem.ToString()))
            {
                this.ShowWarningDialog("所属部门不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtTel.Text))
            {
                this.ShowWarningDialog("移动电话不能为空", UIStyle.White);
                return false;
            }
            if (!txtTel.Text.IsMobile())
            {
                this.ShowWarningDialog("移动电话格式不正确", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtAddress.Text))
            {
                this.ShowWarningDialog("联系地址不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(uiIntegerUpDown1.Text))
            {
                this.ShowWarningDialog("排序号不能为空", UIStyle.White);
                return false;
            }

            if (comboDept.SelectedItem == null)
            {
                this.ShowWarningDialog("所属部门不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(comboDept.SelectedItem.ToString()))
            {
                this.ShowWarningDialog("所属部门不能为空", UIStyle.White);
                return false;
            }


            if (uiTransfer1.ItemsRight == null)
            {
                this.ShowWarningDialog("角色不能为空", UIStyle.White);
                return false;
            }
            if (uiTransfer1.ItemsRight.Count == 0)
            {
                this.ShowWarningDialog("角色不能为空", UIStyle.White);
                return false;
            }
            return true;
        }


        /// <summary>
        /// 执行新增操作
        /// </summary>
        private void DoAdd()
        {
            bool flag = ChechEmpty(true);
            if (!flag)
                return;
            SysUser model = new SysUser();
            model.Account = txtAccount.Text;
            model.NickName = txtNickName.Text;
            model.password = txtPassword.Text.MD5Encrypt();
            model.RealName = txtName.Text;
            model.StrBirthday = txtBirthday.Text;

            model.Gender = rdMale.Checked ? "1" : "0";

            model.Email = txtEmail.Text;
            model.DepartmentId = comboDept.SelectedValue.ToString();
            model.MobilePhone = txtTel.Text;
            model.Address = txtAddress.Text;
            model.SortCode = uiIntegerUpDown1.Value;
            model.CreateUserId = GlobalConfig.CurrentUser.Id;
            List<string> ids = new List<string>();
            foreach (string item in uiTransfer1.ItemsRight)
            {
                ids.Add(roleNameDict[item]);
            }
            string roleIds = StringHelper.GetStrArray(ids);
            model.roleIds = roleIds;
            DateTime defaultDt = DateTime.Today;
            DateTime.TryParse(model.StrBirthday + " 00:00:00", out defaultDt);
            model.Birthday = defaultDt;

            if (model.roleIds == "")
            {
                this.ShowWarningDialog("请选择角色", UIStyle.White);
                return;
            }
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/user/form";
            RetMessage<string> result = WebApiRequest.DoPostJson<string>(url, model);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            ParentPage.Init();
            btnClose_Click(null, null);

        }
    }
}
