namespace Elight.WinForm.Page.Sys.Permission
{
    partial class PermissionPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView = new Sunny.UI.UIDataGridView();
            PermissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Encode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Symbols = new System.Windows.Forms.DataGridViewImageColumn();
            Icons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PermissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pagination = new Sunny.UI.UIPagination();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PermissionId, Encode, Symbols, Icons, PermissionName, TypeName, SortCode, Remark, Column1 });
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(941, 0);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 10;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // PermissionId
            // 
            PermissionId.DataPropertyName = "Id";
            PermissionId.HeaderText = "Id";
            PermissionId.MinimumWidth = 6;
            PermissionId.Name = "PermissionId";
            PermissionId.ReadOnly = true;
            PermissionId.Visible = false;
            PermissionId.Width = 125;
            // 
            // Encode
            // 
            Encode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Encode.DataPropertyName = "EnCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Encode.DefaultCellStyle = dataGridViewCellStyle3;
            Encode.HeaderText = "编码";
            Encode.MinimumWidth = 6;
            Encode.Name = "Encode";
            Encode.ReadOnly = true;
            Encode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Encode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Symbols
            // 
            Symbols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Symbols.DefaultCellStyle = dataGridViewCellStyle4;
            Symbols.HeaderText = "图标";
            Symbols.MinimumWidth = 6;
            Symbols.Name = "Symbols";
            Symbols.ReadOnly = true;
            Symbols.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Symbols.Width = 57;
            // 
            // Icons
            // 
            Icons.DataPropertyName = "SymbolIndex";
            Icons.HeaderText = "IconHidden";
            Icons.MinimumWidth = 6;
            Icons.Name = "Icons";
            Icons.ReadOnly = true;
            Icons.Visible = false;
            Icons.Width = 125;
            // 
            // PermissionName
            // 
            PermissionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PermissionName.DataPropertyName = "Name";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            PermissionName.DefaultCellStyle = dataGridViewCellStyle5;
            PermissionName.HeaderText = "名称";
            PermissionName.MinimumWidth = 6;
            PermissionName.Name = "PermissionName";
            PermissionName.ReadOnly = true;
            PermissionName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            PermissionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeName
            // 
            TypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TypeName.DataPropertyName = "TypeName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TypeName.DefaultCellStyle = dataGridViewCellStyle6;
            TypeName.HeaderText = "类型";
            TypeName.MinimumWidth = 6;
            TypeName.Name = "TypeName";
            TypeName.ReadOnly = true;
            TypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SortCode
            // 
            SortCode.DataPropertyName = "SortCode";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            SortCode.DefaultCellStyle = dataGridViewCellStyle7;
            SortCode.HeaderText = "排序码";
            SortCode.MinimumWidth = 6;
            SortCode.Name = "SortCode";
            SortCode.ReadOnly = true;
            SortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            SortCode.Width = 125;
            // 
            // Remark
            // 
            Remark.DataPropertyName = "Remark";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Remark.DefaultCellStyle = dataGridViewCellStyle8;
            Remark.HeaderText = "备注";
            Remark.MinimumWidth = 6;
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Remark.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "StrDynamicPage";
            Column1.HeaderText = "动态页面";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1001, 21);
            panel2.TabIndex = 3;
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
            panel5.Size = new System.Drawing.Size(1001, 21);
            panel5.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(pagination);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(941, 0);
            panel1.TabIndex = 12;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, -42);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 30;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.Size = new System.Drawing.Size(941, 42);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 11;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(panel7);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(30, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(941, 70);
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
            flowLayoutPanel1.Size = new System.Drawing.Size(670, 70);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAdd.Location = new System.Drawing.Point(10, 13);
            btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Symbol = 61846;
            btnAdd.TabIndex = 0;
            btnAdd.Tag = "per-add";
            btnAdd.Text = "新增权限";
            btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnModify.Location = new System.Drawing.Point(145, 13);
            btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Symbol = 61508;
            btnModify.TabIndex = 4;
            btnModify.Tag = "per-edit";
            btnModify.Text = "修改权限";
            btnModify.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnModify.Visible = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnDelete.Location = new System.Drawing.Point(280, 13);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Symbol = 61460;
            btnDelete.TabIndex = 5;
            btnDelete.Tag = "per-delete";
            btnDelete.Text = "删除权限";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnQuery);
            panel7.Controls.Add(txtKeywords);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(670, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(271, 70);
            panel7.TabIndex = 3;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(225, 13);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 1;
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
            txtKeywords.Location = new System.Drawing.Point(18, 15);
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
            txtKeywords.Watermark = "权限名称或编码";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(971, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 21);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 21);
            panel3.TabIndex = 4;
            // 
            // PermissionPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            ClientSize = new System.Drawing.Size(1001, 21);
            Controls.Add(panel2);
            Name = "PermissionPage";
            StyleCustomMode = true;
            Symbol = 61682;
            Text = "权限管理";
            Initialize += UserPage_Initialize;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UITextBox txtKeywords;
        private Sunny.UI.UISymbolButton btnQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encode;
        private System.Windows.Forms.DataGridViewImageColumn Symbols;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icons;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}