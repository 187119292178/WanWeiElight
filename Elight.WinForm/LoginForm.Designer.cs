namespace Elight.WinForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUserName = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            btnLogin = new Sunny.UI.UIButton();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.ButtonFillColor = System.Drawing.Color.White;
            txtUserName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtUserName.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtUserName.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtUserName.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtUserName.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtUserName.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtUserName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtUserName.ButtonSymbol = 61761;
            txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUserName.FillColor2 = System.Drawing.Color.White;
            txtUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtUserName.Location = new System.Drawing.Point(417, 218);
            txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUserName.Maximum = 2147483647D;
            txtUserName.Minimum = -2147483648D;
            txtUserName.MinimumSize = new System.Drawing.Size(1, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtUserName.Size = new System.Drawing.Size(248, 42);
            txtUserName.Style = Sunny.UI.UIStyle.White;
            txtUserName.StyleCustomMode = true;
            txtUserName.Symbol = 61447;
            txtUserName.TabIndex = 0;
            txtUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtUserName.Watermark = "请输入用户名";
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.ButtonFillColor = System.Drawing.Color.White;
            txtPassword.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtPassword.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtPassword.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtPassword.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtPassword.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtPassword.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtPassword.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtPassword.ButtonSymbol = 61761;
            txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPassword.FillColor2 = System.Drawing.Color.White;
            txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtPassword.Location = new System.Drawing.Point(417, 272);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPassword.Maximum = 2147483647D;
            txtPassword.Minimum = -2147483648D;
            txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtPassword.Size = new System.Drawing.Size(248, 42);
            txtPassword.Style = Sunny.UI.UIStyle.White;
            txtPassword.StyleCustomMode = true;
            txtPassword.Symbol = 57452;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "请输入密码";
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Transparent;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnLogin.Location = new System.Drawing.Point(417, 325);
            btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 20;
            btnLogin.Size = new System.Drawing.Size(248, 44);
            btnLogin.StyleCustomMode = true;
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登  录";
            btnLogin.Click += btnLogin_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = System.Drawing.Color.Transparent;
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            uiLabel1.Location = new System.Drawing.Point(533, 421);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(212, 29);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 6;
            uiLabel1.Text = "万维电气(惠州)有限公司";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = System.Drawing.Color.Transparent;
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            uiLabel2.Location = new System.Drawing.Point(416, 73);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(212, 39);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.TabIndex = 7;
            uiLabel2.Text = "条码打印系统";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(750, 450);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RectColor = System.Drawing.SystemColors.HotTrack;
            ShowRadius = false;
            ShowShadow = true;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "系统登录";
            TitleColor = System.Drawing.SystemColors.HotTrack;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtUserName;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}