namespace Elight.WinForm.Page.OrderManage
{
    partial class OrderInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel10 = new Sunny.UI.UILabel();
            dpProductDate = new Sunny.UI.UIDatePicker();
            cmbSpecial = new Sunny.UI.UIComboBox();
            txtInputQty = new Sunny.UI.UITextBox();
            uiLabel9 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            cmbProductType = new Sunny.UI.UIComboBox();
            btnCancel = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            uiLabel7 = new Sunny.UI.UILabel();
            cmbRule = new Sunny.UI.UIComboBox();
            uiLabel6 = new Sunny.UI.UILabel();
            txtCanQty = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            txtInputed = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtQty = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            dataGridView = new Sunny.UI.UIDataGridView();
            SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagination = new Sunny.UI.UIPagination();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            uiLabel12 = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel12);
            uiPanel1.Controls.Add(uiLabel10);
            uiPanel1.Controls.Add(dpProductDate);
            uiPanel1.Controls.Add(cmbSpecial);
            uiPanel1.Controls.Add(txtInputQty);
            uiPanel1.Controls.Add(uiLabel9);
            uiPanel1.Controls.Add(uiLabel8);
            uiPanel1.Controls.Add(cmbProductType);
            uiPanel1.Controls.Add(btnCancel);
            uiPanel1.Controls.Add(btnSave);
            uiPanel1.Controls.Add(uiLabel7);
            uiPanel1.Controls.Add(cmbRule);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(txtCanQty);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Controls.Add(txtInputed);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(txtQty);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel11);
            uiPanel1.Controls.Add(txtOrderId);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(0, 35);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1126, 276);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel10.Location = new System.Drawing.Point(679, 167);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new System.Drawing.Size(93, 29);
            uiLabel10.TabIndex = 87;
            uiLabel10.Text = "特殊代码";
            uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpProductDate
            // 
            dpProductDate.FillColor = System.Drawing.Color.White;
            dpProductDate.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpProductDate.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpProductDate.Location = new System.Drawing.Point(812, 109);
            dpProductDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpProductDate.MaxLength = 10;
            dpProductDate.MinimumSize = new System.Drawing.Size(63, 0);
            dpProductDate.Name = "dpProductDate";
            dpProductDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpProductDate.Size = new System.Drawing.Size(300, 36);
            dpProductDate.SymbolDropDown = 61555;
            dpProductDate.SymbolNormal = 61555;
            dpProductDate.TabIndex = 88;
            dpProductDate.Text = "2024-09-04";
            dpProductDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpProductDate.Value = new System.DateTime(2024, 9, 4, 1, 45, 53, 0);
            // 
            // cmbSpecial
            // 
            cmbSpecial.DataSource = null;
            cmbSpecial.FillColor = System.Drawing.Color.White;
            cmbSpecial.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbSpecial.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbSpecial.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbSpecial.Location = new System.Drawing.Point(812, 160);
            cmbSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbSpecial.MinimumSize = new System.Drawing.Size(63, 0);
            cmbSpecial.Name = "cmbSpecial";
            cmbSpecial.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbSpecial.Size = new System.Drawing.Size(300, 42);
            cmbSpecial.TabIndex = 86;
            cmbSpecial.Text = "uiComboBox1";
            cmbSpecial.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInputQty
            // 
            txtInputQty.ButtonSymbol = 61761;
            txtInputQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInputQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtInputQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtInputQty.HasMinimum = true;
            txtInputQty.Location = new System.Drawing.Point(137, 212);
            txtInputQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInputQty.Maximum = 2147483647D;
            txtInputQty.MaxLength = 50;
            txtInputQty.Minimum = 0D;
            txtInputQty.MinimumEnabled = true;
            txtInputQty.MinimumSize = new System.Drawing.Size(1, 16);
            txtInputQty.Name = "txtInputQty";
            txtInputQty.Size = new System.Drawing.Size(300, 42);
            txtInputQty.Style = Sunny.UI.UIStyle.Custom;
            txtInputQty.StyleCustomMode = true;
            txtInputQty.TabIndex = 86;
            txtInputQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel9.Location = new System.Drawing.Point(4, 219);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(93, 29);
            uiLabel9.TabIndex = 87;
            uiLabel9.Text = "批投数量(生码数量)";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel8.Location = new System.Drawing.Point(4, 167);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(93, 29);
            uiLabel8.TabIndex = 85;
            uiLabel8.Text = "生产类型";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProductType
            // 
            cmbProductType.DataSource = null;
            cmbProductType.FillColor = System.Drawing.Color.White;
            cmbProductType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbProductType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbProductType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbProductType.Location = new System.Drawing.Point(137, 160);
            cmbProductType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbProductType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbProductType.Size = new System.Drawing.Size(300, 42);
            cmbProductType.TabIndex = 84;
            cmbProductType.Text = "uiComboBox1";
            cmbProductType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnCancel.Location = new System.Drawing.Point(1009, 218);
            btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(103, 42);
            btnCancel.TabIndex = 83;
            btnCancel.Text = "取消";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSave.Location = new System.Drawing.Point(812, 218);
            btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(103, 42);
            btnSave.TabIndex = 82;
            btnSave.Text = "保存";
            btnSave.Click += btnSave_Click;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel7.Location = new System.Drawing.Point(4, 116);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(93, 29);
            uiLabel7.TabIndex = 81;
            uiLabel7.Text = "编码规则";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRule
            // 
            cmbRule.DataSource = null;
            cmbRule.FillColor = System.Drawing.Color.White;
            cmbRule.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbRule.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbRule.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbRule.Location = new System.Drawing.Point(137, 109);
            cmbRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbRule.MinimumSize = new System.Drawing.Size(63, 0);
            cmbRule.Name = "cmbRule";
            cmbRule.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbRule.Size = new System.Drawing.Size(300, 42);
            cmbRule.TabIndex = 80;
            cmbRule.Text = "uiComboBox1";
            cmbRule.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel6.Location = new System.Drawing.Point(679, 116);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(93, 29);
            uiLabel6.TabIndex = 79;
            uiLabel6.Text = "生产日期";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCanQty
            // 
            txtCanQty.ButtonSymbol = 61761;
            txtCanQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCanQty.Enabled = false;
            txtCanQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtCanQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtCanQty.Location = new System.Drawing.Point(812, 57);
            txtCanQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCanQty.Maximum = 2147483647D;
            txtCanQty.MaxLength = 50;
            txtCanQty.Minimum = -2147483648D;
            txtCanQty.MinimumSize = new System.Drawing.Size(1, 16);
            txtCanQty.Name = "txtCanQty";
            txtCanQty.Size = new System.Drawing.Size(300, 42);
            txtCanQty.Style = Sunny.UI.UIStyle.Custom;
            txtCanQty.StyleCustomMode = true;
            txtCanQty.TabIndex = 76;
            txtCanQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(679, 64);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 77;
            uiLabel5.Text = "可投数量";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputed
            // 
            txtInputed.ButtonSymbol = 61761;
            txtInputed.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInputed.Enabled = false;
            txtInputed.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtInputed.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtInputed.Location = new System.Drawing.Point(137, 57);
            txtInputed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInputed.Maximum = 2147483647D;
            txtInputed.MaxLength = 50;
            txtInputed.Minimum = -2147483648D;
            txtInputed.MinimumSize = new System.Drawing.Size(1, 16);
            txtInputed.Name = "txtInputed";
            txtInputed.Size = new System.Drawing.Size(300, 42);
            txtInputed.Style = Sunny.UI.UIStyle.Custom;
            txtInputed.StyleCustomMode = true;
            txtInputed.TabIndex = 74;
            txtInputed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.Location = new System.Drawing.Point(4, 64);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(93, 29);
            uiLabel4.TabIndex = 75;
            uiLabel4.Text = "已投数量";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.ForeColor = System.Drawing.Color.Red;
            uiLabel2.Location = new System.Drawing.Point(768, 12);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(21, 29);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.StyleCustomMode = true;
            uiLabel2.TabIndex = 73;
            uiLabel2.Text = "*";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQty
            // 
            txtQty.ButtonSymbol = 61761;
            txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQty.Enabled = false;
            txtQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtQty.Location = new System.Drawing.Point(812, 5);
            txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtQty.Maximum = 2147483647D;
            txtQty.MaxLength = 50;
            txtQty.Minimum = -2147483648D;
            txtQty.MinimumSize = new System.Drawing.Size(1, 16);
            txtQty.Name = "txtQty";
            txtQty.Size = new System.Drawing.Size(300, 42);
            txtQty.Style = Sunny.UI.UIStyle.Custom;
            txtQty.StyleCustomMode = true;
            txtQty.TabIndex = 71;
            txtQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(679, 12);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(93, 29);
            uiLabel3.TabIndex = 72;
            uiLabel3.Text = "工单数量";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel11.ForeColor = System.Drawing.Color.Red;
            uiLabel11.Location = new System.Drawing.Point(93, 12);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new System.Drawing.Size(21, 29);
            uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            uiLabel11.StyleCustomMode = true;
            uiLabel11.TabIndex = 70;
            uiLabel11.Text = "*";
            uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderId.Enabled = false;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOrderId.Location = new System.Drawing.Point(137, 5);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.MaxLength = 50;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(300, 42);
            txtOrderId.Style = Sunny.UI.UIStyle.Custom;
            txtOrderId.StyleCustomMode = true;
            txtOrderId.TabIndex = 68;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(4, 12);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 69;
            uiLabel1.Text = "工单号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 32;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SN, OrganizeEncode, OrderStatus });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(1124, 310);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 14;
            // 
            // SN
            // 
            SN.DataPropertyName = "SN";
            SN.FillWeight = 40F;
            SN.HeaderText = "产品序列号";
            SN.MinimumWidth = 6;
            SN.Name = "SN";
            SN.ReadOnly = true;
            SN.Width = 430;
            // 
            // OrganizeEncode
            // 
            OrganizeEncode.DataPropertyName = "ItemCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.DefaultCellStyle = dataGridViewCellStyle3;
            OrganizeEncode.FillWeight = 35F;
            OrganizeEncode.HeaderText = "物料编码";
            OrganizeEncode.MinimumWidth = 6;
            OrganizeEncode.Name = "OrganizeEncode";
            OrganizeEncode.ReadOnly = true;
            OrganizeEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeEncode.Width = 400;
            // 
            // OrderStatus
            // 
            OrderStatus.DataPropertyName = "SNStatus";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrderStatus.DefaultCellStyle = dataGridViewCellStyle4;
            OrderStatus.FillWeight = 25F;
            OrderStatus.HeaderText = "状态";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrderStatus.Width = 300;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Fill;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 0);
            pagination.Margin = new System.Windows.Forms.Padding(1);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 30;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.Size = new System.Drawing.Size(1126, 42);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 15;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            pagination.Click += pagination_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 311);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1126, 312);
            panel5.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(pagination);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 623);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1126, 42);
            panel1.TabIndex = 17;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel12.ForeColor = System.Drawing.Color.Red;
            uiLabel12.Location = new System.Drawing.Point(93, 219);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(21, 29);
            uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            uiLabel12.StyleCustomMode = true;
            uiLabel12.TabIndex = 89;
            uiLabel12.Text = "*";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderInput
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1126, 665);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderInput";
            Text = "工单生码";
            Load += OrderInput_Load;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtQty;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox cmbRule;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtCanQty;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtInputed;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox cmbProductType;
        private Sunny.UI.UITextBox txtInputQty;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIDatePicker dpProductDate;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox cmbSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel12;
    }
}