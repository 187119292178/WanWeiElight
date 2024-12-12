namespace Elight.WinForm.Page.WIP
{
    partial class RePrintPacking
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
            dataGridView = new Sunny.UI.UIDataGridView();
            SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CartonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1 = new Sunny.UI.UIPanel();
            txtSW = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtSN = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SN, CartonNo, OrganizeEncode, Order });
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
            dataGridView.Location = new System.Drawing.Point(0, 131);
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
            dataGridView.Size = new System.Drawing.Size(1253, 343);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 16;
            // 
            // SN
            // 
            SN.DataPropertyName = "SN";
            SN.FillWeight = 30F;
            SN.HeaderText = "产品序列号";
            SN.MinimumWidth = 6;
            SN.Name = "SN";
            SN.ReadOnly = true;
            SN.Width = 400;
            // 
            // CartonNo
            // 
            CartonNo.DataPropertyName = "CartonNo";
            CartonNo.HeaderText = "外箱号";
            CartonNo.MinimumWidth = 6;
            CartonNo.Name = "CartonNo";
            CartonNo.ReadOnly = true;
            CartonNo.Width = 200;
            // 
            // OrganizeEncode
            // 
            OrganizeEncode.DataPropertyName = "ItemCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.DefaultCellStyle = dataGridViewCellStyle3;
            OrganizeEncode.FillWeight = 30F;
            OrganizeEncode.HeaderText = "物料编码";
            OrganizeEncode.MinimumWidth = 6;
            OrganizeEncode.Name = "OrganizeEncode";
            OrganizeEncode.ReadOnly = true;
            OrganizeEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeEncode.Width = 400;
            // 
            // Order
            // 
            Order.DataPropertyName = "OrderId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Order.DefaultCellStyle = dataGridViewCellStyle4;
            Order.FillWeight = 25F;
            Order.HeaderText = "工单号";
            Order.MinimumWidth = 6;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Order.Width = 330;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(txtSW);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(txtSN);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(0, 35);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1253, 96);
            uiPanel1.TabIndex = 15;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSW
            // 
            txtSW.ButtonSymbol = 61761;
            txtSW.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSW.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSW.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSW.Location = new System.Drawing.Point(962, 21);
            txtSW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSW.Maximum = 2147483647D;
            txtSW.MaxLength = 50;
            txtSW.Minimum = -2147483648D;
            txtSW.MinimumSize = new System.Drawing.Size(1, 16);
            txtSW.Name = "txtSW";
            txtSW.Size = new System.Drawing.Size(217, 42);
            txtSW.Style = Sunny.UI.UIStyle.Custom;
            txtSW.StyleCustomMode = true;
            txtSW.TabIndex = 69;
            txtSW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtSW.KeyDown += txtSW_KeyDown;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.Location = new System.Drawing.Point(858, 28);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(93, 29);
            uiLabel2.TabIndex = 70;
            uiLabel2.Text = "SW版号";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSN
            // 
            txtSN.ButtonSymbol = 61761;
            txtSN.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSN.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSN.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSN.Location = new System.Drawing.Point(127, 21);
            txtSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSN.Maximum = 2147483647D;
            txtSN.MaxLength = 50;
            txtSN.Minimum = -2147483648D;
            txtSN.MinimumSize = new System.Drawing.Size(1, 16);
            txtSN.Name = "txtSN";
            txtSN.Size = new System.Drawing.Size(534, 42);
            txtSN.Style = Sunny.UI.UIStyle.Custom;
            txtSN.StyleCustomMode = true;
            txtSN.TabIndex = 68;
            txtSN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtSN.KeyDown += txtSN_KeyDown;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(9, 28);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 69;
            uiLabel1.Text = "SN/箱号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RePrintPacking
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1253, 474);
            Controls.Add(dataGridView);
            Controls.Add(uiPanel1);
            Name = "RePrintPacking";
            Text = "补打外箱标签";
            Load += RePrintPacking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtSN;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtSW;
        private Sunny.UI.UILabel uiLabel2;
    }
}