namespace Elight.WinForm.Page.Sys.Organize
{
    partial class AddOrganizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrganizeForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtFax = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtWeChat = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtTelePhone = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtManagerId = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.comboType = new Sunny.UI.UIComboBox();
            this.txtSortCode = new Sunny.UI.UIIntegerUpDown();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.txtRemark = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtEnCode = new Sunny.UI.UITextBox();
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
            this.uiPanel1.Size = new System.Drawing.Size(686, 530);
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
            this.titlePanel.Size = new System.Drawing.Size(686, 43);
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
            this.lblTitle.Size = new System.Drawing.Size(641, 43);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "新增角色";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(641, 0);
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
            this.panel1.Controls.Add(this.uiLabel14);
            this.panel1.Controls.Add(this.uiLabel13);
            this.panel1.Controls.Add(this.uiLabel11);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.uiLabel10);
            this.panel1.Controls.Add(this.txtFax);
            this.panel1.Controls.Add(this.uiLabel9);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.uiLabel8);
            this.panel1.Controls.Add(this.txtWeChat);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.txtTelePhone);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.txtManagerId);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.txtSortCode);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.uiLabel12);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.txtEnCode);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 530);
            this.panel1.TabIndex = 6;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel14.ForeColor = System.Drawing.Color.Red;
            this.uiLabel14.Location = new System.Drawing.Point(53, 135);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(21, 29);
            this.uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel14.StyleCustomMode = true;
            this.uiLabel14.TabIndex = 59;
            this.uiLabel14.Text = "*";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel13.ForeColor = System.Drawing.Color.Red;
            this.uiLabel13.Location = new System.Drawing.Point(372, 73);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(21, 29);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel13.StyleCustomMode = true;
            this.uiLabel13.TabIndex = 58;
            this.uiLabel13.Text = "*";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel11.ForeColor = System.Drawing.Color.Red;
            this.uiLabel11.Location = new System.Drawing.Point(53, 73);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(21, 29);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.StyleCustomMode = true;
            this.uiLabel11.TabIndex = 57;
            this.uiLabel11.Text = "*";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtAddress.Location = new System.Drawing.Point(129, 302);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Maximum = 2147483647D;
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Minimum = -2147483648D;
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtAddress.Size = new System.Drawing.Size(188, 42);
            this.txtAddress.Style = Sunny.UI.UIStyle.White;
            this.txtAddress.StyleCustomMode = true;
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel10.Location = new System.Drawing.Point(57, 309);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(65, 29);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 56;
            this.uiLabel10.Text = "地址";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFax
            // 
            this.txtFax.ButtonFillColor = System.Drawing.Color.White;
            this.txtFax.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtFax.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtFax.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtFax.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtFax.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtFax.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtFax.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtFax.ButtonSymbol = 61761;
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.FillColor2 = System.Drawing.Color.White;
            this.txtFax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFax.Location = new System.Drawing.Point(444, 239);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFax.Maximum = 2147483647D;
            this.txtFax.MaxLength = 20;
            this.txtFax.Minimum = -2147483648D;
            this.txtFax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFax.Name = "txtFax";
            this.txtFax.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtFax.Size = new System.Drawing.Size(188, 42);
            this.txtFax.Style = Sunny.UI.UIStyle.White;
            this.txtFax.StyleCustomMode = true;
            this.txtFax.TabIndex = 8;
            this.txtFax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel9.Location = new System.Drawing.Point(372, 246);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(65, 29);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 56;
            this.uiLabel9.Text = "传真";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtEmail.Location = new System.Drawing.Point(129, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Maximum = 2147483647D;
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Minimum = -2147483648D;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEmail.Size = new System.Drawing.Size(188, 42);
            this.txtEmail.Style = Sunny.UI.UIStyle.White;
            this.txtEmail.StyleCustomMode = true;
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel8.Location = new System.Drawing.Point(57, 252);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(65, 29);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 54;
            this.uiLabel8.Text = "邮箱";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWeChat
            // 
            this.txtWeChat.ButtonFillColor = System.Drawing.Color.White;
            this.txtWeChat.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtWeChat.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtWeChat.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtWeChat.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtWeChat.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtWeChat.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtWeChat.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtWeChat.ButtonSymbol = 61761;
            this.txtWeChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeChat.FillColor2 = System.Drawing.Color.White;
            this.txtWeChat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeChat.Location = new System.Drawing.Point(444, 184);
            this.txtWeChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeChat.Maximum = 2147483647D;
            this.txtWeChat.MaxLength = 20;
            this.txtWeChat.Minimum = -2147483648D;
            this.txtWeChat.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtWeChat.Name = "txtWeChat";
            this.txtWeChat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtWeChat.Size = new System.Drawing.Size(188, 42);
            this.txtWeChat.Style = Sunny.UI.UIStyle.White;
            this.txtWeChat.StyleCustomMode = true;
            this.txtWeChat.TabIndex = 6;
            this.txtWeChat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(372, 191);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(65, 29);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 52;
            this.uiLabel6.Text = "微信";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelePhone
            // 
            this.txtTelePhone.ButtonFillColor = System.Drawing.Color.White;
            this.txtTelePhone.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtTelePhone.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtTelePhone.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtTelePhone.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtTelePhone.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtTelePhone.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtTelePhone.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtTelePhone.ButtonSymbol = 61761;
            this.txtTelePhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelePhone.FillColor2 = System.Drawing.Color.White;
            this.txtTelePhone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelePhone.Location = new System.Drawing.Point(129, 184);
            this.txtTelePhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelePhone.Maximum = 2147483647D;
            this.txtTelePhone.MaxLength = 20;
            this.txtTelePhone.Minimum = -2147483648D;
            this.txtTelePhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTelePhone.Name = "txtTelePhone";
            this.txtTelePhone.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtTelePhone.Size = new System.Drawing.Size(188, 42);
            this.txtTelePhone.Style = Sunny.UI.UIStyle.White;
            this.txtTelePhone.StyleCustomMode = true;
            this.txtTelePhone.TabIndex = 5;
            this.txtTelePhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(12, 191);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 29);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 50;
            this.uiLabel5.Text = "联系电话";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtManagerId
            // 
            this.txtManagerId.ButtonFillColor = System.Drawing.Color.White;
            this.txtManagerId.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtManagerId.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtManagerId.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtManagerId.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtManagerId.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtManagerId.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtManagerId.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtManagerId.ButtonSymbol = 61761;
            this.txtManagerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagerId.FillColor2 = System.Drawing.Color.White;
            this.txtManagerId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerId.Location = new System.Drawing.Point(444, 124);
            this.txtManagerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtManagerId.Maximum = 2147483647D;
            this.txtManagerId.MaxLength = 20;
            this.txtManagerId.Minimum = -2147483648D;
            this.txtManagerId.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtManagerId.Size = new System.Drawing.Size(188, 42);
            this.txtManagerId.Style = Sunny.UI.UIStyle.White;
            this.txtManagerId.StyleCustomMode = true;
            this.txtManagerId.TabIndex = 4;
            this.txtManagerId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(372, 131);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(65, 29);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 48;
            this.uiLabel3.Text = "主管";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboType
            // 
            this.comboType.DataSource = null;
            this.comboType.FillColor = System.Drawing.Color.White;
            this.comboType.FillColor2 = System.Drawing.Color.White;
            this.comboType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboType.ItemSelectForeColor = System.Drawing.Color.White;
            this.comboType.Location = new System.Drawing.Point(129, 128);
            this.comboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboType.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboType.Name = "comboType";
            this.comboType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboType.Size = new System.Drawing.Size(188, 36);
            this.comboType.Style = Sunny.UI.UIStyle.White;
            this.comboType.StyleCustomMode = true;
            this.comboType.TabIndex = 3;
            this.comboType.Text = "uiComboBox1";
            this.comboType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSortCode
            // 
            this.txtSortCode.FillColor = System.Drawing.Color.White;
            this.txtSortCode.FillColor2 = System.Drawing.Color.White;
            this.txtSortCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSortCode.Location = new System.Drawing.Point(444, 302);
            this.txtSortCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSortCode.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtSortCode.Size = new System.Drawing.Size(188, 36);
            this.txtSortCode.Style = Sunny.UI.UIStyle.White;
            this.txtSortCode.StyleCustomMode = true;
            this.txtSortCode.TabIndex = 10;
            this.txtSortCode.Text = "txtSortCode";
            this.txtSortCode.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnConfirm.Location = new System.Drawing.Point(549, 474);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnConfirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnConfirm.Size = new System.Drawing.Size(125, 44);
            this.btnConfirm.Style = Sunny.UI.UIStyle.White;
            this.btnConfirm.StyleCustomMode = true;
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel12.Location = new System.Drawing.Point(330, 308);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(107, 29);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 45;
            this.uiLabel12.Text = "排序号";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.ButtonFillColor = System.Drawing.Color.White;
            this.txtRemark.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtRemark.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtRemark.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtRemark.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtRemark.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtRemark.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtRemark.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtRemark.ButtonSymbol = 61761;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.FillColor2 = System.Drawing.Color.White;
            this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRemark.Location = new System.Drawing.Point(129, 373);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemark.Maximum = 2147483647D;
            this.txtRemark.MaxLength = 128;
            this.txtRemark.Minimum = -2147483648D;
            this.txtRemark.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtRemark.Size = new System.Drawing.Size(414, 90);
            this.txtRemark.Style = Sunny.UI.UIStyle.White;
            this.txtRemark.StyleCustomMode = true;
            this.txtRemark.TabIndex = 11;
            this.txtRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRemark.Watermark = "请输入内容 ";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel7.Location = new System.Drawing.Point(12, 373);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(110, 29);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 35;
            this.uiLabel7.Text = "备注";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtName.Location = new System.Drawing.Point(444, 66);
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
            this.txtName.TabIndex = 2;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(373, 73);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(65, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 23;
            this.uiLabel2.Text = "名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(56, 131);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(65, 29);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "类型";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEnCode
            // 
            this.txtEnCode.ButtonFillColor = System.Drawing.Color.White;
            this.txtEnCode.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtEnCode.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtEnCode.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtEnCode.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtEnCode.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtEnCode.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEnCode.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtEnCode.ButtonSymbol = 61761;
            this.txtEnCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnCode.FillColor2 = System.Drawing.Color.White;
            this.txtEnCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnCode.Location = new System.Drawing.Point(129, 66);
            this.txtEnCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnCode.Maximum = 2147483647D;
            this.txtEnCode.MaxLength = 20;
            this.txtEnCode.Minimum = -2147483648D;
            this.txtEnCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEnCode.Name = "txtEnCode";
            this.txtEnCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtEnCode.Size = new System.Drawing.Size(188, 42);
            this.txtEnCode.Style = Sunny.UI.UIStyle.White;
            this.txtEnCode.StyleCustomMode = true;
            this.txtEnCode.TabIndex = 1;
            this.txtEnCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(57, 73);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(65, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "编码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddOrganizeForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 530);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrganizeForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ShowTitle = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "新增用户";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.TitleForeColor = System.Drawing.Color.DimGray;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddOrganizeForm_Load);
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
        private Sunny.UI.UITextBox txtRemark;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtEnCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIIntegerUpDown txtSortCode;
        private Sunny.UI.UIComboBox comboType;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtManagerId;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtTelePhone;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtWeChat;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtFax;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtAddress;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel13;
    }
}