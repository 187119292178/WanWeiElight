using Elight.Logic.Sys;
using Elight.Utility.Other;
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

namespace Elight.WinForm.Page.Logs
{
    public partial class DeleteLogsForm : UIForm
    {
        private SysLogLogic logic;
        public DeleteLogsForm()
        {
            InitializeComponent();
            logic = new SysLogLogic();
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


        public UIPage ParentPage { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //判断一下，哪个单选框被选了
            string index = "0";
            if (uiRadioButton1.Checked)
                index = "1";
            else if (uiRadioButton3.Checked)
                index = "2";
            else if (uiRadioButton2.Checked)
                index = "3";
            else if (uiRadioButton4.Checked)
                index = "4";
            if (index == "0")
            {
                this.ShowWarningDialog("请选择要删除的选项", UIStyle.White);
                return;
            }
            try
            {
                logic.Delete(Type, index);
                ParentPage.Init();
                btnClose_Click(null, null);
            }
            catch (Exception ex)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
        }
    }
}
