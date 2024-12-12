namespace Elight.WinForm.Page.WIP
{
    partial class ScrapPage
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
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            uiPanel1 = new Sunny.UI.UIPanel();
            btnCancel = new Sunny.UI.UIButton();
            txtDesc = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            cmbItem = new Sunny.UI.UIComboBox();
            uiLabel4 = new Sunny.UI.UILabel();
            lblStatus = new System.Windows.Forms.Label();
            btnReset = new Sunny.UI.UIButton();
            txtInput = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtOperCode = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            txtUserId = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            lblMsg = new System.Windows.Forms.Label();
            dataGridView = new Sunny.UI.UIDataGridView();
            SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            料号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScrapDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            报废时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 673);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(1416, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 673);
            panel4.TabIndex = 11;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnCancel);
            uiPanel1.Controls.Add(txtDesc);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(cmbItem);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(lblStatus);
            uiPanel1.Controls.Add(btnReset);
            uiPanel1.Controls.Add(txtInput);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtOrderId);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(txtOperCode);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(txtUserId);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(30, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1386, 275);
            uiPanel1.TabIndex = 12;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(1185, 183);
            btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(138, 55);
            btnCancel.TabIndex = 91;
            btnCancel.Text = "取消报废";
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDesc
            // 
            txtDesc.ButtonSymbol = 61761;
            txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDesc.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtDesc.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtDesc.Location = new System.Drawing.Point(613, 71);
            txtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDesc.Maximum = 2147483647D;
            txtDesc.MaxLength = 50;
            txtDesc.Minimum = -2147483648D;
            txtDesc.MinimumSize = new System.Drawing.Size(1, 16);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(710, 75);
            txtDesc.Style = Sunny.UI.UIStyle.Custom;
            txtDesc.StyleCustomMode = true;
            txtDesc.TabIndex = 81;
            txtDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel6.Location = new System.Drawing.Point(513, 71);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(93, 29);
            uiLabel6.TabIndex = 90;
            uiLabel6.Text = "报废说明";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbItem
            // 
            cmbItem.DataSource = null;
            cmbItem.FillColor = System.Drawing.Color.White;
            cmbItem.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbItem.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbItem.Location = new System.Drawing.Point(139, 71);
            cmbItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbItem.MinimumSize = new System.Drawing.Size(63, 0);
            cmbItem.Name = "cmbItem";
            cmbItem.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbItem.Size = new System.Drawing.Size(233, 36);
            cmbItem.TabIndex = 89;
            cmbItem.Text = "uiComboBox1";
            cmbItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel4.Location = new System.Drawing.Point(39, 71);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(93, 29);
            uiLabel4.TabIndex = 88;
            uiLabel4.Text = "报废原因";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = System.Drawing.Color.Green;
            lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblStatus.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(751, 183);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(104, 55);
            lblStatus.TabIndex = 87;
            lblStatus.Text = "PASS";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            btnReset.Location = new System.Drawing.Point(924, 183);
            btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(138, 55);
            btnReset.TabIndex = 86;
            btnReset.Text = "重置扫描";
            btnReset.Click += btnReset_Click;
            // 
            // txtInput
            // 
            txtInput.ButtonFillColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.ButtonFillHoverColor = System.Drawing.Color.FromArgb(223, 174, 86);
            txtInput.ButtonFillPressColor = System.Drawing.Color.FromArgb(192, 137, 43);
            txtInput.ButtonRectColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.ButtonRectHoverColor = System.Drawing.Color.FromArgb(223, 174, 86);
            txtInput.ButtonRectPressColor = System.Drawing.Color.FromArgb(192, 137, 43);
            txtInput.ButtonSymbol = 61761;
            txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInput.FillColor2 = System.Drawing.Color.FromArgb(251, 245, 233);
            txtInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            txtInput.Location = new System.Drawing.Point(198, 183);
            txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInput.Maximum = 2147483647D;
            txtInput.MaxLength = 50;
            txtInput.Minimum = -2147483648D;
            txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            txtInput.Name = "txtInput";
            txtInput.RectColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.Size = new System.Drawing.Size(529, 55);
            txtInput.Style = Sunny.UI.UIStyle.Orange;
            txtInput.StyleCustomMode = true;
            txtInput.TabIndex = 1;
            txtInput.Text = "12RYTRH234RTGYH67";
            txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            uiLabel3.Location = new System.Drawing.Point(33, 191);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(132, 39);
            uiLabel3.TabIndex = 84;
            uiLabel3.Text = "扫描条码";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderId.Enabled = false;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOrderId.Location = new System.Drawing.Point(1090, 5);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.MaxLength = 50;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(233, 36);
            txtOrderId.Style = Sunny.UI.UIStyle.Custom;
            txtOrderId.StyleCustomMode = true;
            txtOrderId.TabIndex = 82;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel2.Location = new System.Drawing.Point(990, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(93, 29);
            uiLabel2.TabIndex = 83;
            uiLabel2.Text = "工单号";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperCode
            // 
            txtOperCode.ButtonSymbol = 61761;
            txtOperCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOperCode.Enabled = false;
            txtOperCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOperCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOperCode.Location = new System.Drawing.Point(613, 5);
            txtOperCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOperCode.Maximum = 2147483647D;
            txtOperCode.MaxLength = 50;
            txtOperCode.Minimum = -2147483648D;
            txtOperCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtOperCode.Name = "txtOperCode";
            txtOperCode.Size = new System.Drawing.Size(233, 36);
            txtOperCode.Style = Sunny.UI.UIStyle.Custom;
            txtOperCode.StyleCustomMode = true;
            txtOperCode.TabIndex = 80;
            txtOperCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel1.Location = new System.Drawing.Point(513, 9);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 81;
            uiLabel1.Text = "当前工站";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserId
            // 
            txtUserId.ButtonSymbol = 61761;
            txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUserId.Enabled = false;
            txtUserId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtUserId.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtUserId.Location = new System.Drawing.Point(139, 5);
            txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUserId.Maximum = 2147483647D;
            txtUserId.MaxLength = 50;
            txtUserId.Minimum = -2147483648D;
            txtUserId.MinimumSize = new System.Drawing.Size(1, 16);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(233, 36);
            txtUserId.Style = Sunny.UI.UIStyle.Custom;
            txtUserId.StyleCustomMode = true;
            txtUserId.TabIndex = 78;
            txtUserId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel5.Location = new System.Drawing.Point(39, 9);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 79;
            uiLabel5.Text = "操作人员";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = System.Drawing.Color.LightSkyBlue;
            lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            lblMsg.Font = new System.Drawing.Font("微软雅黑", 14F);
            lblMsg.Location = new System.Drawing.Point(30, 275);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new System.Drawing.Size(1386, 70);
            lblMsg.TabIndex = 13;
            lblMsg.Text = "操作提示信息";
            lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SN, OrderId, 料号, ScrapDesc, UserId, 报废时间 });
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
            dataGridView.Location = new System.Drawing.Point(30, 345);
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
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(1386, 328);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 17;
            // 
            // SN
            // 
            SN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            SN.DataPropertyName = "SN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            SN.DefaultCellStyle = dataGridViewCellStyle3;
            SN.HeaderText = "产品条码";
            SN.MinimumWidth = 6;
            SN.Name = "SN";
            SN.ReadOnly = true;
            SN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderId
            // 
            OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrderId.DataPropertyName = "OrderId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrderId.DefaultCellStyle = dataGridViewCellStyle4;
            OrderId.HeaderText = "工单号";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 料号
            // 
            料号.DataPropertyName = "ItemCode";
            料号.HeaderText = "料号";
            料号.MinimumWidth = 6;
            料号.Name = "料号";
            料号.ReadOnly = true;
            料号.Width = 250;
            // 
            // ScrapDesc
            // 
            ScrapDesc.DataPropertyName = "ScrapDesc";
            ScrapDesc.HeaderText = "报废原因";
            ScrapDesc.MinimumWidth = 6;
            ScrapDesc.Name = "ScrapDesc";
            ScrapDesc.ReadOnly = true;
            ScrapDesc.Width = 250;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "报废人员";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Width = 200;
            // 
            // 报废时间
            // 
            报废时间.DataPropertyName = "CreateTime";
            报废时间.HeaderText = "报废时间";
            报废时间.MinimumWidth = 6;
            报废时间.Name = "报废时间";
            报废时间.ReadOnly = true;
            报废时间.Width = 300;
            // 
            // ScrapPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1446, 673);
            Controls.Add(dataGridView);
            Controls.Add(lblMsg);
            Controls.Add(uiPanel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "ScrapPage";
            Text = "ScrapPage";
            Load += ScrapPage_Load;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Label lblStatus;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtOperCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtUserId;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtDesc;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cmbItem;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnCancel;
        private System.Windows.Forms.Label lblMsg;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn 料号;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报废时间;
    }
}