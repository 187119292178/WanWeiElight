namespace Elight.WinForm.Page.Report
{
    partial class OrderReportPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel4 = new Sunny.UI.UILabel();
            dpTo = new Sunny.UI.UIDatePicker();
            dpFrom = new Sunny.UI.UIDatePicker();
            uiLabel3 = new Sunny.UI.UILabel();
            txtItemCode = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            btnQuery = new Sunny.UI.UISymbolButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            pagination = new Sunny.UI.UIPagination();
            dataGridView = new Sunny.UI.UIDataGridView();
            OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScrapQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(2001, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 806);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 806);
            panel3.TabIndex = 7;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(dpTo);
            uiPanel1.Controls.Add(dpFrom);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtItemCode);
            uiPanel1.Controls.Add(uiLabel5);
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
            uiPanel1.Size = new System.Drawing.Size(1971, 60);
            uiPanel1.TabIndex = 9;
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
            // txtItemCode
            // 
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemCode.Location = new System.Drawing.Point(862, 15);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new System.Drawing.Size(173, 36);
            txtItemCode.TabIndex = 8;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel5.Location = new System.Drawing.Point(780, 19);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(74, 29);
            uiLabel5.TabIndex = 7;
            uiLabel5.Text = "物料编码";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOrderId.Location = new System.Drawing.Point(595, 15);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(173, 36);
            txtOrderId.TabIndex = 8;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(513, 19);
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
            btnQuery.Location = new System.Drawing.Point(1896, 9);
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
            uiPanel2.Location = new System.Drawing.Point(30, 765);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new System.Drawing.Size(1971, 41);
            uiPanel2.TabIndex = 10;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 1);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 10;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(1971, 40);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 12;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderId, ItemCode, OrganizeName, ProductType, Column3, OrganizeType, OrganizeRemark, RoleSortCode, CreatedQty, Column5, ScrapQty, Column1, Column2 });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(30, 60);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(1971, 705);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 15;
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "OrderId";
            OrderId.HeaderText = "工单号";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Width = 125;
            // 
            // ItemCode
            // 
            ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemCode.DataPropertyName = "ItemCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemCode.DefaultCellStyle = dataGridViewCellStyle3;
            ItemCode.HeaderText = "物料编码";
            ItemCode.MinimumWidth = 6;
            ItemCode.Name = "ItemCode";
            ItemCode.ReadOnly = true;
            ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeName
            // 
            OrganizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeName.DataPropertyName = "BasItemName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrganizeName.HeaderText = "物料名称";
            OrganizeName.MinimumWidth = 6;
            OrganizeName.Name = "OrganizeName";
            OrganizeName.ReadOnly = true;
            OrganizeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductType
            // 
            ProductType.DataPropertyName = "ProductType";
            ProductType.HeaderText = "产品类型";
            ProductType.MinimumWidth = 6;
            ProductType.Name = "ProductType";
            ProductType.ReadOnly = true;
            ProductType.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MatModel";
            Column3.HeaderText = "机型代码";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // OrganizeType
            // 
            OrganizeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeType.DataPropertyName = "BasItemDesc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.DefaultCellStyle = dataGridViewCellStyle5;
            OrganizeType.HeaderText = "规格型号";
            OrganizeType.MinimumWidth = 6;
            OrganizeType.Name = "OrganizeType";
            OrganizeType.ReadOnly = true;
            OrganizeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeRemark
            // 
            OrganizeRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeRemark.DataPropertyName = "TargetQty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.DefaultCellStyle = dataGridViewCellStyle6;
            OrganizeRemark.HeaderText = "订单数量";
            OrganizeRemark.MinimumWidth = 6;
            OrganizeRemark.Name = "OrganizeRemark";
            OrganizeRemark.ReadOnly = true;
            OrganizeRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleSortCode
            // 
            RoleSortCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleSortCode.DataPropertyName = "OrderStatus";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.DefaultCellStyle = dataGridViewCellStyle7;
            RoleSortCode.HeaderText = "工单状态";
            RoleSortCode.MinimumWidth = 6;
            RoleSortCode.Name = "RoleSortCode";
            RoleSortCode.ReadOnly = true;
            RoleSortCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedQty
            // 
            CreatedQty.DataPropertyName = "CreatedQty";
            CreatedQty.HeaderText = "生码数量";
            CreatedQty.MinimumWidth = 6;
            CreatedQty.Name = "CreatedQty";
            CreatedQty.ReadOnly = true;
            CreatedQty.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PackQty";
            Column5.HeaderText = "包装数量";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // ScrapQty
            // 
            ScrapQty.DataPropertyName = "ScrapQty";
            ScrapQty.HeaderText = "报废数量";
            ScrapQty.MinimumWidth = 6;
            ScrapQty.Name = "ScrapQty";
            ScrapQty.ReadOnly = true;
            ScrapQty.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ReleaseDate";
            Column1.HeaderText = "下达日期";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Remark";
            Column2.HeaderText = "备注";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // OrderReportPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2031, 806);
            Controls.Add(dataGridView);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "OrderReportPage";
            Text = "OrderReportPage";
            Load += OrderReportPage_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtSN;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDatePicker dpTo;
        private Sunny.UI.UIDatePicker dpFrom;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox TxtItemCode;
        private Sunny.UI.UITextBox txtItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleSortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }


}