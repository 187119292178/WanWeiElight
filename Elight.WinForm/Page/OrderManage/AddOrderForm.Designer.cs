namespace Elight.WinForm.Page.OrderManage
{
    partial class AddOrderForm
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
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            txtItemCode = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            btnQuery = new Sunny.UI.UIButton();
            txtItemName = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            txtItemDesc = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            txtRemark = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            dpReleaseDate = new Sunny.UI.UIDatePicker();
            uiLabel10 = new Sunny.UI.UILabel();
            cmbType = new Sunny.UI.UIComboBox();
            txtMatType = new Sunny.UI.UITextBox();
            uiLabel12 = new Sunny.UI.UILabel();
            dpFinshDate = new Sunny.UI.UIDatePicker();
            uiLabel13 = new Sunny.UI.UILabel();
            btnCancel = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            txtQty = new Sunny.UI.UIIntegerUpDown();
            uiLabel14 = new Sunny.UI.UILabel();
            uiLabel15 = new Sunny.UI.UILabel();
            uiLabel16 = new Sunny.UI.UILabel();
            uiLabel17 = new Sunny.UI.UILabel();
            cmbOrderType = new Sunny.UI.UIComboBox();
            txtCreateQty = new Sunny.UI.UITextBox();
            uiLabel18 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.ForeColor = System.Drawing.Color.Red;
            uiLabel2.Location = new System.Drawing.Point(630, 49);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(21, 29);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.StyleCustomMode = true;
            uiLabel2.TabIndex = 67;
            uiLabel2.Text = "*";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(541, 49);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(93, 29);
            uiLabel3.TabIndex = 66;
            uiLabel3.Text = "工单数量";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel11.ForeColor = System.Drawing.Color.Red;
            uiLabel11.Location = new System.Drawing.Point(101, 49);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new System.Drawing.Size(21, 29);
            uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            uiLabel11.StyleCustomMode = true;
            uiLabel11.TabIndex = 64;
            uiLabel11.Text = "*";
            uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOrderId.Location = new System.Drawing.Point(139, 42);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.MaxLength = 50;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(300, 42);
            txtOrderId.Style = Sunny.UI.UIStyle.Custom;
            txtOrderId.StyleCustomMode = true;
            txtOrderId.TabIndex = 62;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(12, 49);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 63;
            uiLabel1.Text = "工单号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.ForeColor = System.Drawing.Color.Red;
            uiLabel4.Location = new System.Drawing.Point(101, 149);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(21, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.StyleCustomMode = true;
            uiLabel4.TabIndex = 70;
            uiLabel4.Text = "*";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCode
            // 
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemCode.Enabled = false;
            txtItemCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemCode.Location = new System.Drawing.Point(139, 142);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.MaxLength = 50;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new System.Drawing.Size(300, 42);
            txtItemCode.Style = Sunny.UI.UIStyle.Custom;
            txtItemCode.StyleCustomMode = true;
            txtItemCode.TabIndex = 68;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(12, 149);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 69;
            uiLabel5.Text = "物料编码";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuery
            // 
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(442, 142);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 42);
            btnQuery.TabIndex = 71;
            btnQuery.Text = "...";
            btnQuery.Click += btnQuery_Click;
            // 
            // txtItemName
            // 
            txtItemName.ButtonSymbol = 61761;
            txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemName.Enabled = false;
            txtItemName.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemName.Location = new System.Drawing.Point(668, 142);
            txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemName.Maximum = 2147483647D;
            txtItemName.MaxLength = 50;
            txtItemName.Minimum = -2147483648D;
            txtItemName.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            txtItemName.Size = new System.Drawing.Size(300, 42);
            txtItemName.Style = Sunny.UI.UIStyle.Custom;
            txtItemName.StyleCustomMode = true;
            txtItemName.TabIndex = 72;
            txtItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel6.Location = new System.Drawing.Point(541, 149);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(93, 29);
            uiLabel6.TabIndex = 73;
            uiLabel6.Text = "物料名称";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemDesc
            // 
            txtItemDesc.ButtonSymbol = 61761;
            txtItemDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemDesc.Enabled = false;
            txtItemDesc.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemDesc.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemDesc.Location = new System.Drawing.Point(139, 246);
            txtItemDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemDesc.Maximum = 2147483647D;
            txtItemDesc.MaxLength = 50;
            txtItemDesc.Minimum = -2147483648D;
            txtItemDesc.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemDesc.Name = "txtItemDesc";
            txtItemDesc.ReadOnly = true;
            txtItemDesc.Size = new System.Drawing.Size(829, 42);
            txtItemDesc.Style = Sunny.UI.UIStyle.Custom;
            txtItemDesc.StyleCustomMode = true;
            txtItemDesc.TabIndex = 74;
            txtItemDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel7.Location = new System.Drawing.Point(12, 253);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(93, 29);
            uiLabel7.TabIndex = 75;
            uiLabel7.Text = "规格型号";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            txtRemark.ButtonSymbol = 61761;
            txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRemark.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtRemark.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtRemark.Location = new System.Drawing.Point(139, 349);
            txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtRemark.Maximum = 2147483647D;
            txtRemark.MaxLength = 50;
            txtRemark.Minimum = -2147483648D;
            txtRemark.MinimumSize = new System.Drawing.Size(1, 16);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new System.Drawing.Size(829, 42);
            txtRemark.Style = Sunny.UI.UIStyle.Custom;
            txtRemark.StyleCustomMode = true;
            txtRemark.TabIndex = 76;
            txtRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel8.Location = new System.Drawing.Point(12, 356);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(93, 29);
            uiLabel8.TabIndex = 77;
            uiLabel8.Text = "备注";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel9.Location = new System.Drawing.Point(12, 302);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(93, 29);
            uiLabel9.TabIndex = 79;
            uiLabel9.Text = "下达日期";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpReleaseDate
            // 
            dpReleaseDate.FillColor = System.Drawing.Color.White;
            dpReleaseDate.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpReleaseDate.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpReleaseDate.Location = new System.Drawing.Point(139, 298);
            dpReleaseDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpReleaseDate.MaxLength = 10;
            dpReleaseDate.MinimumSize = new System.Drawing.Size(63, 0);
            dpReleaseDate.Name = "dpReleaseDate";
            dpReleaseDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpReleaseDate.Size = new System.Drawing.Size(300, 36);
            dpReleaseDate.SymbolDropDown = 61555;
            dpReleaseDate.SymbolNormal = 61555;
            dpReleaseDate.TabIndex = 80;
            dpReleaseDate.Text = "2024-09-04";
            dpReleaseDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpReleaseDate.Value = new System.DateTime(2024, 9, 4, 1, 45, 53, 0);
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel10.Location = new System.Drawing.Point(535, 100);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new System.Drawing.Size(93, 29);
            uiLabel10.TabIndex = 83;
            uiLabel10.Text = "生产类型";
            uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbType
            // 
            cmbType.DataSource = null;
            cmbType.FillColor = System.Drawing.Color.White;
            cmbType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbType.Location = new System.Drawing.Point(668, 93);
            cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbType.Size = new System.Drawing.Size(294, 42);
            cmbType.TabIndex = 82;
            cmbType.Text = "uiComboBox1";
            cmbType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatType
            // 
            txtMatType.ButtonSymbol = 61761;
            txtMatType.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMatType.Enabled = false;
            txtMatType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtMatType.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtMatType.Location = new System.Drawing.Point(139, 194);
            txtMatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMatType.Maximum = 2147483647D;
            txtMatType.MaxLength = 50;
            txtMatType.Minimum = -2147483648D;
            txtMatType.MinimumSize = new System.Drawing.Size(1, 16);
            txtMatType.Name = "txtMatType";
            txtMatType.ReadOnly = true;
            txtMatType.Size = new System.Drawing.Size(300, 42);
            txtMatType.Style = Sunny.UI.UIStyle.Custom;
            txtMatType.StyleCustomMode = true;
            txtMatType.TabIndex = 84;
            txtMatType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel12.Location = new System.Drawing.Point(12, 201);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(93, 29);
            uiLabel12.TabIndex = 85;
            uiLabel12.Text = "物料类型";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpFinshDate
            // 
            dpFinshDate.FillColor = System.Drawing.Color.White;
            dpFinshDate.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpFinshDate.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpFinshDate.Location = new System.Drawing.Point(668, 298);
            dpFinshDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpFinshDate.MaxLength = 10;
            dpFinshDate.MinimumSize = new System.Drawing.Size(63, 0);
            dpFinshDate.Name = "dpFinshDate";
            dpFinshDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpFinshDate.Size = new System.Drawing.Size(300, 36);
            dpFinshDate.SymbolDropDown = 61555;
            dpFinshDate.SymbolNormal = 61555;
            dpFinshDate.TabIndex = 87;
            dpFinshDate.Text = "2024-09-04";
            dpFinshDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpFinshDate.Value = new System.DateTime(2024, 9, 4, 1, 45, 53, 0);
            // 
            // uiLabel13
            // 
            uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel13.Location = new System.Drawing.Point(516, 302);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new System.Drawing.Size(145, 29);
            uiLabel13.TabIndex = 86;
            uiLabel13.Text = "计划完成日期";
            uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnCancel.Location = new System.Drawing.Point(865, 419);
            btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(103, 42);
            btnCancel.TabIndex = 89;
            btnCancel.Text = "取消";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSave.Location = new System.Drawing.Point(668, 419);
            btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(103, 42);
            btnSave.TabIndex = 88;
            btnSave.Text = "保存";
            btnSave.Click += btnSave_Click;
            // 
            // txtQty
            // 
            txtQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtQty.Location = new System.Drawing.Point(668, 48);
            txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtQty.Minimum = 0;
            txtQty.MinimumSize = new System.Drawing.Size(100, 0);
            txtQty.Name = "txtQty";
            txtQty.Size = new System.Drawing.Size(300, 36);
            txtQty.Style = Sunny.UI.UIStyle.Custom;
            txtQty.StyleCustomMode = true;
            txtQty.TabIndex = 90;
            txtQty.Text = "txtQty";
            txtQty.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel14
            // 
            uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel14.ForeColor = System.Drawing.Color.Red;
            uiLabel14.Location = new System.Drawing.Point(624, 100);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new System.Drawing.Size(21, 29);
            uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            uiLabel14.StyleCustomMode = true;
            uiLabel14.TabIndex = 91;
            uiLabel14.Text = "*";
            uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel15
            // 
            uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel15.ForeColor = System.Drawing.Color.Red;
            uiLabel15.Location = new System.Drawing.Point(101, 302);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new System.Drawing.Size(21, 29);
            uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            uiLabel15.StyleCustomMode = true;
            uiLabel15.TabIndex = 92;
            uiLabel15.Text = "*";
            uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel16
            // 
            uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel16.ForeColor = System.Drawing.Color.Red;
            uiLabel16.Location = new System.Drawing.Point(642, 302);
            uiLabel16.Name = "uiLabel16";
            uiLabel16.Size = new System.Drawing.Size(21, 29);
            uiLabel16.Style = Sunny.UI.UIStyle.Custom;
            uiLabel16.StyleCustomMode = true;
            uiLabel16.TabIndex = 93;
            uiLabel16.Text = "*";
            uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel17
            // 
            uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel17.Location = new System.Drawing.Point(6, 100);
            uiLabel17.Name = "uiLabel17";
            uiLabel17.Size = new System.Drawing.Size(93, 29);
            uiLabel17.TabIndex = 95;
            uiLabel17.Text = "工单类型";
            uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOrderType
            // 
            cmbOrderType.DataSource = null;
            cmbOrderType.FillColor = System.Drawing.Color.White;
            cmbOrderType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbOrderType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbOrderType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbOrderType.Location = new System.Drawing.Point(139, 93);
            cmbOrderType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbOrderType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbOrderType.Size = new System.Drawing.Size(300, 42);
            cmbOrderType.TabIndex = 94;
            cmbOrderType.Text = "uiComboBox1";
            cmbOrderType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreateQty
            // 
            txtCreateQty.ButtonSymbol = 61761;
            txtCreateQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCreateQty.Enabled = false;
            txtCreateQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtCreateQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtCreateQty.Location = new System.Drawing.Point(668, 194);
            txtCreateQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCreateQty.Maximum = 2147483647D;
            txtCreateQty.MaxLength = 50;
            txtCreateQty.Minimum = -2147483648D;
            txtCreateQty.MinimumSize = new System.Drawing.Size(1, 16);
            txtCreateQty.Name = "txtCreateQty";
            txtCreateQty.ReadOnly = true;
            txtCreateQty.Size = new System.Drawing.Size(300, 42);
            txtCreateQty.Style = Sunny.UI.UIStyle.Custom;
            txtCreateQty.StyleCustomMode = true;
            txtCreateQty.TabIndex = 96;
            txtCreateQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel18
            // 
            uiLabel18.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel18.Location = new System.Drawing.Point(516, 201);
            uiLabel18.Name = "uiLabel18";
            uiLabel18.Size = new System.Drawing.Size(118, 29);
            uiLabel18.TabIndex = 97;
            uiLabel18.Text = "已生码数量";
            uiLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1004, 504);
            Controls.Add(txtCreateQty);
            Controls.Add(uiLabel18);
            Controls.Add(uiLabel17);
            Controls.Add(cmbOrderType);
            Controls.Add(uiLabel16);
            Controls.Add(uiLabel15);
            Controls.Add(uiLabel14);
            Controls.Add(txtQty);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dpFinshDate);
            Controls.Add(uiLabel13);
            Controls.Add(txtMatType);
            Controls.Add(uiLabel12);
            Controls.Add(uiLabel10);
            Controls.Add(cmbType);
            Controls.Add(dpReleaseDate);
            Controls.Add(uiLabel9);
            Controls.Add(txtRemark);
            Controls.Add(uiLabel8);
            Controls.Add(txtItemDesc);
            Controls.Add(uiLabel7);
            Controls.Add(txtItemName);
            Controls.Add(uiLabel6);
            Controls.Add(btnQuery);
            Controls.Add(uiLabel4);
            Controls.Add(txtItemCode);
            Controls.Add(uiLabel5);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel11);
            Controls.Add(txtOrderId);
            Controls.Add(uiLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOrderForm";
            Text = "新增订单";
            Load += AddOrderForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtItemCode;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btnQuery;
        private Sunny.UI.UITextBox txtItemName;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtItemDesc;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtRemark;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIDatePicker dpReleaseDate;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UITextBox txtModel;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIDatePicker dpFinshDate;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIIntegerUpDown txtQty;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UITextBox txtMatType;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UIComboBox cmbOrderType;
        private Sunny.UI.UITextBox txtPackQty;
        private Sunny.UI.UILabel uiLabel18;
        private Sunny.UI.UITextBox txtCreateQty;
    }
}