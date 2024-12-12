namespace Elight.WinForm.Page.Sys.Organize
{
    partial class OrganizePage
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
            pagination = new Sunny.UI.UIPagination();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            dataGridView = new Sunny.UI.UIDataGridView();
            OrganizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel6 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            panel7 = new System.Windows.Forms.Panel();
            btnQuery = new Sunny.UI.UISymbolButton();
            txtKeywords = new Sunny.UI.UITextBox();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Top;
            pagination.FillColor = System.Drawing.Color.White;
            pagination.FillColor2 = System.Drawing.Color.White;
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 367);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 10;
            pagination.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.Size = new System.Drawing.Size(1284, 42);
            pagination.Style = Sunny.UI.UIStyle.White;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 11;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1344, 677);
            panel5.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(pagination);
            panel1.Controls.Add(dataGridView);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1284, 607);
            panel1.TabIndex = 12;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 32;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrganizeId, OrganizeEncode, OrganizeName, OrganizeType, OrganizeRemark, RoleSortCode });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(1284, 367);
            dataGridView.StripeOddColor = System.Drawing.Color.White;
            dataGridView.Style = Sunny.UI.UIStyle.White;
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 10;
            // 
            // OrganizeId
            // 
            OrganizeId.DataPropertyName = "Id";
            OrganizeId.HeaderText = "Id";
            OrganizeId.MinimumWidth = 6;
            OrganizeId.Name = "OrganizeId";
            OrganizeId.ReadOnly = true;
            OrganizeId.Visible = false;
            OrganizeId.Width = 125;
            // 
            // OrganizeEncode
            // 
            OrganizeEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeEncode.DataPropertyName = "Encode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.DefaultCellStyle = dataGridViewCellStyle3;
            OrganizeEncode.HeaderText = "编码";
            OrganizeEncode.MinimumWidth = 6;
            OrganizeEncode.Name = "OrganizeEncode";
            OrganizeEncode.ReadOnly = true;
            OrganizeEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeName
            // 
            OrganizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeName.DataPropertyName = "FullName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrganizeName.HeaderText = "名称";
            OrganizeName.MinimumWidth = 6;
            OrganizeName.Name = "OrganizeName";
            OrganizeName.ReadOnly = true;
            OrganizeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeType
            // 
            OrganizeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeType.DataPropertyName = "TypeStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.DefaultCellStyle = dataGridViewCellStyle5;
            OrganizeType.HeaderText = "类型";
            OrganizeType.MinimumWidth = 6;
            OrganizeType.Name = "OrganizeType";
            OrganizeType.ReadOnly = true;
            OrganizeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeRemark
            // 
            OrganizeRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrganizeRemark.DataPropertyName = "Remark";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.DefaultCellStyle = dataGridViewCellStyle6;
            OrganizeRemark.HeaderText = "备注";
            OrganizeRemark.MinimumWidth = 6;
            OrganizeRemark.Name = "OrganizeRemark";
            OrganizeRemark.ReadOnly = true;
            OrganizeRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleSortCode
            // 
            RoleSortCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleSortCode.DataPropertyName = "SortCode";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.DefaultCellStyle = dataGridViewCellStyle7;
            RoleSortCode.HeaderText = "排序码";
            RoleSortCode.MinimumWidth = 6;
            RoleSortCode.Name = "RoleSortCode";
            RoleSortCode.ReadOnly = true;
            RoleSortCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(panel7);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(30, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(1284, 70);
            panel6.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnModify);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1014, 70);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FillColor = System.Drawing.Color.White;
            btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAdd.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAdd.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAdd.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAdd.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAdd.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.Location = new System.Drawing.Point(10, 13);
            btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.Symbol = 61846;
            btnAdd.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAdd.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAdd.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.TabIndex = 0;
            btnAdd.Tag = "org-add";
            btnAdd.Text = "新增机构";
            btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModify.FillColor = System.Drawing.Color.White;
            btnModify.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnModify.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnModify.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnModify.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnModify.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnModify.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.Location = new System.Drawing.Point(145, 13);
            btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnModify.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Style = Sunny.UI.UIStyle.Custom;
            btnModify.Symbol = 61508;
            btnModify.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnModify.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnModify.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.TabIndex = 4;
            btnModify.Tag = "org-edit";
            btnModify.Text = "修改机构";
            btnModify.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnModify.Visible = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FillColor = System.Drawing.Color.White;
            btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnDelete.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnDelete.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnDelete.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.Location = new System.Drawing.Point(280, 13);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.TabIndex = 5;
            btnDelete.Tag = "org-delete";
            btnDelete.Text = "删除机构";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnQuery);
            panel7.Controls.Add(txtKeywords);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(1014, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(270, 70);
            panel7.TabIndex = 3;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(222, 13);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 3;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
            // 
            // txtKeywords
            // 
            txtKeywords.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtKeywords.ButtonFillColor = System.Drawing.Color.White;
            txtKeywords.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtKeywords.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtKeywords.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtKeywords.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtKeywords.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtKeywords.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtKeywords.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtKeywords.ButtonSymbol = 61761;
            txtKeywords.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtKeywords.FillColor2 = System.Drawing.Color.White;
            txtKeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtKeywords.Location = new System.Drawing.Point(11, 14);
            txtKeywords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKeywords.Maximum = 2147483647D;
            txtKeywords.Minimum = -2147483648D;
            txtKeywords.MinimumSize = new System.Drawing.Size(1, 16);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtKeywords.Size = new System.Drawing.Size(204, 42);
            txtKeywords.Style = Sunny.UI.UIStyle.White;
            txtKeywords.StyleCustomMode = true;
            txtKeywords.TabIndex = 0;
            txtKeywords.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtKeywords.Watermark = "机构名称或编码";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(1314, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 677);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 677);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1344, 677);
            panel2.TabIndex = 5;
            // 
            // OrganizePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(1344, 677);
            Controls.Add(panel2);
            Name = "OrganizePage";
            Style = Sunny.UI.UIStyle.Custom;
            StyleCustomMode = true;
            Symbol = 61869;
            Text = "组织机构";
            Initialize += OrganizePage_Initialize;
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel6.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPagination pagination;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private Sunny.UI.UITextBox txtKeywords;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolButton btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleSortCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
    }
}