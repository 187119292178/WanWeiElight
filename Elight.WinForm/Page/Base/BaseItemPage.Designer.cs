namespace Elight.WinForm.Page.Base
{
    partial class BaseItemPage
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
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            cmbMAType = new Sunny.UI.UIComboBox();
            btnQuery = new Sunny.UI.UISymbolButton();
            btnExport = new Sunny.UI.UISymbolButton();
            txtKeywords = new Sunny.UI.UITextBox();
            btnSave = new Sunny.UI.UISymbolButton();
            btnImport = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            panel1 = new System.Windows.Forms.Panel();
            dataGridView = new Sunny.UI.UIDataGridView();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MatModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OutputDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagination = new Sunny.UI.UIPagination();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 915);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(2089, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 915);
            panel4.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbMAType);
            panel2.Controls.Add(btnQuery);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(txtKeywords);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnModify);
            panel2.Controls.Add(btnDelete);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(30, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(2059, 69);
            panel2.TabIndex = 7;
            // 
            // cmbMAType
            // 
            cmbMAType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cmbMAType.DataSource = null;
            cmbMAType.FillColor = System.Drawing.Color.White;
            cmbMAType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbMAType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbMAType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbMAType.Location = new System.Drawing.Point(1565, 16);
            cmbMAType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbMAType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbMAType.Name = "cmbMAType";
            cmbMAType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbMAType.Size = new System.Drawing.Size(214, 41);
            cmbMAType.TabIndex = 83;
            cmbMAType.Text = "uiComboBox1";
            cmbMAType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cmbMAType.SelectedIndexChanged += cmbMAType_SelectedIndexChanged;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(1998, 15);
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
            // btnExport
            // 
            btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnExport.Location = new System.Drawing.Point(697, 13);
            btnExport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(125, 44);
            btnExport.Symbol = 61508;
            btnExport.TabIndex = 11;
            btnExport.Tag = "baseitem-import";
            btnExport.Text = "批量导出";
            btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnExport.Visible = false;
            btnExport.Click += btnExport_Click;
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
            txtKeywords.Location = new System.Drawing.Point(1787, 15);
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
            txtKeywords.Watermark = "物料名称或编码";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // btnSave
            // 
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSave.Location = new System.Drawing.Point(528, 13);
            btnSave.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(163, 44);
            btnSave.Symbol = 61508;
            btnSave.TabIndex = 10;
            btnSave.Tag = "baseitem-import";
            btnSave.Text = "批量保存提交";
            btnSave.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnImport
            // 
            btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImport.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnImport.Location = new System.Drawing.Point(397, 13);
            btnImport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnImport.MinimumSize = new System.Drawing.Size(1, 1);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(125, 44);
            btnImport.Symbol = 61508;
            btnImport.TabIndex = 9;
            btnImport.Tag = "baseitem-import";
            btnImport.Text = "批量导入";
            btnImport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnImport.Visible = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAdd.Location = new System.Drawing.Point(4, 13);
            btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Symbol = 61846;
            btnAdd.TabIndex = 6;
            btnAdd.Tag = "baseitem-add";
            btnAdd.Text = "新增物料";
            btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnModify.Location = new System.Drawing.Point(135, 13);
            btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Symbol = 61508;
            btnModify.TabIndex = 7;
            btnModify.Tag = "baseitem-edit";
            btnModify.Text = "修改物料";
            btnModify.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnModify.Visible = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnDelete.Location = new System.Drawing.Point(266, 13);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Symbol = 61460;
            btnDelete.TabIndex = 8;
            btnDelete.Tag = "baseitem-delete";
            btnDelete.Text = "删除物料";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(pagination);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(30, 69);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(2059, 846);
            panel1.TabIndex = 13;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ItemCode, OrganizeEncode, OrganizeName, OrganizeType, MatModel, RoleSortCode, Column1, OutputDesc, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(0, 0);
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
            dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(2059, 804);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 10;
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
            // OrganizeEncode
            // 
            OrganizeEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrganizeEncode.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.DefaultCellStyle = dataGridViewCellStyle3;
            OrganizeEncode.HeaderText = "物料名称";
            OrganizeEncode.MinimumWidth = 6;
            OrganizeEncode.Name = "OrganizeEncode";
            OrganizeEncode.ReadOnly = true;
            OrganizeEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeEncode.Width = 230;
            // 
            // OrganizeName
            // 
            OrganizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrganizeName.DataPropertyName = "ItemDesc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrganizeName.HeaderText = "规格型号";
            OrganizeName.MinimumWidth = 6;
            OrganizeName.Name = "OrganizeName";
            OrganizeName.ReadOnly = true;
            OrganizeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeName.Width = 300;
            // 
            // OrganizeType
            // 
            OrganizeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrganizeType.DataPropertyName = "MatType";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.DefaultCellStyle = dataGridViewCellStyle5;
            OrganizeType.HeaderText = "物料类型";
            OrganizeType.MinimumWidth = 6;
            OrganizeType.Name = "OrganizeType";
            OrganizeType.ReadOnly = true;
            OrganizeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeType.Width = 125;
            // 
            // MatModel
            // 
            MatModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            MatModel.DataPropertyName = "MatModel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            MatModel.DefaultCellStyle = dataGridViewCellStyle6;
            MatModel.HeaderText = "机型";
            MatModel.MinimumWidth = 6;
            MatModel.Name = "MatModel";
            MatModel.ReadOnly = true;
            MatModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            MatModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            MatModel.Visible = false;
            MatModel.Width = 120;
            // 
            // RoleSortCode
            // 
            RoleSortCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            RoleSortCode.DataPropertyName = "PackQty";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.DefaultCellStyle = dataGridViewCellStyle7;
            RoleSortCode.HeaderText = "包装数量";
            RoleSortCode.MinimumWidth = 6;
            RoleSortCode.Name = "RoleSortCode";
            RoleSortCode.ReadOnly = true;
            RoleSortCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleSortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            RoleSortCode.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PalletQty";
            Column1.HeaderText = "堆栈数量";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // OutputDesc
            // 
            OutputDesc.DataPropertyName = "OutputDesc";
            OutputDesc.HeaderText = "OutputDesc";
            OutputDesc.MinimumWidth = 6;
            OutputDesc.Name = "OutputDesc";
            OutputDesc.ReadOnly = true;
            OutputDesc.Visible = false;
            OutputDesc.Width = 210;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SourceDesc";
            Column2.HeaderText = "SourceDesc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            Column2.Width = 210;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "IsEnabled";
            Column3.HeaderText = "是否启用";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
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
            pagination.Location = new System.Drawing.Point(0, 804);
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
            pagination.TabIndex = 11;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            pagination.Click += pagination_Click;
            // 
            // BaseItemPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2119, 915);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "BaseItemPage";
            Text = "BaseItemPage";
            Initialize += BaseItemPage_Initialize;
            Load += BaseItemPage_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtKeywords;
        private Sunny.UI.UISymbolButton btnImport;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleSortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Sunny.UI.UIComboBox cmbMAType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatModel;
    }
}