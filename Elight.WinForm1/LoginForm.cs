using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.Network;
using Elight.Utility.ResponseModels;
using Elight.Utility.Security;
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

namespace Elight.WinForm
{
    /// <summary>
    /// 用户登录界面
    /// </summary>
    public partial class LoginForm : UIForm
    {

        /// <summary>
        /// 构造方法
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (StringHelper.IsNullOrEmpty(userName))
            {
                this.ShowWarningDialog("请输入用户名", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(password))
            {
                this.ShowWarningDialog("请输入密码", UIStyle.White);
                return;
            }

            //执行登录操作
            RetMessage<SysUser> result = WebApiRequest.DoPostJson<SysUser>($"{GlobalConfig.Config.ServerUrl}app/account/login", new { userName = userName, password = password });
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
            SysUser user = result.data;
            GlobalConfig.CurrentUser = user;
            if (!StringHelper.IsNullOrEmpty(user.AvatarBase64))
            {
                try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(user.AvatarBase64));
                    GlobalConfig.Avatar = Image.FromStream(ms);
                }
                catch
                {

                }
            }
            DialogResult = DialogResult.OK;
        }


        /// <summary>
        ///  用户名输入框 Enter键处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }


        /// <summary>
        /// 密码框 Enter键处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }
    }
}
