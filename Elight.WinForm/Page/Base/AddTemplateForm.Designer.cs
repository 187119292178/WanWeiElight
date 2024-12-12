namespace Elight.WinForm.Page.Base
{
    partial class AddTemplateForm
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
            txtItemName = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            btnQuery = new Sunny.UI.UIButton();
            uiLabel4 = new Sunny.UI.UILabel();
            txtItemCode = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            txtDesc = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtSNFile = new Sunny.UI.UITextBox();
            btnSN = new Sunny.UI.UIButton();
            uiLabel7 = new Sunny.UI.UILabel();
            txtSNQty = new Sunny.UI.UIIntegerUpDown();
            btnConfirm = new Sunny.UI.UIButton();
            btnExit = new Sunny.UI.UIButton();
            uiLabel10 = new Sunny.UI.UILabel();
            cmbType = new Sunny.UI.UIComboBox();
            uiButton2 = new Sunny.UI.UIButton();
            txtMatType = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.ButtonSymbol = 61761;
            txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemName.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemName.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemName.Location = new System.Drawing.Point(697, 46);
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
            txtItemName.TabIndex = 78;
            txtItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel6.Location = new System.Drawing.Point(570, 53);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(93, 29);
            uiLabel6.TabIndex = 79;
            uiLabel6.Text = "物料名称";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuery
            // 
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(439, 46);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 42);
            btnQuery.TabIndex = 77;
            btnQuery.Text = "...";
            btnQuery.Click += btnQuery_Click;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.ForeColor = System.Drawing.Color.Red;
            uiLabel4.Location = new System.Drawing.Point(98, 53);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(21, 29);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.StyleCustomMode = true;
            uiLabel4.TabIndex = 76;
            uiLabel4.Text = "*";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCode
            // 
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemCode.Location = new System.Drawing.Point(136, 46);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.MaxLength = 50;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new System.Drawing.Size(300, 42);
            txtItemCode.Style = Sunny.UI.UIStyle.Custom;
            txtItemCode.StyleCustomMode = true;
            txtItemCode.TabIndex = 74;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(9, 53);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 75;
            uiLabel5.Text = "物料编码";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesc
            // 
            txtDesc.ButtonSymbol = 61761;
            txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDesc.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtDesc.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtDesc.Location = new System.Drawing.Point(136, 152);
            txtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDesc.Maximum = 2147483647D;
            txtDesc.MaxLength = 50;
            txtDesc.Minimum = -2147483648D;
            txtDesc.MinimumSize = new System.Drawing.Size(1, 16);
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new System.Drawing.Size(861, 42);
            txtDesc.Style = Sunny.UI.UIStyle.Custom;
            txtDesc.StyleCustomMode = true;
            txtDesc.TabIndex = 80;
            txtDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(9, 159);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 81;
            uiLabel1.Text = "规格型号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.Location = new System.Drawing.Point(9, 210);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(93, 29);
            uiLabel2.TabIndex = 82;
            uiLabel2.Text = "模板文件";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSNFile
            // 
            txtSNFile.ButtonSymbol = 61761;
            txtSNFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSNFile.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSNFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSNFile.Location = new System.Drawing.Point(136, 203);
            txtSNFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSNFile.Maximum = 2147483647D;
            txtSNFile.MaxLength = 50;
            txtSNFile.Minimum = -2147483648D;
            txtSNFile.MinimumSize = new System.Drawing.Size(1, 16);
            txtSNFile.Name = "txtSNFile";
            txtSNFile.ReadOnly = true;
            txtSNFile.Size = new System.Drawing.Size(757, 42);
            txtSNFile.Style = Sunny.UI.UIStyle.Custom;
            txtSNFile.StyleCustomMode = true;
            txtSNFile.TabIndex = 81;
            txtSNFile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSN
            // 
            btnSN.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSN.Location = new System.Drawing.Point(900, 206);
            btnSN.MinimumSize = new System.Drawing.Size(1, 1);
            btnSN.Name = "btnSN";
            btnSN.Size = new System.Drawing.Size(97, 36);
            btnSN.TabIndex = 83;
            btnSN.Text = "选择文件";
            btnSN.Click += btnSN_Click;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel7.Location = new System.Drawing.Point(9, 269);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(129, 29);
            uiLabel7.TabIndex = 87;
            uiLabel7.Text = "模板打印份数";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSNQty
            // 
            txtSNQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSNQty.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSNQty.Location = new System.Drawing.Point(136, 265);
            txtSNQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSNQty.MinimumSize = new System.Drawing.Size(100, 0);
            txtSNQty.Name = "txtSNQty";
            txtSNQty.Size = new System.Drawing.Size(166, 36);
            txtSNQty.Style = Sunny.UI.UIStyle.Custom;
            txtSNQty.StyleCustomMode = true;
            txtSNQty.TabIndex = 88;
            txtSNQty.Text = "txtSortCode";
            txtSNQty.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            txtSNQty.Value = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnConfirm.Location = new System.Drawing.Point(657, 353);
            btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(125, 44);
            btnConfirm.StyleCustomMode = true;
            btnConfirm.TabIndex = 91;
            btnConfirm.Text = "确定";
            btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnExit.Location = new System.Drawing.Point(832, 353);
            btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(125, 44);
            btnExit.StyleCustomMode = true;
            btnExit.TabIndex = 92;
            btnExit.Text = "取消";
            btnExit.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnExit.Click += btnExit_Click;
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel10.Location = new System.Drawing.Point(9, 104);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new System.Drawing.Size(93, 29);
            uiLabel10.TabIndex = 94;
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
            cmbType.Location = new System.Drawing.Point(136, 98);
            cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbType.Size = new System.Drawing.Size(300, 42);
            cmbType.TabIndex = 93;
            cmbType.Text = "uiComboBox1";
            cmbType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            uiButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiButton2.Location = new System.Drawing.Point(768, 257);
            uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new System.Drawing.Size(125, 44);
            uiButton2.StyleCustomMode = true;
            uiButton2.TabIndex = 92;
            uiButton2.Text = "下载到本地";
            uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // txtMatType
            // 
            txtMatType.ButtonSymbol = 61761;
            txtMatType.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMatType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtMatType.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtMatType.Location = new System.Drawing.Point(697, 98);
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
            txtMatType.TabIndex = 95;
            txtMatType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(570, 105);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(93, 29);
            uiLabel3.TabIndex = 96;
            uiLabel3.Text = "物料类型";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddTemplateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1019, 422);
            Controls.Add(txtMatType);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel10);
            Controls.Add(cmbType);
            Controls.Add(uiButton2);
            Controls.Add(btnExit);
            Controls.Add(btnConfirm);
            Controls.Add(txtSNQty);
            Controls.Add(uiLabel7);
            Controls.Add(btnSN);
            Controls.Add(txtSNFile);
            Controls.Add(uiLabel2);
            Controls.Add(txtDesc);
            Controls.Add(uiLabel1);
            Controls.Add(txtItemName);
            Controls.Add(uiLabel6);
            Controls.Add(btnQuery);
            Controls.Add(uiLabel4);
            Controls.Add(txtItemCode);
            Controls.Add(uiLabel5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTemplateForm";
            Text = "AddTemplateForm";
            Load += AddTemplateForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtItemName;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btnQuery;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtItemCode;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtDesc;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtSNFile;
        private Sunny.UI.UIButton btnSN;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown txtSNQty;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIButton btnExit;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITextBox txtMatType;
        private Sunny.UI.UILabel uiLabel3;
    }
}