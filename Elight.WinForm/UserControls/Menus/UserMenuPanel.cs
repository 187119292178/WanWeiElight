using Elight.Utility.Other;
using Elight.WinForm;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elight.WinForm.UserControls.Menus
{
    public class UserMenuPanel : UIPanel
    {
        public UserMenuPanel()
        {
            UISymbolLabel lblAccountManage = new UISymbolLabel();
            lblAccountManage.ForeColor = Color.FromArgb(153, 153, 153);
            lblAccountManage.IsScaled = false;
            lblAccountManage.Location = new Point(7, 7);
            lblAccountManage.MinimumSize = new Size(1, 1);
            lblAccountManage.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            lblAccountManage.Size = new Size(122, 44);
            lblAccountManage.Style = UIStyle.Custom;
            lblAccountManage.StyleCustomMode = true;
            lblAccountManage.Symbol = 61508;
            lblAccountManage.SymbolColor = Color.FromArgb(153, 153, 153);
            lblAccountManage.SymbolSize = 28;
            lblAccountManage.Text = "账户管理";
            lblAccountManage.Click += new EventHandler(this.lblAccountManage_Click);
            lblAccountManage.MouseEnter += new EventHandler(this.uiSymbolLabel1_MouseEnter);
            lblAccountManage.MouseLeave += new EventHandler(this.uiSymbolLabel1_MouseLeave);


            UISymbolLabel lblExit = new UISymbolLabel();
            lblExit.ForeColor = Color.FromArgb(153, 153, 153);
            lblExit.IsScaled = false;
            lblExit.Location = new Point(6, 62);
            lblExit.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            lblExit.Size = new Size(122, 44);
            lblExit.Style = UIStyle.Custom;
            lblExit.StyleCustomMode = true;
            lblExit.Symbol = 61584;
            lblExit.SymbolColor = Color.FromArgb(153, 153, 153);
            lblExit.SymbolSize = 28;
            lblExit.TabIndex = 15;
            lblExit.Text = "安全退出";
            lblExit.Click += new EventHandler(this.lblExit_Click);
            lblExit.MouseEnter += new EventHandler(this.uiSymbolLabel1_MouseEnter);
            lblExit.MouseLeave += new EventHandler(this.uiSymbolLabel1_MouseLeave);

            this.Style = UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Size = new Size(134, 114);
            this.BackColor = Color.White;
            this.FillColor = Color.White;
            this.RectColor = Color.Silver;
            this.Controls.Add(lblExit);
            this.Controls.Add(lblAccountManage);
        }

        /// <summary>
        /// 账户管理点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAccountManage_Click(object sender, EventArgs e)
        {
            FormHelper.ShowSubForm(new AccountForm());
        }


        /// <summary>
        /// 鼠标进入按钮后，改变颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolLabel1_MouseEnter(object sender, EventArgs e)
        {
            UISymbolLabel label = sender as UISymbolLabel;
            label.BackColor = Color.FromArgb(244, 244, 244);
            label.ForeColor = Color.FromArgb(181, 181, 181);
            label.SymbolColor = Color.FromArgb(181, 181, 181);
        }

        /// <summary>
        /// 鼠标离开按钮后，颜色改回来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolLabel1_MouseLeave(object sender, EventArgs e)
        {
            UISymbolLabel label = sender as UISymbolLabel;
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.FromArgb(153, 153, 153);
            label.SymbolColor = Color.FromArgb(153, 153, 153);
        }


        /// <summary>
        /// 安全退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            //自己关闭，重新打开自己
            new Thread(() =>
            {
                string fileName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
                new Process { StartInfo = processStartInfo }.Start();
            }).Start();
            Thread.Sleep(100);
            Environment.Exit(0);
        }
    }
}
