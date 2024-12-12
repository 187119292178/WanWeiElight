using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms; 
using Elight.Utility.Core;
using Elight.WinForm.Common;
using Elight.Utility.Network;
using Elight.Entity.Sys;
using Elight.Utility.Other;

namespace Elight.WinForm.Page.Sys.Item
{
    public partial class AddItemDetailForm : UIForm
    {
        public AddItemDetailForm()
        {
            InitializeComponent();
        }


        #region 标题栏
        /// <summary>
        ///  标题
        /// </summary>
        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

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
        public string Id { get; internal set; }
        public ItemPage ParentPage { get; internal set; }
        public string ItemId { get; internal set; }
        private void AddItemDetailForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Id))
            {
                Text = "新增选项";
                txtEnCode.Enabled = true;
                return;
            }
            Text = "修改选项";
            txtEnCode.Enabled = false;


            //根据选项Id,得到选项明细 
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/itemsDetail/getForm";
            RetMessage<SysItemDetail> result =WebApiRequest.DoPostJson<SysItemDetail>(url, new { primaryKey = Id });
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
                return;
            }
            //根据选项Id,得到选项明细
            SysItemDetail entity = result.data;
            txtEnCode.Text = entity.EnCode;
            txtName.Text = entity.Name;
            txtSortCode.Value = entity.SortCode.Value;
        }

        /// <summary>
        /// 确定按钮事件
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
                return;
            SysItemDetail model = new SysItemDetail();
            model.Id = Id;
            model.EnCode = txtEnCode.Text;
            model.ItemId = ItemId;
            model.Name = txtName.Text;
            model.SortCode = txtSortCode.Value;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;


            string url = $"{GlobalConfig.Config.ServerUrl}app/system/itemsDetail/form";
            RetMessage<string> result =WebApiRequest.DoPostJson<string>(url, model);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            ParentPage.ShowItemDetailData();
            btnClose_Click(null, null);

        }



        /// <summary>
        /// 执行新增操作
        /// </summary>
        private void DoAdd()
        {
            bool flag = ChechEmpty();
            if (!flag)
                return;
            SysItemDetail model = new SysItemDetail();
            model.EnCode = txtEnCode.Text;
            model.ItemId = ItemId;
            model.Name = txtName.Text;
            model.SortCode = txtSortCode.Value;
            model.CreateUserId = GlobalConfig.CurrentUser.Id;
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/itemsDetail/form";
            RetMessage<string> result =WebApiRequest.DoPostJson<string>(url, model);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            ParentPage.ShowItemDetailData();
            btnClose_Click(null, null);
        }


        /// <summary>
        /// 检验数据
        /// </summary>
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
                this.ShowWarningDialog("选项名称不能为空", UIStyle.White);
                return false;
            }
            return true;
        }
    }
}
