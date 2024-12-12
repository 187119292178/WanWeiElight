namespace Elight.WinForm.Page.Sys.User
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiTransfer1 = new Sunny.UI.UITransfer();
            this.comboDept = new Sunny.UI.UIComboBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtBirthday = new Sunny.UI.UIDatePicker();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtTel = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.rdFemale = new Sunny.UI.UIRadioButton();
            this.rdMale = new Sunny.UI.UIRadioButton();
            this.txtNickName = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.titlePanel);
            this.uiPanel1.Controls.Add(this.panel1);
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
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Controls.Add(this.btnClose);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1031, 43);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(986, 43);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "新增用户";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
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
            this.panel1.Controls.Add(this.uiIntegerUpDown1);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.uiLabel12);
            this.panel1.Controls.Add(this.uiTransfer1);
            this.panel1.Controls.Add(this.comboDept);
            this.panel1.Controls.Add(this.uiLabel11);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.uiLabel10);
            this.panel1.Controls.Add(this.txtBirthday);
            this.panel1.Controls.Add(this.uiLabel9);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.uiLabel8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.rdFemale);
            this.panel1.Controls.Add(this.rdMale);
            this.panel1.Controls.Add(this.txtNickName);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 558);
            this.panel1.TabIndex = 6;
            // 
            // uiIntegerUpDown1
            // 
            this.uiIntegerUpDown1.FillColor = System.Drawing.Color.White;
            this.uiIntegerUpDown1.FillColor2 = System.Drawing.Color.White;
            this.uiIntegerUpDown1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiIntegerUpDown1.Location = new System.Drawing.Point(445, 247);
            this.uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiIntegerUpDown1.Size = new System.Drawing.Size(188, 36);
            this.uiIntegerUpDown1.Style = Sunny.UI.UIStyle.White;
            this.uiIntegerUpDown1.StyleCustomMode = true;
            this.uiIntegerUpDown1.TabIndex = 12;
            this.uiIntegerUpDown1.Text = "txtSortCode";
            this.uiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.White;
            this.btnConfirm.FillColor2 = System.Drawing.Color.White;
            this.btnConfirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnConfirm.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnConfirm.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnConfirm.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnConfirm.Location = new System.Drawing.Point(882, 502);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnConfirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnConfirm.Size = new System.Drawing.Size(125, 44);
            this.btnConfirm.Style = Sunny.UI.UIStyle.White;
            this.btnConfirm.StyleCustomMode = true;
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel12.Location = new System.Drawing.Point(331, 253);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(107, 29);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 45;
            this.uiLabel12.Text = "排序号";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTransfer1
            // 
            this.uiTransfer1.FillColor = System.Drawing.Color.White;
            this.uiTransfer1.FillColor2 = System.Drawing.Color.White;
            this.uiTransfer1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTransfer1.Location = new System.Drawing.Point(129, 302);
            this.uiTransfer1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.uiTransfer1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTransfer1.Name = "uiTransfer1";
            this.uiTransfer1.Padding = new System.Windows.Forms.Padding(1);
            this.uiTransfer1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTransfer1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiTransfer1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTransfer1.Size = new System.Drawing.Size(417, 238);
            this.uiTransfer1.Style = Sunny.UI.UIStyle.White;
            this.uiTransfer1.StyleCustomMode = true;
            this.uiTransfer1.TabIndex = 13;
            this.uiTransfer1.Text = "uiTransfer1";
            this.uiTransfer1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboDept
            // 
            this.comboDept.DataSource = null;
            this.comboDept.FillColor = System.Drawing.Color.White;
            this.comboDept.FillColor2 = System.Drawing.Color.White;
            this.comboDept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboDept.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboDept.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboDept.ItemSelectForeColor = System.Drawing.Color.White;
            this.comboDept.Location = new System.Drawing.Point(445, 192);
            this.comboDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDept.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboDept.Name = "comboDept";
            this.comboDept.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboDept.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboDept.Size = new System.Drawing.Size(188, 36);
            this.comboDept.Style = Sunny.UI.UIStyle.White;
            this.comboDept.StyleCustomMode = true;
            this.comboDept.TabIndex = 9;
            this.comboDept.Text = "uiComboBox1";
            this.comboDept.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel11.Location = new System.Drawing.Point(328, 193);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(110, 29);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 42;
            this.uiLabel11.Text = "所属部门";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.ButtonFillColor = System.Drawing.Color.White;
            this.txtPassword.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtPassword.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtPassword.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtPassword.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtPassword.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtPassword.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtPassword.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtPassword.ButtonSymbol = 61761;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FillColor2 = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(782, 67);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Maximum = 2147483647D;
            this.txtPassword.MaxLength = 60;
            this.txtPassword.Minimum = -2147483648D;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtPassword.Size = new System.Drawing.Size(188, 42);
            this.txtPassword.Style = Sunny.UI.UIStyle.White;
            this.txtPassword.StyleCustomMode = true;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel10.Location = new System.Drawing.Point(665, 73);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(110, 29);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 40;
            this.uiLabel10.Text = "初始密码";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBirthday
            // 
            this.txtBirthday.FillColor = System.Drawing.Color.White;
            this.txtBirthday.FillColor2 = System.Drawing.Color.White;
            this.txtBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthday.Location = new System.Drawing.Point(445, 129);
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
            this.txtBirthday.TabIndex = 5;
            this.txtBirthday.Text = "2021-12-29";
            this.txtBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBirthday.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel9.Location = new System.Drawing.Point(15, 307);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(107, 29);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 37;
            this.uiLabel9.Text = "角色";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtAddress.Location = new System.Drawing.Point(129, 252);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Maximum = 2147483647D;
            this.txtAddress.MaxLength = 128;
            this.txtAddress.Minimum = -2147483648D;
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAddress.Size = new System.Drawing.Size(188, 42);
            this.txtAddress.Style = Sunny.UI.UIStyle.White;
            this.txtAddress.StyleCustomMode = true;
            this.txtAddress.TabIndex = 11;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel7.Location = new System.Drawing.Point(12, 258);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(110, 29);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 35;
            this.uiLabel7.Text = "联系地址";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtTel.Location = new System.Drawing.Point(782, 187);
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
            this.txtTel.TabIndex = 10;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel8.Location = new System.Drawing.Point(668, 193);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(107, 29);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 33;
            this.uiLabel8.Text = "移动电话";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtEmail.Location = new System.Drawing.Point(129, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Maximum = 2147483647D;
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Minimum = -2147483648D;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEmail.Size = new System.Drawing.Size(188, 42);
            this.txtEmail.Style = Sunny.UI.UIStyle.White;
            this.txtEmail.StyleCustomMode = true;
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(57, 199);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(65, 29);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 31;
            this.uiLabel5.Text = "邮箱";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(331, 133);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(107, 29);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 30;
            this.uiLabel6.Text = "出生日期";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdFemale
            // 
            this.rdFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdFemale.Location = new System.Drawing.Point(854, 126);
            this.rdFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdFemale.Size = new System.Drawing.Size(57, 36);
            this.rdFemale.StyleCustomMode = true;
            this.rdFemale.TabIndex = 7;
            this.rdFemale.Text = "女";
            // 
            // rdMale
            // 
            this.rdMale.Checked = true;
            this.rdMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdMale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdMale.Location = new System.Drawing.Point(786, 126);
            this.rdMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdMale.Name = "rdMale";
            this.rdMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdMale.Size = new System.Drawing.Size(57, 36);
            this.rdMale.StyleCustomMode = true;
            this.rdMale.TabIndex = 6;
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
            this.txtNickName.Location = new System.Drawing.Point(445, 66);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNickName.Maximum = 2147483647D;
            this.txtNickName.MaxLength = 20;
            this.txtNickName.Minimum = -2147483648D;
            this.txtNickName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtNickName.Size = new System.Drawing.Size(188, 42);
            this.txtNickName.Style = Sunny.UI.UIStyle.White;
            this.txtNickName.StyleCustomMode = true;
            this.txtNickName.TabIndex = 2;
            this.txtNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(710, 129);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(65, 29);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 27;
            this.uiLabel3.Text = "性别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(373, 73);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(65, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 23;
            this.uiLabel2.Text = "昵称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtName.Location = new System.Drawing.Point(129, 129);
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
            this.txtName.TabIndex = 4;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(57, 136);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(65, 29);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "姓名";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtAccount.FillColor2 = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccount.Location = new System.Drawing.Point(129, 66);
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
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(57, 73);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(65, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "账号";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddUserForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.ShowTitle = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "新增用户";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.uiPanel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel titlePanel;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UISymbolLabel btnClose;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIDatePicker txtBirthday;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtAddress;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRadioButton rdFemale;
        private Sunny.UI.UIRadioButton rdMale;
        private Sunny.UI.UITextBox txtNickName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIComboBox comboDept;
        private Sunny.UI.UITransfer uiTransfer1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
    }
}