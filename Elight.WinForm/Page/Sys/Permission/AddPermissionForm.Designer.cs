namespace Elight.WinForm.Page.Sys.Permission
{
    partial class AddPermissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPermissionForm));
            uiPanel1 = new Sunny.UI.UIPanel();
            titlePanel = new System.Windows.Forms.Panel();
            lblTitle = new Sunny.UI.UILabel();
            btnClose = new Sunny.UI.UISymbolLabel();
            panel1 = new System.Windows.Forms.Panel();
            uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            btnSelectIcon = new Sunny.UI.UISymbolButton();
            uiLabel9 = new Sunny.UI.UILabel();
            txtType = new Sunny.UI.UIComboBox();
            uiLabel14 = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            txtIcon = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            txtSortCode = new Sunny.UI.UIIntegerUpDown();
            btnConfirm = new Sunny.UI.UIButton();
            uiLabel12 = new Sunny.UI.UILabel();
            txtRemark = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            txtName = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            txtEnCode = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
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
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiPanel1.Location = new System.Drawing.Point(0, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = System.Drawing.Color.Silver;
            uiPanel1.Size = new System.Drawing.Size(795, 482);
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
            titlePanel.Size = new System.Drawing.Size(795, 43);
            titlePanel.TabIndex = 7;
            titlePanel.MouseDown += titlePanel_MouseDown;
            titlePanel.MouseMove += titlePanel_MouseMove;
            // 
            // lblTitle
            // 
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(750, 43);
            lblTitle.Style = Sunny.UI.UIStyle.Custom;
            lblTitle.TabIndex = 1;
            lblTitle.Text = "新增权限";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += titlePanel_MouseDown;
            lblTitle.MouseMove += titlePanel_MouseMove;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(750, 0);
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
            panel1.Controls.Add(uiComboTreeView1);
            panel1.Controls.Add(btnSelectIcon);
            panel1.Controls.Add(uiLabel9);
            panel1.Controls.Add(txtType);
            panel1.Controls.Add(uiLabel14);
            panel1.Controls.Add(uiLabel13);
            panel1.Controls.Add(uiLabel11);
            panel1.Controls.Add(txtIcon);
            panel1.Controls.Add(uiLabel8);
            panel1.Controls.Add(uiLabel5);
            panel1.Controls.Add(txtSortCode);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(uiLabel12);
            panel1.Controls.Add(txtRemark);
            panel1.Controls.Add(uiLabel7);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(uiLabel4);
            panel1.Controls.Add(txtEnCode);
            panel1.Controls.Add(uiLabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(795, 482);
            panel1.TabIndex = 6;
            // 
            // uiComboTreeView1
            // 
            uiComboTreeView1.CanSelectRootNode = true;
            uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboTreeView1.FillColor = System.Drawing.Color.White;
            uiComboTreeView1.FillColor2 = System.Drawing.Color.White;
            uiComboTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiComboTreeView1.Location = new System.Drawing.Point(129, 138);
            uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            uiComboTreeView1.Name = "uiComboTreeView1";
            uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            uiComboTreeView1.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            uiComboTreeView1.ShowLines = true;
            uiComboTreeView1.Size = new System.Drawing.Size(265, 36);
            uiComboTreeView1.Style = Sunny.UI.UIStyle.White;
            uiComboTreeView1.StyleCustomMode = true;
            uiComboTreeView1.TabIndex = 3;
            uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectIcon
            // 
            btnSelectIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSelectIcon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSelectIcon.Location = new System.Drawing.Point(351, 211);
            btnSelectIcon.MinimumSize = new System.Drawing.Size(1, 1);
            btnSelectIcon.Name = "btnSelectIcon";
            btnSelectIcon.Size = new System.Drawing.Size(43, 43);
            btnSelectIcon.StyleCustomMode = true;
            btnSelectIcon.Symbol = 61442;
            btnSelectIcon.SymbolSize = 30;
            btnSelectIcon.TabIndex = 8;
            btnSelectIcon.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSelectIcon.Click += btnSelectIcon_Click;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel9.ForeColor = System.Drawing.Color.Red;
            uiLabel9.Location = new System.Drawing.Point(442, 142);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(21, 29);
            uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            uiLabel9.StyleCustomMode = true;
            uiLabel9.TabIndex = 60;
            uiLabel9.Text = "*";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtType
            // 
            txtType.DataSource = null;
            txtType.FillColor = System.Drawing.Color.White;
            txtType.FillColor2 = System.Drawing.Color.White;
            txtType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            txtType.ItemSelectBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtType.ItemSelectForeColor = System.Drawing.Color.White;
            txtType.Location = new System.Drawing.Point(518, 138);
            txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtType.MinimumSize = new System.Drawing.Size(63, 0);
            txtType.Name = "txtType";
            txtType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            txtType.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtType.Size = new System.Drawing.Size(227, 36);
            txtType.Style = Sunny.UI.UIStyle.White;
            txtType.StyleCustomMode = true;
            txtType.TabIndex = 5;
            txtType.Text = "uiComboBox1";
            txtType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel14.ForeColor = System.Drawing.Color.Red;
            uiLabel14.Location = new System.Drawing.Point(53, 142);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new System.Drawing.Size(21, 29);
            uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            uiLabel14.StyleCustomMode = true;
            uiLabel14.TabIndex = 59;
            uiLabel14.Text = "*";
            uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel13
            // 
            uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel13.ForeColor = System.Drawing.Color.Red;
            uiLabel13.Location = new System.Drawing.Point(451, 73);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new System.Drawing.Size(21, 29);
            uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            uiLabel13.StyleCustomMode = true;
            uiLabel13.TabIndex = 58;
            uiLabel13.Text = "*";
            uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel11.ForeColor = System.Drawing.Color.Red;
            uiLabel11.Location = new System.Drawing.Point(53, 73);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new System.Drawing.Size(21, 29);
            uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            uiLabel11.StyleCustomMode = true;
            uiLabel11.TabIndex = 57;
            uiLabel11.Text = "*";
            uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIcon
            // 
            txtIcon.ButtonFillColor = System.Drawing.Color.White;
            txtIcon.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtIcon.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtIcon.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtIcon.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtIcon.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtIcon.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtIcon.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtIcon.ButtonSymbol = 61761;
            txtIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIcon.FillColor2 = System.Drawing.Color.White;
            txtIcon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIcon.Location = new System.Drawing.Point(129, 211);
            txtIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtIcon.Maximum = 2147483647D;
            txtIcon.MaxLength = 20;
            txtIcon.Minimum = -2147483648D;
            txtIcon.MinimumSize = new System.Drawing.Size(1, 16);
            txtIcon.Name = "txtIcon";
            txtIcon.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtIcon.Size = new System.Drawing.Size(215, 42);
            txtIcon.Style = Sunny.UI.UIStyle.White;
            txtIcon.StyleCustomMode = true;
            txtIcon.TabIndex = 7;
            txtIcon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel8.Location = new System.Drawing.Point(57, 218);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(65, 29);
            uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            uiLabel8.TabIndex = 54;
            uiLabel8.Text = "图标";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel5.Location = new System.Drawing.Point(401, 142);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(110, 29);
            uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            uiLabel5.TabIndex = 50;
            uiLabel5.Text = "类型";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSortCode
            // 
            txtSortCode.FillColor = System.Drawing.Color.White;
            txtSortCode.FillColor2 = System.Drawing.Color.White;
            txtSortCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSortCode.Location = new System.Drawing.Point(523, 214);
            txtSortCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSortCode.MinimumSize = new System.Drawing.Size(100, 0);
            txtSortCode.Name = "txtSortCode";
            txtSortCode.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtSortCode.Size = new System.Drawing.Size(222, 36);
            txtSortCode.Style = Sunny.UI.UIStyle.White;
            txtSortCode.StyleCustomMode = true;
            txtSortCode.TabIndex = 9;
            txtSortCode.Text = "txtSortCode";
            txtSortCode.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirm.FillColor = System.Drawing.Color.White;
            btnConfirm.FillColor2 = System.Drawing.Color.White;
            btnConfirm.FillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnConfirm.FillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnConfirm.FillSelectedColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnConfirm.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnConfirm.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnConfirm.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnConfirm.Location = new System.Drawing.Point(658, 423);
            btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnConfirm.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnConfirm.Size = new System.Drawing.Size(125, 44);
            btnConfirm.Style = Sunny.UI.UIStyle.White;
            btnConfirm.StyleCustomMode = true;
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "确定";
            btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel12.Location = new System.Drawing.Point(410, 218);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(107, 29);
            uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            uiLabel12.TabIndex = 45;
            uiLabel12.Text = "排序号";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            txtRemark.ButtonFillColor = System.Drawing.Color.White;
            txtRemark.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtRemark.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtRemark.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtRemark.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtRemark.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtRemark.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtRemark.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtRemark.ButtonSymbol = 61761;
            txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRemark.FillColor2 = System.Drawing.Color.White;
            txtRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRemark.Location = new System.Drawing.Point(129, 294);
            txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtRemark.Maximum = 2147483647D;
            txtRemark.MaxLength = 128;
            txtRemark.Minimum = -2147483648D;
            txtRemark.MinimumSize = new System.Drawing.Size(1, 16);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtRemark.Size = new System.Drawing.Size(616, 90);
            txtRemark.Style = Sunny.UI.UIStyle.White;
            txtRemark.StyleCustomMode = true;
            txtRemark.TabIndex = 10;
            txtRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtRemark.Watermark = "请输入内容 ";
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel7.Location = new System.Drawing.Point(12, 294);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(110, 29);
            uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            uiLabel7.TabIndex = 35;
            uiLabel7.Text = "备注";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(523, 66);
            txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtName.Maximum = 2147483647D;
            txtName.MaxLength = 20;
            txtName.Minimum = -2147483648D;
            txtName.MinimumSize = new System.Drawing.Size(1, 16);
            txtName.Name = "txtName";
            txtName.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtName.Size = new System.Drawing.Size(222, 42);
            txtName.Style = Sunny.UI.UIStyle.White;
            txtName.StyleCustomMode = true;
            txtName.TabIndex = 2;
            txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel2.Location = new System.Drawing.Point(452, 73);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(65, 29);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.TabIndex = 23;
            uiLabel2.Text = "名称";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel4.Location = new System.Drawing.Point(56, 142);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(65, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.TabIndex = 25;
            uiLabel4.Text = "父级";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEnCode
            // 
            txtEnCode.ButtonFillColor = System.Drawing.Color.White;
            txtEnCode.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtEnCode.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtEnCode.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtEnCode.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtEnCode.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtEnCode.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtEnCode.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtEnCode.ButtonSymbol = 61761;
            txtEnCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEnCode.FillColor2 = System.Drawing.Color.White;
            txtEnCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEnCode.Location = new System.Drawing.Point(129, 66);
            txtEnCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEnCode.Maximum = 2147483647D;
            txtEnCode.MaxLength = 20;
            txtEnCode.Minimum = -2147483648D;
            txtEnCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtEnCode.Name = "txtEnCode";
            txtEnCode.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtEnCode.Size = new System.Drawing.Size(265, 42);
            txtEnCode.Style = Sunny.UI.UIStyle.White;
            txtEnCode.StyleCustomMode = true;
            txtEnCode.TabIndex = 1;
            txtEnCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel1.Location = new System.Drawing.Point(57, 73);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(65, 29);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 21;
            uiLabel1.Text = "编码";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddPermissionForm
            // 
            AllowShowTitle = false;
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(795, 482);
            Controls.Add(uiPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPermissionForm";
            Padding = new System.Windows.Forms.Padding(0);
            RectColor = System.Drawing.Color.FromArgb(248, 248, 248);
            ShowTitle = false;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "新增用户";
            TitleColor = System.Drawing.Color.FromArgb(248, 248, 248);
            TitleForeColor = System.Drawing.Color.DimGray;
            TopMost = true;
            Load += AddPermissionForm_Load;
            uiPanel1.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel titlePanel;
        private Sunny.UI.UILabel lblTitle;
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
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtIcon;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UIComboBox txtType;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UISymbolButton btnSelectIcon;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
        private Sunny.UI.UISymbolLabel btnClose;
    }
}