using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.Utility.Security;
using Elight.WinForm.Common;
using Elight.WinForm.Properties;
using Elight.Logic.Sys;

namespace Elight.WinForm
{
    /// <summary>
    /// 用户账户界面
    /// </summary>
    public partial class AccountForm : UIForm
    {
        private SysUserLogic userlogic;
        private SysUserLogOnLogic userLogOnLogic;
        /// <summary>
        /// 构造方法
        /// </summary>
        public AccountForm()
        {
            InitializeComponent();
            userlogic = new SysUserLogic();
            userLogOnLogic = new SysUserLogOnLogic();
        }

        #region 标题栏 处理
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

        private string Avatar;
        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountForm_Load(object sender, EventArgs e)
        {
            SysUser user = userlogic.Get(GlobalConfig.CurrentUser.Id);
            if (user == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            Avatar = user.Avatar;
            txtAccount.Text = user.Account;
            txtNickName.Text = user.NickName;
            txtName.Text = user.RealName;
            if (user.Gender == "1")
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            txtBirthday.Value = user.Birthday.Value;
            txtEmail.Text = user.Email;
            txtTel.Text = user.MobilePhone;
            txtAddress.Text = user.Address;
            txtSignature.Text = user.Signature;

            //头像显示
            if (StringHelper.IsNullOrEmpty(user.AvatarBase64))
            {
                imageAvator.Image = Resources.avatar;
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(user.AvatarBase64));
                    imageAvator.Image = Image.FromStream(ms);
                }
                catch
                {
                    imageAvator.Image = Resources.avatar;
                }
            }

            lblCurrentUser.Text = $"{user.Account}@{user.NickName}";
        }

        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //非空检测
            if (StringHelper.IsNullOrEmpty(txtNickName.Text))
            {
                this.ShowWarningDialog("昵称不能为空", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtName.Text))
            {
                this.ShowWarningDialog("姓名不能为空", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtBirthday.Text))
            {
                this.ShowWarningDialog("请选择生日", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtEmail.Text))
            {
                this.ShowWarningDialog("邮箱不能为空", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtTel.Text))
            {
                this.ShowWarningDialog("手机不能为空", UIStyle.White);
                return;
            }

            //获得目前信息，提交给服务端处理，返回结果
            SysUser model = new SysUser();
            model.Id = GlobalConfig.CurrentUser.Id;
            model.Account = txtAccount.Text;
            model.NickName = txtNickName.Text;
            model.RealName = txtName.Text;
            model.Avatar = Avatar;
            model.Gender = rdMale.Checked ? "1" : "0";
            model.StrBirthday = txtBirthday.Text;
            model.Email = txtEmail.Text;
            model.MobilePhone = txtTel.Text;
            model.Address = txtAddress.Text;
            model.Signature = txtSignature.Text;

            DateTime defaultDt = DateTime.Today;
            DateTime.TryParse(model.StrBirthday, out defaultDt);
            model.Birthday = defaultDt;
            int row = userlogic.AppUpdateBasicInfo(model);

            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            this.ShowSuccessDialog("恭喜你，操作成功", UIStyle.White);
        }


        /// <summary>
        /// 选择图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAvator_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Image Files(*.BMP;*.JPG;*.png)|*.BMP;*.JPG;*.png";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    string fileName = dialog.FileName;
            //    Image image = Image.FromFile(fileName);
            //    //上传到服务器
            //    AjaxResult result = null;

            //    string url = GlobalConfig.Config.Url + "account/uploadImage";
            //    string str = HttpUtils.PostFile(url, fileName, 2000);
            //    try
            //    {
            //        result = str.ToObject<AjaxResult>();
            //    }
            //    catch
            //    {
            //        result = null;
            //    }


            //    if (result == null)
            //    {
            //        this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
            //        return;
            //    }
            //    if (result.state != ResultType.Success)
            //    {
            //        this.ShowWarningDialog(result.message, UIStyle.White);
            //        return;
            //    }
            //    //上传成功，修改界面头像，以及服务器头像地址
            //    Avatar = result.data.ToString();
            //    imageAvator.Image = image;
            //    this.ShowSuccessDialog("上传成功，点击保存后生效", UIStyle.White);
            //}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOldPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtComfirmPassword.Text = string.Empty;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //非空检测
            if (StringHelper.IsNullOrEmpty(txtOldPassword.Text))
            {
                this.ShowWarningDialog("旧密码不能为空", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtNewPassword.Text))
            {
                this.ShowWarningDialog("新密码不能为空", UIStyle.White);
                return;
            }
            if (StringHelper.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                this.ShowWarningDialog("确认密码不能为空", UIStyle.White);
                return;
            }
            if (txtNewPassword.Text != txtComfirmPassword.Text)
            {
                this.ShowWarningDialog("两次密码不一致", UIStyle.White);
                return;
            }

            Dictionary<string, string> parm = new Dictionary<string, string>();
            string userId = GlobalConfig.CurrentUser.Id;
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtComfirmPassword.Text;


            if (!newPassword.Equals(confirmPassword))
            {
                this.ShowWarningDialog("两次密码输入不一致，请重新确认。", UIStyle.White);
                return;
            }
            oldPassword = oldPassword.MD5Encrypt();
            newPassword = newPassword.MD5Encrypt();
            confirmPassword = confirmPassword.MD5Encrypt();

            var userLoginEntity = userLogOnLogic.GetByAccount(userId);
            if (oldPassword.DESEncrypt(userLoginEntity.SecretKey).MD5Encrypt() != userLoginEntity.Password)
            {
                this.ShowWarningDialog("旧密码验证失败。", UIStyle.White);
                return;
            }
            userLoginEntity.Password = newPassword.DESEncrypt(userLoginEntity.SecretKey).MD5Encrypt();
            int isSuccess = userLogOnLogic.ModifyPwd(userLoginEntity);
            if (isSuccess == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            this.ShowSuccessDialog("修改成功", UIStyle.White);
        }
    }
}
