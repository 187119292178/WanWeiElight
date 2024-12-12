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
            uiPanel1 = new Sunny.UI.UIPanel();
            titlePanel = new System.Windows.Forms.Panel();
            lblTitle = new Sunny.UI.UILabel();
            btnClose = new Sunny.UI.UISymbolLabel();
            panel1 = new System.Windows.Forms.Panel();
            uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            btnConfirm = new Sunny.UI.UIButton();
            uiLabel12 = new Sunny.UI.UILabel();
            uiTransfer1 = new Sunny.UI.UITransfer();
            uiLabel11 = new Sunny.UI.UILabel();
            uiLabel10 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            rdFemale = new Sunny.UI.UIRadioButton();
            rdMale = new Sunny.UI.UIRadioButton();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            txtAccount = new Sunny.UI.UITextBox();
            txtName = new Sunny.UI.UITextBox();
            txtNickName = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtTel = new Sunny.UI.UITextBox();
            txtAddress = new Sunny.UI.UITextBox();
            txtBirthday = new Sunny.UI.UIDatePicker();
            txtPassword = new Sunny.UI.UITextBox();
            comboDept = new Sunny.UI.UIComboBox();
            uiPanel1.SuspendLayout();
            titlePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(titlePanel);
            uiPanel1.Controls.Add(panel1);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            uiPanel1.FillColor = System.Drawing.Color.FromArgb(235, 241, 243);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(0, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = System.Drawing.Color.Silver;
            uiPanel1.Size = new System.Drawing.Size(1031, 558);
            uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            uiPanel1.StyleCustomMode = true;
            uiPanel1.TabIndex = 6;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            titlePanel.Controls.Add(lblTitle);
            titlePanel.Controls.Add(btnClose);
            titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            titlePanel.Location = new System.Drawing.Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new System.Drawing.Size(1031, 43);
            titlePanel.TabIndex = 7;
            titlePanel.MouseDown += titlePanel_MouseDown;
            titlePanel.MouseMove += titlePanel_MouseMove;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(986, 43);
            lblTitle.Style = Sunny.UI.UIStyle.Custom;
            lblTitle.TabIndex = 1;
            lblTitle.Text = "新增用户";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += titlePanel_MouseDown;
            lblTitle.MouseMove += titlePanel_MouseMove;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnClose.Location = new System.Drawing.Point(986, 0);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            btnClose.Size = new System.Drawing.Size(45, 43);
            btnClose.Style = Sunny.UI.UIStyle.Custom;
            btnClose.Symbol = 77;
            btnClose.SymbolSize = 60;
            btnClose.TabIndex = 0;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(uiIntegerUpDown1);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(uiLabel12);
            panel1.Controls.Add(uiTransfer1);
            panel1.Controls.Add(uiLabel11);
            panel1.Controls.Add(uiLabel10);
            panel1.Controls.Add(uiLabel9);
            panel1.Controls.Add(uiLabel7);
            panel1.Controls.Add(uiLabel8);
            panel1.Controls.Add(uiLabel5);
            panel1.Controls.Add(uiLabel6);
            panel1.Controls.Add(rdFemale);
            panel1.Controls.Add(rdMale);
            panel1.Controls.Add(uiLabel3);
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(uiLabel4);
            panel1.Controls.Add(uiLabel1);
            panel1.Controls.Add(txtAccount);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtBirthday);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtNickName);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(comboDept);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1031, 558);
            panel1.TabIndex = 6;
            // 
            // uiIntegerUpDown1
            // 
            uiIntegerUpDown1.FillColor = System.Drawing.Color.White;
            uiIntegerUpDown1.FillColor2 = System.Drawing.Color.White;
            uiIntegerUpDown1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiIntegerUpDown1.Location = new System.Drawing.Point(445, 247);
            uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            uiIntegerUpDown1.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            uiIntegerUpDown1.Size = new System.Drawing.Size(188, 36);
            uiIntegerUpDown1.Style = Sunny.UI.UIStyle.White;
            uiIntegerUpDown1.StyleCustomMode = true;
            uiIntegerUpDown1.TabIndex = 12;
            uiIntegerUpDown1.Text = "txtSortCode";
            uiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnConfirm.Location = new System.Drawing.Point(882, 502);
            btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(125, 44);
            btnConfirm.StyleCustomMode = true;
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "确定";
            btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel12.Location = new System.Drawing.Point(331, 253);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(107, 29);
            uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            uiLabel12.TabIndex = 45;
            uiLabel12.Text = "排序号";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTransfer1
            // 
            uiTransfer1.FillColor = System.Drawing.Color.White;
            uiTransfer1.FillColor2 = System.Drawing.Color.White;
            uiTransfer1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiTransfer1.Location = new System.Drawing.Point(129, 302);
            uiTransfer1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            uiTransfer1.MinimumSize = new System.Drawing.Size(1, 1);
            uiTransfer1.Name = "uiTransfer1";
            uiTransfer1.Padding = new System.Windows.Forms.Padding(1);
            uiTransfer1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiTransfer1.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            uiTransfer1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            uiTransfer1.Size = new System.Drawing.Size(417, 238);
            uiTransfer1.Style = Sunny.UI.UIStyle.White;
            uiTransfer1.StyleCustomMode = true;
            uiTransfer1.TabIndex = 13;
            uiTransfer1.Text = "uiTransfer1";
            uiTransfer1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel11.Location = new System.Drawing.Point(328, 193);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new System.Drawing.Size(110, 29);
            uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            uiLabel11.TabIndex = 42;
            uiLabel11.Text = "所属部门";
            uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel10.Location = new System.Drawing.Point(665, 73);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new System.Drawing.Size(110, 29);
            uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            uiLabel10.TabIndex = 40;
            uiLabel10.Text = "初始密码";
            uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel9.Location = new System.Drawing.Point(15, 307);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(107, 29);
            uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            uiLabel9.TabIndex = 37;
            uiLabel9.Text = "角色";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel7.Location = new System.Drawing.Point(12, 258);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(110, 29);
            uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            uiLabel7.TabIndex = 35;
            uiLabel7.Text = "联系地址";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel8.Location = new System.Drawing.Point(668, 193);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(107, 29);
            uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            uiLabel8.TabIndex = 33;
            uiLabel8.Text = "移动电话";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(57, 199);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(65, 29);
            uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            uiLabel5.TabIndex = 31;
            uiLabel5.Text = "邮箱";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel6.Location = new System.Drawing.Point(331, 133);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(107, 29);
            uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            uiLabel6.TabIndex = 30;
            uiLabel6.Text = "出生日期";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdFemale
            // 
            rdFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            rdFemale.Font = new System.Drawing.Font("微软雅黑", 12F);
            rdFemale.Location = new System.Drawing.Point(854, 126);
            rdFemale.MinimumSize = new System.Drawing.Size(1, 1);
            rdFemale.Name = "rdFemale";
            rdFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            rdFemale.Size = new System.Drawing.Size(57, 36);
            rdFemale.StyleCustomMode = true;
            rdFemale.TabIndex = 7;
            rdFemale.Text = "女";
            // 
            // rdMale
            // 
            rdMale.Checked = true;
            rdMale.Cursor = System.Windows.Forms.Cursors.Hand;
            rdMale.Font = new System.Drawing.Font("微软雅黑", 12F);
            rdMale.Location = new System.Drawing.Point(786, 126);
            rdMale.MinimumSize = new System.Drawing.Size(1, 1);
            rdMale.Name = "rdMale";
            rdMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            rdMale.Size = new System.Drawing.Size(57, 36);
            rdMale.StyleCustomMode = true;
            rdMale.TabIndex = 6;
            rdMale.Text = "男";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(710, 129);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(65, 29);
            uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            uiLabel3.TabIndex = 27;
            uiLabel3.Text = "性别";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.Location = new System.Drawing.Point(373, 73);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(65, 29);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.TabIndex = 23;
            uiLabel2.Text = "昵称";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.Location = new System.Drawing.Point(57, 136);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(65, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.TabIndex = 25;
            uiLabel4.Text = "姓名";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(57, 73);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(65, 29);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 21;
            uiLabel1.Text = "账号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccount
            // 
            txtAccount.ButtonFillColor = System.Drawing.Color.White;
            txtAccount.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtAccount.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtAccount.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtAccount.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtAccount.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtAccount.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtAccount.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtAccount.ButtonSymbol = 61761;
            txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAccount.FillColor2 = System.Drawing.Color.White;
            txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtAccount.Location = new System.Drawing.Point(129, 66);
            txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAccount.Maximum = 2147483647D;
            txtAccount.MaxLength = 20;
            txtAccount.Minimum = -2147483648D;
            txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            txtAccount.Name = "txtAccount";
            txtAccount.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtAccount.Size = new System.Drawing.Size(188, 42);
            txtAccount.Style = Sunny.UI.UIStyle.White;
            txtAccount.StyleCustomMode = true;
            txtAccount.TabIndex = 1;
            txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.ButtonFillColor = System.Drawing.Color.White;
            txtName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtName.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtName.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtName.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtName.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtName.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtName.ButtonSymbol = 61761;
            txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtName.FillColor2 = System.Drawing.Color.White;
            txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtName.Location = new System.Drawing.Point(129, 129);
            txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtName.Maximum = 2147483647D;
            txtName.MaxLength = 20;
            txtName.Minimum = -2147483648D;
            txtName.MinimumSize = new System.Drawing.Size(1, 16);
            txtName.Name = "txtName";
            txtName.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtName.Size = new System.Drawing.Size(188, 42);
            txtName.Style = Sunny.UI.UIStyle.White;
            txtName.StyleCustomMode = true;
            txtName.TabIndex = 4;
            txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNickName
            // 
            txtNickName.ButtonFillColor = System.Drawing.Color.White;
            txtNickName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtNickName.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtNickName.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtNickName.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtNickName.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtNickName.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtNickName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtNickName.ButtonSymbol = 61761;
            txtNickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNickName.FillColor2 = System.Drawing.Color.White;
            txtNickName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtNickName.Location = new System.Drawing.Point(445, 66);
            txtNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtNickName.Maximum = 2147483647D;
            txtNickName.MaxLength = 20;
            txtNickName.Minimum = -2147483648D;
            txtNickName.MinimumSize = new System.Drawing.Size(1, 16);
            txtNickName.Name = "txtNickName";
            txtNickName.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtNickName.Size = new System.Drawing.Size(188, 42);
            txtNickName.Style = Sunny.UI.UIStyle.White;
            txtNickName.StyleCustomMode = true;
            txtNickName.TabIndex = 2;
            txtNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.ButtonFillColor = System.Drawing.Color.White;
            txtEmail.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtEmail.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtEmail.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtEmail.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtEmail.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtEmail.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtEmail.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtEmail.ButtonSymbol = 61761;
            txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEmail.FillColor2 = System.Drawing.Color.White;
            txtEmail.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtEmail.Location = new System.Drawing.Point(129, 192);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Maximum = 2147483647D;
            txtEmail.MaxLength = 60;
            txtEmail.Minimum = -2147483648D;
            txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtEmail.Size = new System.Drawing.Size(188, 42);
            txtEmail.Style = Sunny.UI.UIStyle.White;
            txtEmail.StyleCustomMode = true;
            txtEmail.TabIndex = 8;
            txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTel
            // 
            txtTel.ButtonFillColor = System.Drawing.Color.White;
            txtTel.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtTel.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtTel.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtTel.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtTel.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtTel.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtTel.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtTel.ButtonSymbol = 61761;
            txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTel.FillColor2 = System.Drawing.Color.White;
            txtTel.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtTel.Location = new System.Drawing.Point(782, 187);
            txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTel.Maximum = 2147483647D;
            txtTel.MaxLength = 20;
            txtTel.Minimum = -2147483648D;
            txtTel.MinimumSize = new System.Drawing.Size(1, 16);
            txtTel.Name = "txtTel";
            txtTel.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtTel.Size = new System.Drawing.Size(188, 42);
            txtTel.Style = Sunny.UI.UIStyle.White;
            txtTel.StyleCustomMode = true;
            txtTel.TabIndex = 10;
            txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.ButtonFillColor = System.Drawing.Color.White;
            txtAddress.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtAddress.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtAddress.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtAddress.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtAddress.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtAddress.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtAddress.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtAddress.ButtonSymbol = 61761;
            txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAddress.FillColor2 = System.Drawing.Color.White;
            txtAddress.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtAddress.Location = new System.Drawing.Point(129, 252);
            txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAddress.Maximum = 2147483647D;
            txtAddress.MaxLength = 128;
            txtAddress.Minimum = -2147483648D;
            txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            txtAddress.Name = "txtAddress";
            txtAddress.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtAddress.Size = new System.Drawing.Size(188, 42);
            txtAddress.Style = Sunny.UI.UIStyle.White;
            txtAddress.StyleCustomMode = true;
            txtAddress.TabIndex = 11;
            txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBirthday
            // 
            txtBirthday.FillColor = System.Drawing.Color.White;
            txtBirthday.FillColor2 = System.Drawing.Color.White;
            txtBirthday.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtBirthday.Location = new System.Drawing.Point(445, 129);
            txtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtBirthday.MaxLength = 10;
            txtBirthday.MinimumSize = new System.Drawing.Size(63, 0);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            txtBirthday.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtBirthday.Size = new System.Drawing.Size(188, 36);
            txtBirthday.Style = Sunny.UI.UIStyle.White;
            txtBirthday.StyleCustomMode = true;
            txtBirthday.SymbolDropDown = 61555;
            txtBirthday.SymbolNormal = 61555;
            txtBirthday.TabIndex = 5;
            txtBirthday.Text = "2021-12-29";
            txtBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtBirthday.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
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
            txtPassword.Location = new System.Drawing.Point(782, 67);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPassword.Maximum = 2147483647D;
            txtPassword.MaxLength = 60;
            txtPassword.Minimum = -2147483648D;
            txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtPassword.Size = new System.Drawing.Size(188, 42);
            txtPassword.Style = Sunny.UI.UIStyle.White;
            txtPassword.StyleCustomMode = true;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboDept
            // 
            comboDept.DataSource = null;
            comboDept.FillColor = System.Drawing.Color.White;
            comboDept.FillColor2 = System.Drawing.Color.White;
            comboDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            comboDept.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            comboDept.ItemSelectBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            comboDept.ItemSelectForeColor = System.Drawing.Color.White;
            comboDept.Location = new System.Drawing.Point(445, 192);
            comboDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comboDept.MinimumSize = new System.Drawing.Size(63, 0);
            comboDept.Name = "comboDept";
            comboDept.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            comboDept.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            comboDept.Size = new System.Drawing.Size(188, 36);
            comboDept.Style = Sunny.UI.UIStyle.White;
            comboDept.StyleCustomMode = true;
            comboDept.TabIndex = 9;
            comboDept.Text = "uiComboBox1";
            comboDept.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddUserForm
            // 
            AllowShowTitle = false;
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1031, 558);
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            ControlBoxForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            Controls.Add(uiPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            Padding = new System.Windows.Forms.Padding(0);
            RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            ShowTitle = false;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.White;
            StyleCustomMode = true;
            Text = "新增用户";
            TitleColor = System.Drawing.Color.FromArgb(216, 219, 227);
            TitleForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            Load += AddUserForm_Load;
            uiPanel1.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel titlePanel;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UISymbolLabel btnClose;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITransfer uiTransfer1;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRadioButton rdFemale;
        private Sunny.UI.UIRadioButton rdMale;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtNickName;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UITextBox txtAddress;
        private Sunny.UI.UIDatePicker txtBirthday;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UIComboBox comboDept;
    }
}