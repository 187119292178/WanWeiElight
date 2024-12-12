using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.Network;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
namespace Elight.WinForm.Page.Sys.Organize
{
    public partial class AddOrganizeForm : UIForm
    {
        public AddOrganizeForm()
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


        public OrganizePage ParentPage { get; set; }
        public string Id { get; set; }

        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrganizeForm_Load(object sender, EventArgs e)
        {
            comboType.Items.Add("公司");
            comboType.Items.Add("部门");
            comboType.Items.Add("小组");
            comboType.SelectedIndex = 1;

            if (StringHelper.IsNullOrEmpty(Id))
            {
                lblTitle.Text = "新增机构";
                txtEnCode.Enabled = true;
            }
            else
            {
                lblTitle.Text = "修改机构";
                txtEnCode.Enabled = false;
            }
            //获取部门下拉列表的值
            if (StringHelper.IsNullOrEmpty(Id))
            {
                return;
            }

            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/getForm";
            RetMessage<SysOrganize> result =WebApiRequest.DoPostJson<SysOrganize>(url, new { primaryKey = Id });
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
            SysOrganize entity = result.data;
            if (entity == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                btnClose_Click(null, null);
                return;
            }
            //给文本框赋值
            txtEnCode.Text = entity.EnCode;
            txtName.Text = entity.FullName;
            comboType.SelectedIndex = entity.Type.Value;
            txtManagerId.Text = entity.ManagerId;
            txtTelePhone.Text = entity.TelePhone;
            txtWeChat.Text = entity.WeChat;
            txtEmail.Text = entity.Email;
            txtFax.Text = entity.Fax;
            txtAddress.Text = entity.Address;
            txtSortCode.Value = entity.SortCode.Value;
            txtRemark.Text = entity.Remark;
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
            SysOrganize model = new SysOrganize();
            model.Id = Id;
            model.EnCode = txtEnCode.Text;
            model.FullName = txtName.Text;
            model.Type = comboType.SelectedIndex;
            model.ManagerId = txtManagerId.Text;
            model.TelePhone = txtTelePhone.Text;
            model.WeChat = txtWeChat.Text;
            model.Email = txtEmail.Text;
            model.Fax = txtFax.Text;
            model.Address = txtAddress.Text;
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;

            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/form";
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
            SysOrganize model = new SysOrganize();
            model.EnCode = txtEnCode.Text;
            model.FullName = txtName.Text;
            model.Type = comboType.SelectedIndex;
            model.ManagerId = txtManagerId.Text;
            model.TelePhone = txtTelePhone.Text;
            model.WeChat = txtWeChat.Text;
            model.Email = txtEmail.Text;
            model.Fax = txtFax.Text;
            model.Address = txtAddress.Text;
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.CreateUserId = GlobalConfig.CurrentUser.Id;

            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/form";
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
