using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys.Item
{
    public partial class AddItemDetailForm : UIForm
    {
        private SysItemsDetailLogic itemDetaillogic;
        public AddItemDetailForm()
        {
            InitializeComponent();
            itemDetaillogic = new SysItemsDetailLogic();
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
            try
            {
                //根据选项Id,得到选项明细
                SysItemDetail entity = itemDetaillogic.Get(Id);
                entity.IsDefault = entity.IsDefault == "1" ? "true" : "false";
                txtEnCode.Text = entity.EnCode;
                txtName.Text = entity.Name;
                txtSortCode.Value = entity.SortCode.Value;
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
            }

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
            int row = itemDetaillogic.AppUpdate(model, model.ModifyUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
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
            int row = itemDetaillogic.AppInsert(model, model.CreateUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
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
