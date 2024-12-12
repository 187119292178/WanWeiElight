namespace Elight.WinForm.Page.Base
{
    partial class AddBaseItemForm
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
            txtItemCode = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtItemName = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            txtDesc = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            uiLabel14 = new Sunny.UI.UILabel();
            txtOutput = new Sunny.UI.UITextBox();
            uiLabel15 = new Sunny.UI.UILabel();
            txtSource = new Sunny.UI.UITextBox();
            uiLabel16 = new Sunny.UI.UILabel();
            btnConfirm = new Sunny.UI.UIButton();
            cmbType = new Sunny.UI.UIComboBox();
            txtMatModel = new Sunny.UI.UITextBox();
            txtPackQty = new Sunny.UI.UIIntegerUpDown();
            txtPalletQty = new Sunny.UI.UIIntegerUpDown();
            SuspendLayout();
            // 
            // txtItemCode
            // 
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemCode.Location = new System.Drawing.Point(141, 41);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.MaxLength = 50;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new System.Drawing.Size(300, 42);
            txtItemCode.Style = Sunny.UI.UIStyle.Custom;
            txtItemCode.StyleCustomMode = true;
            txtItemCode.TabIndex = 22;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtItemCode.MouseLeave += txtItemCode_MouseLeave;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(14, 48);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 23;
            uiLabel1.Text = "物料编码";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel11.ForeColor = System.Drawing.Color.Red;
            uiLabel11.Location = new System.Drawing.Point(103, 48);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new System.Drawing.Size(21, 29);
            uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            uiLabel11.StyleCustomMode = true;
            uiLabel11.TabIndex = 58;
            uiLabel11.Text = "*";
            uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.ForeColor = System.Drawing.Color.Red;
            uiLabel2.Location = new System.Drawing.Point(632, 48);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(21, 29);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.StyleCustomMode = true;
            uiLabel2.TabIndex = 61;
            uiLabel2.Text = "*";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemName
            // 
            txtItemName.ButtonSymbol = 61761;
            txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemName.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemName.Location = new System.Drawing.Point(670, 41);
            txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemName.Maximum = 2147483647D;
            txtItemName.MaxLength = 50;
            txtItemName.Minimum = -2147483648D;
            txtItemName.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new System.Drawing.Size(300, 42);
            txtItemName.Style = Sunny.UI.UIStyle.Custom;
            txtItemName.StyleCustomMode = true;
            txtItemName.TabIndex = 59;
            txtItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(543, 48);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(93, 29);
            uiLabel3.TabIndex = 60;
            uiLabel3.Text = "物料名称";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.ForeColor = System.Drawing.Color.Red;
            uiLabel4.Location = new System.Drawing.Point(103, 108);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(21, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.StyleCustomMode = true;
            uiLabel4.TabIndex = 64;
            uiLabel4.Text = "*";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(14, 108);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 63;
            uiLabel5.Text = "物料类型";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesc
            // 
            txtDesc.ButtonSymbol = 61761;
            txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDesc.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtDesc.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtDesc.Location = new System.Drawing.Point(141, 147);
            txtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDesc.Maximum = 2147483647D;
            txtDesc.MaxLength = 50;
            txtDesc.Minimum = -2147483648D;
            txtDesc.MinimumSize = new System.Drawing.Size(1, 16);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(829, 42);
            txtDesc.Style = Sunny.UI.UIStyle.Custom;
            txtDesc.StyleCustomMode = true;
            txtDesc.TabIndex = 68;
            txtDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel7.Location = new System.Drawing.Point(543, 108);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(93, 29);
            uiLabel7.TabIndex = 66;
            uiLabel7.Text = "机型代码";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel8.ForeColor = System.Drawing.Color.Red;
            uiLabel8.Location = new System.Drawing.Point(103, 160);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(21, 29);
            uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            uiLabel8.StyleCustomMode = true;
            uiLabel8.TabIndex = 70;
            uiLabel8.Text = "*";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel9.Location = new System.Drawing.Point(14, 160);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(93, 29);
            uiLabel9.TabIndex = 69;
            uiLabel9.Text = "规格型号";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel12.Location = new System.Drawing.Point(543, 212);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(93, 29);
            uiLabel12.TabIndex = 75;
            uiLabel12.Text = "堆栈数量";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel13
            // 
            uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel13.ForeColor = System.Drawing.Color.Red;
            uiLabel13.Location = new System.Drawing.Point(103, 212);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new System.Drawing.Size(21, 29);
            uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            uiLabel13.StyleCustomMode = true;
            uiLabel13.TabIndex = 73;
            uiLabel13.Text = "*";
            uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel14
            // 
            uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel14.Location = new System.Drawing.Point(14, 212);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new System.Drawing.Size(93, 29);
            uiLabel14.TabIndex = 72;
            uiLabel14.Text = "包装数量";
            uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutput
            // 
            txtOutput.ButtonSymbol = 61761;
            txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOutput.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOutput.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOutput.Location = new System.Drawing.Point(141, 257);
            txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOutput.Maximum = 2147483647D;
            txtOutput.MaxLength = 50;
            txtOutput.Minimum = -2147483648D;
            txtOutput.MinimumSize = new System.Drawing.Size(1, 16);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new System.Drawing.Size(829, 42);
            txtOutput.Style = Sunny.UI.UIStyle.Custom;
            txtOutput.StyleCustomMode = true;
            txtOutput.TabIndex = 77;
            txtOutput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel15
            // 
            uiLabel15.Font = new System.Drawing.Font("Arial", 11F);
            uiLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            uiLabel15.Location = new System.Drawing.Point(14, 264);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new System.Drawing.Size(120, 29);
            uiLabel15.TabIndex = 78;
            uiLabel15.Text = "Output Desc";
            uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSource
            // 
            txtSource.ButtonSymbol = 61761;
            txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSource.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSource.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSource.Location = new System.Drawing.Point(141, 309);
            txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSource.Maximum = 2147483647D;
            txtSource.MaxLength = 50;
            txtSource.Minimum = -2147483648D;
            txtSource.MinimumSize = new System.Drawing.Size(1, 16);
            txtSource.Name = "txtSource";
            txtSource.Size = new System.Drawing.Size(829, 42);
            txtSource.Style = Sunny.UI.UIStyle.Custom;
            txtSource.StyleCustomMode = true;
            txtSource.TabIndex = 79;
            txtSource.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel16
            // 
            uiLabel16.Font = new System.Drawing.Font("Arial", 11F);
            uiLabel16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            uiLabel16.Location = new System.Drawing.Point(14, 316);
            uiLabel16.Name = "uiLabel16";
            uiLabel16.Size = new System.Drawing.Size(127, 29);
            uiLabel16.TabIndex = 80;
            uiLabel16.Text = "Source Desc";
            uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnConfirm.Location = new System.Drawing.Point(845, 392);
            btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(125, 44);
            btnConfirm.StyleCustomMode = true;
            btnConfirm.TabIndex = 81;
            btnConfirm.Text = "确定";
            btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cmbType
            // 
            cmbType.DataSource = null;
            cmbType.FillColor = System.Drawing.Color.White;
            cmbType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbType.Location = new System.Drawing.Point(141, 101);
            cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbType.Size = new System.Drawing.Size(300, 36);
            cmbType.TabIndex = 82;
            cmbType.Text = "uiComboBox1";
            cmbType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatModel
            // 
            txtMatModel.ButtonSymbol = 61761;
            txtMatModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMatModel.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtMatModel.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtMatModel.Location = new System.Drawing.Point(670, 95);
            txtMatModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMatModel.Maximum = 2147483647D;
            txtMatModel.MaxLength = 50;
            txtMatModel.Minimum = -2147483648D;
            txtMatModel.MinimumSize = new System.Drawing.Size(1, 16);
            txtMatModel.Name = "txtMatModel";
            txtMatModel.Size = new System.Drawing.Size(300, 42);
            txtMatModel.Style = Sunny.UI.UIStyle.Custom;
            txtMatModel.StyleCustomMode = true;
            txtMatModel.TabIndex = 75;
            txtMatModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPackQty
            // 
            txtPackQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtPackQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtPackQty.Location = new System.Drawing.Point(141, 205);
            txtPackQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPackQty.MinimumSize = new System.Drawing.Size(100, 0);
            txtPackQty.Name = "txtPackQty";
            txtPackQty.Size = new System.Drawing.Size(300, 36);
            txtPackQty.Style = Sunny.UI.UIStyle.Custom;
            txtPackQty.StyleCustomMode = true;
            txtPackQty.TabIndex = 83;
            txtPackQty.Text = "txtSortCode";
            txtPackQty.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPalletQty
            // 
            txtPalletQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtPalletQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtPalletQty.Location = new System.Drawing.Point(670, 205);
            txtPalletQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPalletQty.MinimumSize = new System.Drawing.Size(100, 0);
            txtPalletQty.Name = "txtPalletQty";
            txtPalletQty.Size = new System.Drawing.Size(300, 36);
            txtPalletQty.Style = Sunny.UI.UIStyle.Custom;
            txtPalletQty.StyleCustomMode = true;
            txtPalletQty.TabIndex = 84;
            txtPalletQty.Text = "txtSortCode";
            txtPalletQty.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBaseItemForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1029, 484);
            Controls.Add(txtPalletQty);
            Controls.Add(txtPackQty);
            Controls.Add(txtMatModel);
            Controls.Add(cmbType);
            Controls.Add(btnConfirm);
            Controls.Add(txtSource);
            Controls.Add(uiLabel16);
            Controls.Add(txtOutput);
            Controls.Add(uiLabel15);
            Controls.Add(uiLabel12);
            Controls.Add(uiLabel13);
            Controls.Add(uiLabel14);
            Controls.Add(uiLabel8);
            Controls.Add(uiLabel9);
            Controls.Add(txtDesc);
            Controls.Add(uiLabel7);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel5);
            Controls.Add(uiLabel2);
            Controls.Add(txtItemName);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel11);
            Controls.Add(txtItemCode);
            Controls.Add(uiLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBaseItemForm";
            Text = "新增物料";
            Load += AddBaseItemForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtItemCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtItemName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        //private Sunny.UI.UITextBox txtItemDesc;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtDesc;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UITextBox txtOutput;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UITextBox txtSource;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UITextBox txtMatModel;
        private Sunny.UI.UIIntegerUpDown txtPackQty;
        private Sunny.UI.UIIntegerUpDown txtPalletQty;
    }
}