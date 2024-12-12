namespace Elight.WinForm.Page.Sys.Role
{
    partial class RolePage
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
            this.txtKeywords = new Sunny.UI.UITextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.btnModify = new Sunny.UI.UISymbolButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAuthorize = new Sunny.UI.UISymbolButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.dataGridView = new Sunny.UI.UIDataGridView();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.txtKeywords.Location = new System.Drawing.Point(7, 13);
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
            this.txtKeywords.Watermark = "角色名称或编码";
            this.txtKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywords_KeyDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQuery);
            this.panel7.Controls.Add(this.txtKeywords);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1060, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(326, 70);
            this.panel7.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnQuery.Location = new System.Drawing.Point(218, 12);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 43);
            this.btnQuery.StyleCustomMode = true;
            this.btnQuery.Symbol = 61442;
            this.btnQuery.SymbolSize = 30;
            this.btnQuery.TabIndex = 2;
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
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
            this.btnAdd.Tag = "role-add";
            this.btnAdd.Text = "新增角色";
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
            this.btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
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
            this.btnModify.Tag = "role-edit";
            this.btnModify.Text = "修改角色";
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
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
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
            this.btnDelete.Tag = "role-delete";
            this.btnDelete.Text = "删除角色";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnModify);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnAuthorize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1386, 70);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthorize.FillColor = System.Drawing.Color.White;
            this.btnAuthorize.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAuthorize.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAuthorize.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnAuthorize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAuthorize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAuthorize.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAuthorize.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAuthorize.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAuthorize.Location = new System.Drawing.Point(415, 13);
            this.btnAuthorize.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            this.btnAuthorize.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnAuthorize.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnAuthorize.Size = new System.Drawing.Size(125, 44);
            this.btnAuthorize.Style = Sunny.UI.UIStyle.Custom;
            this.btnAuthorize.Symbol = 61606;
            this.btnAuthorize.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAuthorize.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAuthorize.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAuthorize.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAuthorize.TabIndex = 6;
            this.btnAuthorize.Tag = "role-authorize";
            this.btnAuthorize.Text = "角色授权";
            this.btnAuthorize.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuthorize.Visible = false;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
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
            this.pagination.Size = new System.Drawing.Size(1386, 42);
            this.pagination.Style = Sunny.UI.UIStyle.White;
            this.pagination.StyleCustomMode = true;
            this.pagination.TabIndex = 11;
            this.pagination.Text = "uiPagination1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
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
            this.RoleId,
            this.RoleEncode,
            this.RoleName,
            this.RoleType,
            this.RoleDept,
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
            this.dataGridView.Size = new System.Drawing.Size(1386, 367);
            this.dataGridView.StripeOddColor = System.Drawing.Color.White;
            this.dataGridView.Style = Sunny.UI.UIStyle.White;
            this.dataGridView.StyleCustomMode = true;
            this.dataGridView.TabIndex = 10;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "Id";
            this.RoleId.HeaderText = "Id";
            this.RoleId.MinimumWidth = 6;
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            this.RoleId.Visible = false;
            this.RoleId.Width = 125;
            // 
            // RoleEncode
            // 
            this.RoleEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleEncode.DataPropertyName = "Encode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleEncode.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoleEncode.HeaderText = "编码";
            this.RoleEncode.MinimumWidth = 6;
            this.RoleEncode.Name = "RoleEncode";
            this.RoleEncode.ReadOnly = true;
            this.RoleEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleName
            // 
            this.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleName.DefaultCellStyle = dataGridViewCellStyle4;
            this.RoleName.HeaderText = "名称";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleType
            // 
            this.RoleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleType.DataPropertyName = "TypeStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleType.DefaultCellStyle = dataGridViewCellStyle5;
            this.RoleType.HeaderText = "类型";
            this.RoleType.MinimumWidth = 6;
            this.RoleType.Name = "RoleType";
            this.RoleType.ReadOnly = true;
            this.RoleType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleDept
            // 
            this.RoleDept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleDept.DataPropertyName = "DeptName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleDept.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoleDept.HeaderText = "所属部门";
            this.RoleDept.MinimumWidth = 6;
            this.RoleDept.Name = "RoleDept";
            this.RoleDept.ReadOnly = true;
            this.RoleDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleDept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1446, 756);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1446, 756);
            this.panel5.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pagination);
            this.panel8.Controls.Add(this.dataGridView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(30, 70);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1386, 686);
            this.panel8.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1386, 70);
            this.panel6.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1416, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 756);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 756);
            this.panel3.TabIndex = 4;
            // 
            // RolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1446, 756);
            this.Controls.Add(this.panel2);
            this.Name = "RolePage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Symbol = 61632;
            this.Text = "角色管理";
            this.Initialize += new System.EventHandler(this.RolePage_Initialize);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtKeywords;
        private System.Windows.Forms.Panel panel7; 
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UISymbolButton btnAuthorize;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleSortCode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
    }
}