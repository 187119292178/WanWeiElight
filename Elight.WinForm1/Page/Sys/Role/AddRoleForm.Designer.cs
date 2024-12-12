namespace Elight.WinForm.Page.Sys.Role
{
    partial class AddRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoleForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboType = new Sunny.UI.UIComboBox();
            this.txtSortCode = new Sunny.UI.UIIntegerUpDown();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.comboDept = new Sunny.UI.UIComboBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
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
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.txtSortCode);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.uiLabel12);
            this.panel1.Controls.Add(this.comboDept);
            this.panel1.Controls.Add(this.uiLabel11);
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
            // comboType
            // 
            this.comboType.DataSource = null;
            this.comboType.FillColor = System.Drawing.Color.White;
            this.comboType.FillColor2 = System.Drawing.Color.White;
            this.comboType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboType.ItemSelectForeColor = System.Drawing.Color.White;
            this.comboType.Location = new System.Drawing.Point(130, 133);
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
            this.txtSortCode.Location = new System.Drawing.Point(129, 191);
            this.txtSortCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSortCode.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtSortCode.Size = new System.Drawing.Size(188, 36);
            this.txtSortCode.Style = Sunny.UI.UIStyle.White;
            this.txtSortCode.StyleCustomMode = true;
            this.txtSortCode.TabIndex = 5;
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
            this.btnConfirm.Location = new System.Drawing.Point(538, 473);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnConfirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnConfirm.Size = new System.Drawing.Size(125, 44);
            this.btnConfirm.Style = Sunny.UI.UIStyle.White;
            this.btnConfirm.StyleCustomMode = true;
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel12.Location = new System.Drawing.Point(15, 197);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(107, 29);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 45;
            this.uiLabel12.Text = "排序号";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.comboDept.Location = new System.Drawing.Point(445, 133);
            this.comboDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDept.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboDept.Name = "comboDept";
            this.comboDept.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboDept.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.comboDept.Size = new System.Drawing.Size(188, 36);
            this.comboDept.Style = Sunny.UI.UIStyle.White;
            this.comboDept.StyleCustomMode = true;
            this.comboDept.TabIndex = 4;
            this.comboDept.Text = "uiComboBox1";
            this.comboDept.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel11.Location = new System.Drawing.Point(328, 136);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(110, 29);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 42;
            this.uiLabel11.Text = "所属部门";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtRemark.Location = new System.Drawing.Point(129, 292);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemark.Maximum = 2147483647D;
            this.txtRemark.MaxLength = 128;
            this.txtRemark.Minimum = -2147483648D;
            this.txtRemark.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtRemark.Size = new System.Drawing.Size(504, 150);
            this.txtRemark.Style = Sunny.UI.UIStyle.White;
            this.txtRemark.StyleCustomMode = true;
            this.txtRemark.TabIndex = 6;
            this.txtRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRemark.Watermark = "请输入内容 ";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel7.Location = new System.Drawing.Point(12, 258);
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
            this.txtName.Location = new System.Drawing.Point(445, 66);
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
            this.uiLabel4.Location = new System.Drawing.Point(57, 136);
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
            // AddRoleForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 530);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoleForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ShowTitle = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "新增用户";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.TitleForeColor = System.Drawing.Color.DimGray;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddRoleForm_Load);
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
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtEnCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIComboBox comboDept;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIIntegerUpDown txtSortCode;
        private Sunny.UI.UIComboBox comboType;
    }
}