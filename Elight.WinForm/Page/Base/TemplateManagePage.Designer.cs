namespace Elight.WinForm.Page.Base
{
    partial class TemplateManagePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnExport = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            panel5 = new System.Windows.Forms.Panel();
            btnQuery = new Sunny.UI.UISymbolButton();
            txtKeywords = new Sunny.UI.UITextBox();
            dataGridView = new Sunny.UI.UIDataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TemplateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TemplateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TemplateURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagination = new Sunny.UI.UIPagination();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(2089, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 915);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 915);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnModify);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(30, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(2059, 69);
            panel2.TabIndex = 9;
            // 
            // btnExport
            // 
            btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnExport.Location = new System.Drawing.Point(490, 13);
            btnExport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(125, 44);
            btnExport.Symbol = 61508;
            btnExport.TabIndex = 12;
            btnExport.Tag = "baseitem-import";
            btnExport.Text = "批量导出";
            btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnExport.Click += btnExport_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAdd.Location = new System.Drawing.Point(20, 13);
            btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Symbol = 61846;
            btnAdd.TabIndex = 6;
            btnAdd.Tag = "template-add";
            btnAdd.Text = "新增模板";
            btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnModify.Location = new System.Drawing.Point(155, 13);
            btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Symbol = 61508;
            btnModify.TabIndex = 7;
            btnModify.Tag = "template-edit";
            btnModify.Text = "修改模板";
            btnModify.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnModify.Visible = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnDelete.Location = new System.Drawing.Point(290, 13);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Symbol = 61460;
            btnDelete.TabIndex = 8;
            btnDelete.Tag = "template-delete";
            btnDelete.Text = "删除模板";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnQuery);
            panel5.Controls.Add(txtKeywords);
            panel5.Dock = System.Windows.Forms.DockStyle.Right;
            panel5.Location = new System.Drawing.Point(1676, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(383, 69);
            panel5.TabIndex = 0;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(316, 11);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 5;
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
            txtKeywords.Location = new System.Drawing.Point(83, 12);
            txtKeywords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKeywords.Maximum = 2147483647D;
            txtKeywords.Minimum = -2147483648D;
            txtKeywords.MinimumSize = new System.Drawing.Size(1, 16);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtKeywords.Size = new System.Drawing.Size(204, 42);
            txtKeywords.Style = Sunny.UI.UIStyle.White;
            txtKeywords.StyleCustomMode = true;
            txtKeywords.TabIndex = 4;
            txtKeywords.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtKeywords.Watermark = "物料编码";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, ItemCode, TemplateType, TemplateName, TemplateURL, OrganizeRemark, Column3, Column4, Column5 });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(30, 69);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(2059, 804);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 12;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "ItemCode";
            ItemCode.HeaderText = "物料编码";
            ItemCode.MinimumWidth = 6;
            ItemCode.Name = "ItemCode";
            ItemCode.ReadOnly = true;
            ItemCode.Width = 200;
            // 
            // TemplateType
            // 
            TemplateType.DataPropertyName = "TemplateType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TemplateType.DefaultCellStyle = dataGridViewCellStyle3;
            TemplateType.HeaderText = "模板类型";
            TemplateType.MinimumWidth = 6;
            TemplateType.Name = "TemplateType";
            TemplateType.ReadOnly = true;
            TemplateType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TemplateType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            TemplateType.Width = 230;
            // 
            // TemplateName
            // 
            TemplateName.DataPropertyName = "TemplateName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TemplateName.DefaultCellStyle = dataGridViewCellStyle4;
            TemplateName.HeaderText = "模板名称";
            TemplateName.MinimumWidth = 6;
            TemplateName.Name = "TemplateName";
            TemplateName.ReadOnly = true;
            TemplateName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TemplateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            TemplateName.Width = 300;
            // 
            // TemplateURL
            // 
            TemplateURL.DataPropertyName = "TemplateURL";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TemplateURL.DefaultCellStyle = dataGridViewCellStyle5;
            TemplateURL.HeaderText = "保存路径";
            TemplateURL.MinimumWidth = 6;
            TemplateURL.Name = "TemplateURL";
            TemplateURL.ReadOnly = true;
            TemplateURL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TemplateURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            TemplateURL.Width = 125;
            // 
            // OrganizeRemark
            // 
            OrganizeRemark.DataPropertyName = "PrintCount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.DefaultCellStyle = dataGridViewCellStyle6;
            OrganizeRemark.HeaderText = "打印份数";
            OrganizeRemark.MinimumWidth = 6;
            OrganizeRemark.Name = "OrganizeRemark";
            OrganizeRemark.ReadOnly = true;
            OrganizeRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeRemark.Width = 80;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "IsEnabled";
            Column3.HeaderText = "是否启用";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ModifyTime";
            Column4.HeaderText = "维护时间";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 180;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ModifyUser";
            Column5.HeaderText = "维护人";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(30, 873);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 25;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(2059, 42);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 13;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            // 
            // TemplateManagePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2119, 915);
            Controls.Add(dataGridView);
            Controls.Add(pagination);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "TemplateManagePage";
            Text = "TemplateManagePage";
            Initialize += TemplateManagePage_Initialize;
            Load += TemplateManagePage_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtKeywords;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPagination pagination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Sunny.UI.UISymbolButton btnExport;
    }
}