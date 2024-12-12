using Elight.Entity.Sys;
using Elight.Logic.Sys;
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
        private SysUserLogic userlogic;
        private SysUserLogOnLogic userLogOnLogic;

        /// <summary>
        /// 构造方法
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            userlogic = new SysUserLogic();
            userLogOnLogic = new SysUserLogOnLogic();

            //txtPassword.Text = "123456";
            //txtUserName.Text = "Admin";
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
            password = password.MD5Encrypt();
            var userEntity = userlogic.GetByUserName(userName);
            if (userEntity == null)
            {
                this.ShowInfoDialog("该账户不存在，请重新输入。", UIStyle.White);
                return;
            }
            //if (!userEntity.IsEnabled)
            //{
            //    this.ShowInfoDialog("该账户已被禁用，请联系管理员。", UIStyle.White);
            //    return;
            //}
            var userLogOnEntity = userLogOnLogic.GetByAccount(userEntity.Id);
            string inputPassword = password.DESEncrypt(userLogOnEntity.SecretKey).MD5Encrypt();
            if (inputPassword != userLogOnEntity.Password)
            {
                this.ShowInfoDialog("密码错误，请重新输入。", UIStyle.White);
                return;
            }
            userLogOnLogic.UpdateLogin(userLogOnEntity);

            GlobalConfig.CurrentUser = userEntity;
            if (!StringHelper.IsNullOrEmpty(userEntity.AvatarBase64))
            {
                try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(userEntity.AvatarBase64));
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
