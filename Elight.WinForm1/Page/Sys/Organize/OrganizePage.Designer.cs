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
            this.pagination = new Sunny.UI.UIPagination();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new Sunny.UI.UIDataGridView();
            this.OrganizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizeEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizeRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.btnModify = new Sunny.UI.UISymbolButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.txtKeywords = new Sunny.UI.UITextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagination
            // 
            this.pagination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagination.FillColor = System.Drawing.Color.White;
            this.pagination.FillColor2 = System.Drawing.Color.White;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(0, 367);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 5;
            this.pagination.PageSize = 10;
            this.pagination.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.Size = new System.Drawing.Size(1522, 42);
            this.pagination.Style = Sunny.UI.UIStyle.White;
            this.pagination.StyleCustomMode = true;
            this.pagination.TabIndex = 11;
            this.pagination.Text = "uiPagination1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1582, 902);
            this.panel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pagination);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 832);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 32;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizeId,
            this.OrganizeEncode,
            this.OrganizeName,
            this.OrganizeType,
            this.OrganizeRemark,
            this.RoleSortCode});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeight = 29;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectedIndex = -1;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowGridLine = true;
            this.dataGridView.Size = new System.Drawing.Size(1522, 367);
            this.dataGridView.StripeOddColor = System.Drawing.Color.White;
            this.dataGridView.Style = Sunny.UI.UIStyle.White;
            this.dataGridView.StyleCustomMode = true;
            this.dataGridView.TabIndex = 10;
            // 
            // OrganizeId
            // 
            this.OrganizeId.DataPropertyName = "Id";
            this.OrganizeId.HeaderText = "Id";
            this.OrganizeId.MinimumWidth = 6;
            this.OrganizeId.Name = "OrganizeId";
            this.OrganizeId.ReadOnly = true;
            this.OrganizeId.Visible = false;
            this.OrganizeId.Width = 125;
            // 
            // OrganizeEncode
            // 
            this.OrganizeEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrganizeEncode.DataPropertyName = "Encode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeEncode.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrganizeEncode.HeaderText = "编码";
            this.OrganizeEncode.MinimumWidth = 6;
            this.OrganizeEncode.Name = "OrganizeEncode";
            this.OrganizeEncode.ReadOnly = true;
            this.OrganizeEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeName
            // 
            this.OrganizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrganizeName.DataPropertyName = "FullName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeName.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrganizeName.HeaderText = "名称";
            this.OrganizeName.MinimumWidth = 6;
            this.OrganizeName.Name = "OrganizeName";
            this.OrganizeName.ReadOnly = true;
            this.OrganizeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeType
            // 
            this.OrganizeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrganizeType.DataPropertyName = "TypeStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeType.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrganizeType.HeaderText = "类型";
            this.OrganizeType.MinimumWidth = 6;
            this.OrganizeType.Name = "OrganizeType";
            this.OrganizeType.ReadOnly = true;
            this.OrganizeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrganizeRemark
            // 
            this.OrganizeRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrganizeRemark.DataPropertyName = "Remark";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeRemark.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrganizeRemark.HeaderText = "备注";
            this.OrganizeRemark.MinimumWidth = 6;
            this.OrganizeRemark.Name = "OrganizeRemark";
            this.OrganizeRemark.ReadOnly = true;
            this.OrganizeRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizeRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleSortCode
            // 
            this.RoleSortCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleSortCode.DataPropertyName = "SortCode";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleSortCode.DefaultCellStyle = dataGridViewCellStyle7;
            this.RoleSortCode.HeaderText = "排序码";
            this.RoleSortCode.MinimumWidth = 6;
            this.RoleSortCode.Name = "RoleSortCode";
            this.RoleSortCode.ReadOnly = true;
            this.RoleSortCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleSortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1522, 70);
            this.panel6.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnModify);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1252, 70);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAdd.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAdd.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.Location = new System.Drawing.Point(10, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnAdd.Size = new System.Drawing.Size(125, 44);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.Symbol = 61846;
            this.btnAdd.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAdd.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAdd.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "org-add";
            this.btnAdd.Text = "新增机构";
            this.btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FillColor = System.Drawing.Color.White;
            this.btnModify.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnModify.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnModify.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnModify.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnModify.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.Location = new System.Drawing.Point(145, 13);
            this.btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModify.Name = "btnModify";
            this.btnModify.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnModify.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnModify.Size = new System.Drawing.Size(125, 44);
            this.btnModify.Style = Sunny.UI.UIStyle.Custom;
            this.btnModify.Symbol = 61508;
            this.btnModify.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnModify.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnModify.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.TabIndex = 4;
            this.btnModify.Tag = "org-edit";
            this.btnModify.Text = "修改机构";
            this.btnModify.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnDelete.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.Location = new System.Drawing.Point(280, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnDelete.Size = new System.Drawing.Size(125, 44);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.Symbol = 61460;
            this.btnDelete.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Tag = "org-delete";
            this.btnDelete.Text = "删除机构";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQuery);
            this.panel7.Controls.Add(this.txtKeywords);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1252, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 70);
            this.panel7.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnQuery.Location = new System.Drawing.Point(222, 13);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 43);
            this.btnQuery.StyleCustomMode = true;
            this.btnQuery.Symbol = 61442;
            this.btnQuery.SymbolSize = 30;
            this.btnQuery.TabIndex = 3;
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtKeywords
            // 
            this.txtKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeywords.ButtonFillColor = System.Drawing.Color.White;
            this.txtKeywords.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtKeywords.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtKeywords.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txtKeywords.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtKeywords.ButtonForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.txtKeywords.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtKeywords.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtKeywords.ButtonSymbol = 61761;
            this.txtKeywords.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeywords.FillColor2 = System.Drawing.Color.White;
            this.txtKeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtKeywords.Location = new System.Drawing.Point(11, 14);
            this.txtKeywords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeywords.Maximum = 2147483647D;
            this.txtKeywords.Minimum = -2147483648D;
            this.txtKeywords.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtKeywords.Size = new System.Drawing.Size(204, 42);
            this.txtKeywords.Style = Sunny.UI.UIStyle.White;
            this.txtKeywords.StyleCustomMode = true;
            this.txtKeywords.TabIndex = 0;
            this.txtKeywords.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKeywords.Watermark = "机构名称或编码";
            this.txtKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywords_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1552, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 902);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 902);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 902);
            this.panel2.TabIndex = 5;
            // 
            // OrganizePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1582, 902);
            this.Controls.Add(this.panel2);
            this.Name = "OrganizePage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Symbol = 61869;
            this.Text = "组织机构";
            this.Initialize += new System.EventHandler(this.OrganizePage_Initialize);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPagination pagination;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
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
    }
}