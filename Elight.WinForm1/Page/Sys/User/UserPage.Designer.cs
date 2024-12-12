namespace Elight.WinForm.Page.Sys.User
{
    partial class UserPage
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
            this.dataGridView = new Sunny.UI.UIDataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagination = new Sunny.UI.UIPagination();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.btnModify = new Sunny.UI.UISymbolButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtKeywords = new Sunny.UI.UITextBox();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.UserId,
            this.UserAccount,
            this.UserName,
            this.UserGender,
            this.UserTel,
            this.UserDepartment});
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
            this.dataGridView.Size = new System.Drawing.Size(1320, 367);
            this.dataGridView.StripeOddColor = System.Drawing.Color.White;
            this.dataGridView.Style = Sunny.UI.UIStyle.White;
            this.dataGridView.StyleCustomMode = true;
            this.dataGridView.TabIndex = 10;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "Id";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // UserAccount
            // 
            this.UserAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserAccount.DataPropertyName = "Account";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserAccount.HeaderText = "账号";
            this.UserAccount.MinimumWidth = 6;
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.ReadOnly = true;
            this.UserAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "RealName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserName.DefaultCellStyle = dataGridViewCellStyle4;
            this.UserName.HeaderText = "姓名";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserGender
            // 
            this.UserGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGender.DataPropertyName = "GenderStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGender.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserGender.HeaderText = "性别";
            this.UserGender.MinimumWidth = 6;
            this.UserGender.Name = "UserGender";
            this.UserGender.ReadOnly = true;
            this.UserGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserTel
            // 
            this.UserTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserTel.DataPropertyName = "MobilePhone";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTel.DefaultCellStyle = dataGridViewCellStyle6;
            this.UserTel.HeaderText = "手机";
            this.UserTel.MinimumWidth = 6;
            this.UserTel.Name = "UserTel";
            this.UserTel.ReadOnly = true;
            this.UserTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserDepartment
            // 
            this.UserDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserDepartment.DataPropertyName = "DeptName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDepartment.DefaultCellStyle = dataGridViewCellStyle7;
            this.UserDepartment.HeaderText = "部门";
            this.UserDepartment.MinimumWidth = 6;
            this.UserDepartment.Name = "UserDepartment";
            this.UserDepartment.ReadOnly = true;
            this.UserDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 635);
            this.panel2.TabIndex = 3;
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
            this.panel5.Size = new System.Drawing.Size(1380, 635);
            this.panel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pagination);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 565);
            this.panel1.TabIndex = 13;
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
            this.pagination.Size = new System.Drawing.Size(1320, 42);
            this.pagination.Style = Sunny.UI.UIStyle.White;
            this.pagination.StyleCustomMode = true;
            this.pagination.TabIndex = 11;
            this.pagination.Text = "uiPagination1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1320, 70);
            this.panel6.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnModify);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(uiSymbolButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1039, 70);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAdd.Size = new System.Drawing.Size(125, 44);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.StyleCustomMode = true;
            this.btnAdd.Symbol = 61846;
            this.btnAdd.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAdd.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAdd.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "user-add";
            this.btnAdd.TagString = "";
            this.btnAdd.Text = "新增用户";
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
            this.btnModify.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnModify.Size = new System.Drawing.Size(125, 44);
            this.btnModify.Style = Sunny.UI.UIStyle.Custom;
            this.btnModify.StyleCustomMode = true;
            this.btnModify.Symbol = 61508;
            this.btnModify.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnModify.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnModify.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnModify.TabIndex = 4;
            this.btnModify.Tag = "user-edit";
            this.btnModify.TagString = "";
            this.btnModify.Text = "修改用户";
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
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.Size = new System.Drawing.Size(125, 44);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.StyleCustomMode = true;
            this.btnDelete.Symbol = 61460;
            this.btnDelete.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Tag = "user-delete";
            this.btnDelete.TagString = "";
            this.btnDelete.Text = "删除用户";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            uiSymbolButton1.FillColor = System.Drawing.Color.White;
            uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiSymbolButton1.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            uiSymbolButton1.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            uiSymbolButton1.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            uiSymbolButton1.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            uiSymbolButton1.Location = new System.Drawing.Point(415, 13);
            uiSymbolButton1.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            uiSymbolButton1.Size = new System.Drawing.Size(125, 44);
            uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton1.StyleCustomMode = true;
            uiSymbolButton1.Symbol = 61470;
            uiSymbolButton1.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            uiSymbolButton1.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            uiSymbolButton1.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            uiSymbolButton1.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            uiSymbolButton1.TabIndex = 6;
            uiSymbolButton1.Tag = "reset_password";
            uiSymbolButton1.TagString = "";
            uiSymbolButton1.Text = "重置密码";
            uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiSymbolButton1.Visible = false;
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtKeywords);
            this.panel7.Controls.Add(this.btnQuery);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1039, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 70);
            this.panel7.TabIndex = 3;
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
            this.txtKeywords.Location = new System.Drawing.Point(21, 14);
            this.txtKeywords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeywords.Maximum = 2147483647D;
            this.txtKeywords.Minimum = -2147483648D;
            this.txtKeywords.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtKeywords.Size = new System.Drawing.Size(204, 42);
            this.txtKeywords.Style = Sunny.UI.UIStyle.White;
            this.txtKeywords.StyleCustomMode = true;
            this.txtKeywords.TabIndex = 2;
            this.txtKeywords.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKeywords.Watermark = "用户账号或姓名";
            this.txtKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywords_KeyDown);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnQuery.Location = new System.Drawing.Point(232, 12);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 43);
            this.btnQuery.StyleCustomMode = true;
            this.btnQuery.Symbol = 61442;
            this.btnQuery.SymbolSize = 30;
            this.btnQuery.TabIndex = 3;
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1350, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 635);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 635);
            this.panel3.TabIndex = 4;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1380, 635);
            this.Controls.Add(this.panel2);
            this.Name = "UserPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Symbol = 61447;
            this.Text = "用户管理";
            this.Initialize += new System.EventHandler(this.UserPage_Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDepartment;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtKeywords;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1; 
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}