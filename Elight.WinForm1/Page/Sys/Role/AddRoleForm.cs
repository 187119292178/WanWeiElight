using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.ResponseModels; 
using Elight.Utility.Other;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Elight.Utility.Network;
using Elight.WinForm.Common;

namespace Elight.WinForm.Page.Sys.Role
{
    public partial class AddRoleForm : UIForm
    {
        public AddRoleForm()
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

        public RolePage ParentPage { get; set; }
        public string Id { get; set; }

        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            comboType.Items.Add("系统角色");
            comboType.Items.Add("业务角色");
            comboType.Items.Add("其他角色");
            comboType.SelectedIndex = 2;

            if (StringHelper.IsNullOrEmpty(Id))
            {
                lblTitle.Text = "新增角色";
                txtEnCode.Enabled = true;
            }
            else
            {
                lblTitle.Text = "修改角色";
                txtEnCode.Enabled = false;
            }
            //获取部门下拉列表的值
            bool flag = GetDepartmentCombox();
            if (!flag)
            {
                btnClose_Click(null, null);
                return;
            }
            if (StringHelper.IsNullOrEmpty(Id))
            {
                return;
            }
            //获得用户信息

            RetMessage<SysRole> result =WebApiRequest.DoPostJson<SysRole>($"{GlobalConfig.Config.ServerUrl}app/system/role/getForm", new { primaryKey = Id });
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
            SysRole entity = result.data;
            if (entity == null)
            {
                this.ShowWarningDialog("角色信息不存在", UIStyle.White);
                btnClose_Click(null, null);
                return;
            }
            //给文本框赋值
            txtEnCode.Text = entity.EnCode;
            txtName.Text = entity.Name;
            comboType.SelectedIndex = entity.Type.Value;
            comboDept.SelectedValue = entity.OrganizeId;
            txtSortCode.Value = entity.SortCode.Value;
            txtRemark.Text = entity.Remark;
        }


        /// <summary>
        /// 获得组织机构下拉列表
        /// </summary>
        /// <returns></returns>
        private bool GetDepartmentCombox()
        {

            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/getListTreeSelect";
            RetMessage<List<TreeSelect>> result =WebApiRequest.DoGet<List<TreeSelect>>(url, null);
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
        /// 确定按钮点击事件
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
            bool flag = ChechEmpty();
            if (!flag)
            {
                return;
            }
            SysRole model = new SysRole();
            model.Id = Id;
            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.Type = comboType.SelectedIndex;
            model.OrganizeId = comboDept.SelectedValue.ToString();
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/role/form";
            RetMessage<string> result =WebApiRequest.DoPostJson<string>(url, model);
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

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty()
        {
            if (StringHelper.IsNullOrEmpty(txtEnCode.Text))
            {
                this.ShowWarningDialog("编码不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtName.Text))
            {
                this.ShowWarningDialog("名称不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(comboType.SelectedItem.ToString()))
            {
                this.ShowWarningDialog("类型不能为空", UIStyle.White);
                return false;
            }

            if (StringHelper.IsNullOrEmpty(comboDept.SelectedItem.ToString()))
            {
                this.ShowWarningDialog("所属部门不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtSortCode.Text))
            {
                this.ShowWarningDialog("排序号不能为空", UIStyle.White);
                return false;
            }
            return true;
        }


        /// <summary>
        /// 执行新增操作
        /// </summary>
        private void DoAdd()
        {
            bool flag = ChechEmpty();
            if (!flag)
                return;
            SysRole model = new SysRole();
            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.Type = comboType.SelectedIndex;
            model.OrganizeId = comboDept.SelectedValue.ToString();
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.CreateUserId = GlobalConfig.CurrentUser.Id;
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/role/form";
            RetMessage<string> result =WebApiRequest.DoPostJson<string>(url, model);
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
