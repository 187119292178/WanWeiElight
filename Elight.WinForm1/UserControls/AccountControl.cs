using Elight.WinForm.Common;
using Elight.WinForm.UserControls.Menus;
using PopupTool;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elight.WinForm.UserControls
{
    /// <summary>
    /// 用户自定义控件，弹出层显示
    /// </summary>
    public partial class AccountControl : UserControl
    {
        public AccountControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 界面加载时，显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountControl_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GlobalConfig.CurrentUser.NickName;
            if (GlobalConfig.Avatar != null)
            {
                userAvatar.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
                userAvatar.Image = GlobalConfig.Avatar;
            }
        }
        /// <summary>
        /// 鼠标放上去改变颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUserName_MouseEnter(object sender, EventArgs e)
        {
            userAvatar.BackColor = Color.FromArgb(176, 176, 176);
            lblUserName.BackColor = Color.FromArgb(176, 176, 176);
        }
        /// <summary>
        /// 鼠标离开时，颜色改回来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userAvatar_Leave(object sender, EventArgs e)
        {
            userAvatar.BackColor = Color.Gray;
            lblUserName.BackColor = Color.Gray;
        }

        /// <summary>
        /// 点下去后显示弹出层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userAvatar_Click(object sender, EventArgs e)
        {
            UserMenuPanel uc = new UserMenuPanel();
            Popup pop = new Popup(uc);
            pop.Show(this);
        }


    }
}
