namespace Elight.WinForm
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.imageAvator = new System.Windows.Forms.PictureBox();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBirthday = new Sunny.UI.UIDatePicker();
            this.btnSave = new Sunny.UI.UIButton();
            this.txtSignature = new Sunny.UI.UITextBox();
            this.lblSignature = new Sunny.UI.UILabel();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.lblAddress = new Sunny.UI.UILabel();
            this.txtTel = new Sunny.UI.UITextBox();
            this.lblTel = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.lblEmail = new Sunny.UI.UILabel();
            this.lblBirthday = new Sunny.UI.UILabel();
            this.rdFemale = new Sunny.UI.UIRadioButton();
            this.rdMale = new Sunny.UI.UIRadioButton();
            this.txtNickName = new Sunny.UI.UITextBox();
            this.lblGender = new Sunny.UI.UILabel();
            this.lblNickName = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblName = new Sunny.UI.UILabel();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.lblAccount = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelectAvator = new Sunny.UI.UIButton();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReset = new Sunny.UI.UIButton();
            this.btnChangePassword = new Sunny.UI.UIButton();
            this.txtComfirmPassword = new Sunny.UI.UITextBox();
            this.txtNewPassword = new Sunny.UI.UITextBox();
            this.lblComfirmPassword = new Sunny.UI.UILabel();
            this.lblNewPassword = new Sunny.UI.UILabel();
            this.txtOldPassword = new Sunny.UI.UITextBox();
            this.lblOldPassword = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAvator)).BeginInit();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.titlePanel);
            this.uiPanel1.Controls.Add(this.panel1);
            this.uiPanel1.Controls.Add(this.uiTabControl1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Silver;
            this.uiPanel1.Size = new System.Drawing.Size(1031, 558);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 6;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.titlePanel.Controls.Add(this.uiLabel15);
            this.titlePanel.Controls.Add(this.btnClose);
            this.titlePanel.Location = new System.Drawing.Point(0, -1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1031, 43);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // uiLabel15
            // 
            this.uiLabel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel15.Location = new System.Drawing.Point(0, 0);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(986, 43);
            this.uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel15.TabIndex = 1;
            this.uiLabel15.Text = "用户账号管理";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.uiLabel15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(986, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 43);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.Symbol = 77;
            this.btnClose.SymbolSize = 60;
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.imageAvator);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 218);
            this.panel1.TabIndex = 6;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Location = new System.Drawing.Point(3, 176);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(235, 27);
            this.lblCurrentUser.TabIndex = 4;
            this.lblCurrentUser.Text = "admin@管理员";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageAvator
            // 
            this.imageAvator.Image = global::Elight.WinForm.Properties.Resources.avatar;
            this.imageAvator.Location = new System.Drawing.Point(49, 27);
            this.imageAvator.Name = "imageAvator";
            this.imageAvator.Size = new System.Drawing.Size(139, 136);
            this.imageAvator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAvator.TabIndex = 3;
            this.imageAvator.TabStop = false;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(275, 56);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(734, 490);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 5;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtBirthday);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtSignature);
            this.tabPage1.Controls.Add(this.lblSignature);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.lblTel);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblBirthday);
            this.tabPage1.Controls.Add(this.rdFemale);
            this.tabPage1.Controls.Add(this.rdMale);
            this.tabPage1.Controls.Add(this.txtNickName);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblNickName);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtAccount);
            this.tabPage1.Controls.Add(this.lblAccount);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(734, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "资料";
            // 
            // txtBirthday
            // 
            this.txtBirthday.FillColor = System.Drawing.Color.White;
            this.txtBirthday.FillColor2 = System.Drawing.Color.White;
            this.txtBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthday.Location = new System.Drawing.Point(117, 139);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirthday.MaxLength = 10;
            this.txtBirthday.MinimumSize = new System.Drawing.Size(63, 0);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txtBirthday.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtBirthday.Size = new System.Drawing.Size(188, 36);
            this.txtBirthday.Style = Sunny.UI.UIStyle.White;
            this.txtBirthday.StyleCustomMode = true;
            this.txtBirthday.SymbolDropDown = 61555;
            this.txtBirthday.SymbolNormal = 61555;
            this.txtBirthday.TabIndex = 20;
            this.txtBirthday.Text = "2021-12-29";
            this.txtBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBirthday.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(117, 379);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 44);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSignature
            // 
            this.txtSignature.ButtonFillColor = System.Drawing.Color.White;
            this.txtSignature.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtSignature.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtSignature.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtSignature.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtSignature.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtSignature.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtSignature.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtSignature.ButtonSymbol = 61761;
            this.txtSignature.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignature.FillColor2 = System.Drawing.Color.White;
            this.txtSignature.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignature.Location = new System.Drawing.Point(117, 252);
            this.txtSignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSignature.Maximum = 2147483647D;
            this.txtSignature.MaxLength = 128;
            this.txtSignature.Minimum = -2147483648D;
            this.txtSignature.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtSignature.Size = new System.Drawing.Size(581, 103);
            this.txtSignature.Style = Sunny.UI.UIStyle.White;
            this.txtSignature.StyleCustomMode = true;
            this.txtSignature.TabIndex = 18;
            this.txtSignature.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignature
            // 
            this.lblSignature.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignature.Location = new System.Drawing.Point(3, 252);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(107, 29);
            this.lblSignature.Style = Sunny.UI.UIStyle.Custom;
            this.lblSignature.TabIndex = 17;
            this.lblSignature.Text = "个性签名";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.ButtonFillColor = System.Drawing.Color.White;
            this.txtAddress.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtAddress.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtAddress.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtAddress.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtAddress.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtAddress.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAddress.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtAddress.ButtonSymbol = 61761;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FillColor2 = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(429, 191);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Maximum = 2147483647D;
            this.txtAddress.MaxLength = 128;
            this.txtAddress.Minimum = -2147483648D;
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAddress.Size = new System.Drawing.Size(269, 42);
            this.txtAddress.Style = Sunny.UI.UIStyle.White;
            this.txtAddress.StyleCustomMode = true;
            this.txtAddress.TabIndex = 16;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(312, 198);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(110, 29);
            this.lblAddress.Style = Sunny.UI.UIStyle.Custom;
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "联系地址";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel
            // 
            this.txtTel.ButtonFillColor = System.Drawing.Color.White;
            this.txtTel.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtTel.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtTel.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtTel.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtTel.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtTel.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtTel.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtTel.ButtonSymbol = 61761;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.FillColor2 = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTel.Location = new System.Drawing.Point(117, 191);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Maximum = 2147483647D;
            this.txtTel.MaxLength = 20;
            this.txtTel.Minimum = -2147483648D;
            this.txtTel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTel.Name = "txtTel";
            this.txtTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtTel.Size = new System.Drawing.Size(188, 42);
            this.txtTel.Style = Sunny.UI.UIStyle.White;
            this.txtTel.StyleCustomMode = true;
            this.txtTel.TabIndex = 14;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTel.Location = new System.Drawing.Point(3, 198);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(107, 29);
            this.lblTel.Style = Sunny.UI.UIStyle.Custom;
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "移动电话";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.ButtonFillColor = System.Drawing.Color.White;
            this.txtEmail.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtEmail.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtEmail.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtEmail.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtEmail.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtEmail.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEmail.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtEmail.ButtonSymbol = 61761;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FillColor2 = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(429, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Maximum = 2147483647D;
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Minimum = -2147483648D;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEmail.Size = new System.Drawing.Size(269, 42);
            this.txtEmail.Style = Sunny.UI.UIStyle.White;
            this.txtEmail.StyleCustomMode = true;
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(357, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 29);
            this.lblEmail.Style = Sunny.UI.UIStyle.Custom;
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "邮箱";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBirthday
            // 
            this.lblBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBirthday.Location = new System.Drawing.Point(3, 143);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(107, 29);
            this.lblBirthday.Style = Sunny.UI.UIStyle.Custom;
            this.lblBirthday.TabIndex = 9;
            this.lblBirthday.Text = "出生日期";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdFemale
            // 
            this.rdFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdFemale.Location = new System.Drawing.Point(501, 88);
            this.rdFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdFemale.Size = new System.Drawing.Size(57, 36);
            this.rdFemale.Style = Sunny.UI.UIStyle.Custom;
            this.rdFemale.TabIndex = 8;
            this.rdFemale.Text = "女";
            // 
            // rdMale
            // 
            this.rdMale.Checked = true;
            this.rdMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdMale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdMale.Location = new System.Drawing.Point(433, 88);
            this.rdMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdMale.Name = "rdMale";
            this.rdMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdMale.Size = new System.Drawing.Size(57, 36);
            this.rdMale.Style = Sunny.UI.UIStyle.Custom;
            this.rdMale.TabIndex = 7;
            this.rdMale.Text = "男";
            // 
            // txtNickName
            // 
            this.txtNickName.ButtonFillColor = System.Drawing.Color.White;
            this.txtNickName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtNickName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtNickName.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtNickName.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtNickName.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtNickName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtNickName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtNickName.ButtonSymbol = 61761;
            this.txtNickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNickName.FillColor2 = System.Drawing.Color.White;
            this.txtNickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickName.Location = new System.Drawing.Point(429, 32);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNickName.Maximum = 2147483647D;
            this.txtNickName.MaxLength = 20;
            this.txtNickName.Minimum = -2147483648D;
            this.txtNickName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtNickName.Size = new System.Drawing.Size(269, 42);
            this.txtNickName.Style = Sunny.UI.UIStyle.White;
            this.txtNickName.StyleCustomMode = true;
            this.txtNickName.TabIndex = 3;
            this.txtNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(357, 91);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 29);
            this.lblGender.Style = Sunny.UI.UIStyle.Custom;
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "性别";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNickName
            // 
            this.lblNickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNickName.Location = new System.Drawing.Point(357, 39);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(65, 29);
            this.lblNickName.Style = Sunny.UI.UIStyle.Custom;
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "昵称";
            this.lblNickName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.ButtonFillColor = System.Drawing.Color.White;
            this.txtName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtName.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtName.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtName.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtName.ButtonSymbol = 61761;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor2 = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(117, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.MaxLength = 20;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtName.Size = new System.Drawing.Size(188, 42);
            this.txtName.Style = Sunny.UI.UIStyle.White;
            this.txtName.StyleCustomMode = true;
            this.txtName.TabIndex = 5;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(45, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 29);
            this.lblName.Style = Sunny.UI.UIStyle.Custom;
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccount
            // 
            this.txtAccount.ButtonFillColor = System.Drawing.Color.White;
            this.txtAccount.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtAccount.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtAccount.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtAccount.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtAccount.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtAccount.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAccount.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtAccount.ButtonSymbol = 61761;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Enabled = false;
            this.txtAccount.FillColor2 = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccount.Location = new System.Drawing.Point(117, 32);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.Maximum = 2147483647D;
            this.txtAccount.MaxLength = 20;
            this.txtAccount.Minimum = -2147483648D;
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAccount.Size = new System.Drawing.Size(188, 42);
            this.txtAccount.Style = Sunny.UI.UIStyle.White;
            this.txtAccount.StyleCustomMode = true;
            this.txtAccount.TabIndex = 1;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccount.Location = new System.Drawing.Point(45, 39);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(65, 29);
            this.lblAccount.Style = Sunny.UI.UIStyle.Custom;
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "账号";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSelectAvator);
            this.tabPage2.Controls.Add(this.uiLabel10);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "头像";
            // 
            // btnSelectAvator
            // 
            this.btnSelectAvator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAvator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectAvator.Location = new System.Drawing.Point(258, 127);
            this.btnSelectAvator.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectAvator.Name = "btnSelectAvator";
            this.btnSelectAvator.Size = new System.Drawing.Size(137, 48);
            this.btnSelectAvator.Style = Sunny.UI.UIStyle.Custom;
            this.btnSelectAvator.TabIndex = 1;
            this.btnSelectAvator.Text = "上传头像";
            this.btnSelectAvator.Click += new System.EventHandler(this.btnSelectAvator_Click);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel10.Location = new System.Drawing.Point(111, 47);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(538, 29);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 0;
            this.uiLabel10.Text = "建议尺寸168*168，支持jpg,bmp,png,不能超过200kb";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnReset);
            this.tabPage3.Controls.Add(this.btnChangePassword);
            this.tabPage3.Controls.Add(this.txtComfirmPassword);
            this.tabPage3.Controls.Add(this.txtNewPassword);
            this.tabPage3.Controls.Add(this.lblComfirmPassword);
            this.tabPage3.Controls.Add(this.lblNewPassword);
            this.tabPage3.Controls.Add(this.txtOldPassword);
            this.tabPage3.Controls.Add(this.lblOldPassword);
            this.tabPage3.Controls.Add(this.uiLabel11);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 60);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "账号";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnReset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnReset.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btnReset.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btnReset.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(268, 261);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnReset.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btnReset.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btnReset.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btnReset.Size = new System.Drawing.Size(125, 44);
            this.btnReset.Style = Sunny.UI.UIStyle.Orange;
            this.btnReset.StyleCustomMode = true;
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.Location = new System.Drawing.Point(114, 261);
            this.btnChangePassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(125, 44);
            this.btnChangePassword.Style = Sunny.UI.UIStyle.Custom;
            this.btnChangePassword.TabIndex = 20;
            this.btnChangePassword.Text = "保存";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.ButtonFillColor = System.Drawing.Color.White;
            this.txtComfirmPassword.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtComfirmPassword.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtComfirmPassword.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtComfirmPassword.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtComfirmPassword.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtComfirmPassword.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtComfirmPassword.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtComfirmPassword.ButtonSymbol = 61761;
            this.txtComfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComfirmPassword.FillColor2 = System.Drawing.Color.White;
            this.txtComfirmPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComfirmPassword.Location = new System.Drawing.Point(205, 178);
            this.txtComfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComfirmPassword.Maximum = 2147483647D;
            this.txtComfirmPassword.Minimum = -2147483648D;
            this.txtComfirmPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.PasswordChar = '*';
            this.txtComfirmPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtComfirmPassword.Size = new System.Drawing.Size(188, 42);
            this.txtComfirmPassword.Style = Sunny.UI.UIStyle.White;
            this.txtComfirmPassword.StyleCustomMode = true;
            this.txtComfirmPassword.TabIndex = 11;
            this.txtComfirmPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.ButtonFillColor = System.Drawing.Color.White;
            this.txtNewPassword.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtNewPassword.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtNewPassword.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtNewPassword.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtNewPassword.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtNewPassword.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtNewPassword.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtNewPassword.ButtonSymbol = 61761;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FillColor2 = System.Drawing.Color.White;
            this.txtNewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.Location = new System.Drawing.Point(205, 123);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Maximum = 2147483647D;
            this.txtNewPassword.Minimum = -2147483648D;
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtNewPassword.Size = new System.Drawing.Size(188, 42);
            this.txtNewPassword.Style = Sunny.UI.UIStyle.White;
            this.txtNewPassword.StyleCustomMode = true;
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComfirmPassword
            // 
            this.lblComfirmPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComfirmPassword.Location = new System.Drawing.Point(88, 185);
            this.lblComfirmPassword.Name = "lblComfirmPassword";
            this.lblComfirmPassword.Size = new System.Drawing.Size(110, 29);
            this.lblComfirmPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lblComfirmPassword.TabIndex = 10;
            this.lblComfirmPassword.Text = "确认密码";
            this.lblComfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.Location = new System.Drawing.Point(114, 130);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(84, 29);
            this.lblNewPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "新密码";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.ButtonFillColor = System.Drawing.Color.White;
            this.txtOldPassword.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtOldPassword.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtOldPassword.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtOldPassword.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtOldPassword.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtOldPassword.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtOldPassword.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtOldPassword.ButtonSymbol = 61761;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPassword.FillColor2 = System.Drawing.Color.White;
            this.txtOldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldPassword.Location = new System.Drawing.Point(205, 71);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPassword.Maximum = 2147483647D;
            this.txtOldPassword.Minimum = -2147483648D;
            this.txtOldPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtOldPassword.Size = new System.Drawing.Size(188, 42);
            this.txtOldPassword.Style = Sunny.UI.UIStyle.White;
            this.txtOldPassword.StyleCustomMode = true;
            this.txtOldPassword.TabIndex = 7;
            this.txtOldPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOldPassword.Location = new System.Drawing.Point(114, 78);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(84, 29);
            this.lblOldPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lblOldPassword.TabIndex = 6;
            this.lblOldPassword.Text = "旧密码";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel11.Location = new System.Drawing.Point(45, 23);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(125, 29);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 0;
            this.uiLabel11.Text = "修改密码";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ShowTitle = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "账户管理";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.TitleForeColor = System.Drawing.Color.DimGray;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.uiPanel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageAvator)).EndInit();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.PictureBox imageAvator;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UITextBox txtSignature;
        private Sunny.UI.UILabel lblSignature;
        private Sunny.UI.UITextBox txtAddress;
        private Sunny.UI.UILabel lblAddress;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UILabel lblTel;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILabel lblBirthday;
        private Sunny.UI.UIRadioButton rdFemale;
        private Sunny.UI.UIRadioButton rdMale;
        private Sunny.UI.UILabel lblGender;
        private Sunny.UI.UILabel lblNickName;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UILabel lblAccount;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton btnSelectAvator;
        private Sunny.UI.UILabel uiLabel10;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIButton btnChangePassword;
        private Sunny.UI.UITextBox txtComfirmPassword;
        private Sunny.UI.UITextBox txtNewPassword;
        private Sunny.UI.UILabel lblComfirmPassword;
        private Sunny.UI.UILabel lblNewPassword;
        private Sunny.UI.UITextBox txtOldPassword;
        private Sunny.UI.UILabel lblOldPassword;
        private Sunny.UI.UILabel uiLabel11;
        private System.Windows.Forms.Panel titlePanel;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UISymbolLabel btnClose;
        private Sunny.UI.UITextBox txtNickName;
        private Sunny.UI.UIDatePicker txtBirthday;
    }
}