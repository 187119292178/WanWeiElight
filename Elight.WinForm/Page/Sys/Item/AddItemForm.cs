﻿using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Utility.Core;
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
    public partial class AddItemForm : UIForm
    {
        private SysItemLogic itemLogic;
        private SysItemsDetailLogic itemsDetailLogic;
        public AddItemForm()
        {
            InitializeComponent();
            itemLogic = new SysItemLogic();
            itemsDetailLogic = new SysItemsDetailLogic();
        }

        public string Id;

        #region  标题栏
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
            DialogResult = DialogResult.Cancel;
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

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Id))
            {
                Text = "新增字典";
                txtEnCode.Enabled = true;
                return;
            }
            Text = "修改字典";
            txtEnCode.Enabled = false;
            //获取当前ID对应的数据 
            try
            {
                SysItem item = itemLogic.Get(Id);
                //给文本框赋值
                txtEnCode.Text = item.EnCode;
                txtName.Text = item.Name;
                txtSortCode.Value = item.SortCode.Value;
                txtRemark.Text = item.Remark;
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                btnClose_Click(null, null);
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
                this.ShowWarningDialog("字典名称不能为空", UIStyle.White);
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
            SysItem model = new SysItem();

            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.CreateUserId = GlobalConfig.CurrentUser.Account;
            int row = itemLogic.AppInsert(model, model.CreateUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            DialogResult = DialogResult.OK;

        }

        /// <summary>
        /// 执行更新操作
        /// </summary>
        private void DoUpdate()
        {
            bool flag = ChechEmpty();
            if (!flag)
                return;
            SysItem model = new SysItem();
            model.Id = Id;
            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.SortCode = txtSortCode.Value;
            model.Remark = txtRemark.Text;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;
            int row = itemLogic.AppUpdate(model, model.ModifyUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}