namespace Elight.WinForm.Page.Report
{
    partial class ScrapReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel4 = new Sunny.UI.UILabel();
            dpTo = new Sunny.UI.UIDatePicker();
            dpFrom = new Sunny.UI.UIDatePicker();
            uiLabel3 = new Sunny.UI.UILabel();
            txtSN = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            btnQuery = new Sunny.UI.UISymbolButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            pagination = new Sunny.UI.UIPagination();
            dataGridView = new Sunny.UI.UIDataGridView();
            SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScrapCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(2033, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 806);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 806);
            panel3.TabIndex = 9;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(dpTo);
            uiPanel1.Controls.Add(dpFrom);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtSN);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(txtOrderId);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(btnQuery);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(30, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(2003, 60);
            uiPanel1.TabIndex = 11;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.Location = new System.Drawing.Point(265, 16);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(15, 29);
            uiLabel4.TabIndex = 14;
            uiLabel4.Text = "~";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpTo
            // 
            dpTo.FillColor = System.Drawing.Color.White;
            dpTo.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpTo.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpTo.Location = new System.Drawing.Point(287, 12);
            dpTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpTo.MaxLength = 10;
            dpTo.MinimumSize = new System.Drawing.Size(63, 0);
            dpTo.Name = "dpTo";
            dpTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpTo.Size = new System.Drawing.Size(188, 36);
            dpTo.SymbolDropDown = 61555;
            dpTo.SymbolNormal = 61555;
            dpTo.TabIndex = 13;
            dpTo.Text = "2024-10-03";
            dpTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpTo.Value = new System.DateTime(2024, 10, 3, 22, 27, 31, 432);
            // 
            // dpFrom
            // 
            dpFrom.FillColor = System.Drawing.Color.White;
            dpFrom.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpFrom.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpFrom.Location = new System.Drawing.Point(70, 12);
            dpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpFrom.MaxLength = 10;
            dpFrom.MinimumSize = new System.Drawing.Size(63, 0);
            dpFrom.Name = "dpFrom";
            dpFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpFrom.Size = new System.Drawing.Size(188, 36);
            dpFrom.SymbolDropDown = 61555;
            dpFrom.SymbolNormal = 61555;
            dpFrom.TabIndex = 12;
            dpFrom.Text = "2024-10-03";
            dpFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpFrom.Value = new System.DateTime(2024, 10, 3, 22, 27, 31, 432);
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel3.Location = new System.Drawing.Point(6, 16);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(57, 29);
            uiLabel3.TabIndex = 11;
            uiLabel3.Text = "日期";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSN
            // 
            txtSN.ButtonSymbol = 61761;
            txtSN.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtSN.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtSN.Location = new System.Drawing.Point(587, 12);
            txtSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSN.Maximum = 2147483647D;
            txtSN.Minimum = -2147483648D;
            txtSN.MinimumSize = new System.Drawing.Size(1, 16);
            txtSN.Name = "txtSN";
            txtSN.Size = new System.Drawing.Size(240, 36);
            txtSN.TabIndex = 10;
            txtSN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.Location = new System.Drawing.Point(505, 16);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(74, 29);
            uiLabel2.TabIndex = 9;
            uiLabel2.Text = "条码号";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOrderId.Location = new System.Drawing.Point(938, 12);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(240, 36);
            txtOrderId.TabIndex = 8;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(856, 16);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(74, 29);
            uiLabel1.TabIndex = 7;
            uiLabel1.Text = "工单号";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(1930, 8);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 6;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(pagination);
            uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel2.Location = new System.Drawing.Point(30, 760);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new System.Drawing.Size(2003, 46);
            uiPanel2.TabIndex = 12;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 6);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 30;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(2003, 40);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 13;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SN, ItemCode, OrderId, ScrapCode, Name1, IsScrap, UserId, CreateTime });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(30, 60);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(2003, 700);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 13;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // SN
            // 
            SN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            SN.DataPropertyName = "SN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            SN.DefaultCellStyle = dataGridViewCellStyle3;
            SN.HeaderText = "产品SN条码";
            SN.MinimumWidth = 6;
            SN.Name = "SN";
            SN.ReadOnly = true;
            SN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            SN.Width = 250;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "ItemCode";
            ItemCode.HeaderText = "物料编码";
            ItemCode.MinimumWidth = 6;
            ItemCode.Name = "ItemCode";
            ItemCode.ReadOnly = true;
            ItemCode.Width = 250;
            // 
            // OrderId
            // 
            OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrderId.DataPropertyName = "OrderId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrderId.DefaultCellStyle = dataGridViewCellStyle4;
            OrderId.HeaderText = "工单号";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrderId.Width = 200;
            // 
            // ScrapCode
            // 
            ScrapCode.DataPropertyName = "ScrapCode";
            ScrapCode.HeaderText = "报废代码";
            ScrapCode.MinimumWidth = 6;
            ScrapCode.Name = "ScrapCode";
            ScrapCode.ReadOnly = true;
            ScrapCode.Width = 150;
            // 
            // Name1
            // 
            Name1.DataPropertyName = "Name";
            Name1.HeaderText = "报废说明";
            Name1.MinimumWidth = 6;
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.Width = 200;
            // 
            // IsScrap
            // 
            IsScrap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            IsScrap.DataPropertyName = "IsScrap";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            IsScrap.DefaultCellStyle = dataGridViewCellStyle5;
            IsScrap.HeaderText = "操作类型";
            IsScrap.MinimumWidth = 6;
            IsScrap.Name = "IsScrap";
            IsScrap.ReadOnly = true;
            IsScrap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            IsScrap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            IsScrap.Width = 300;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "操作人员";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Width = 150;
            // 
            // CreateTime
            // 
            CreateTime.DataPropertyName = "CreateTime";
            CreateTime.HeaderText = "报废时间";
            CreateTime.MinimumWidth = 6;
            CreateTime.Name = "CreateTime";
            CreateTime.ReadOnly = true;
            CreateTime.Width = 200;
            // 
            // ScrapReport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2063, 806);
            Controls.Add(dataGridView);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "ScrapReport";
            Text = "ScrapReport";
            Load += ScrapReport_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDatePicker dpTo;
        private Sunny.UI.UIDatePicker dpFrom;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtSN;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}