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
            dataGridView = new Sunny.UI.UIDataGridView();
            UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pagination = new Sunny.UI.UIPagination();
            panel6 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            panel7 = new System.Windows.Forms.Panel();
            txtKeywords = new Sunny.UI.UITextBox();
            btnQuery = new Sunny.UI.UISymbolButton();
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { UserId, UserAccount, UserName, UserGender, UserTel, UserDepartment });
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
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(0, 0);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 10;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "Id";
            UserId.HeaderText = "Id";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            UserId.Width = 125;
            // 
            // UserAccount
            // 
            UserAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserAccount.DataPropertyName = "Account";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            UserAccount.DefaultCellStyle = dataGridViewCellStyle3;
            UserAccount.HeaderText = "账号";
            UserAccount.MinimumWidth = 6;
            UserAccount.Name = "UserAccount";
            UserAccount.ReadOnly = true;
            UserAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            UserAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "RealName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            UserName.DefaultCellStyle = dataGridViewCellStyle4;
            UserName.HeaderText = "姓名";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserGender
            // 
            UserGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserGender.DataPropertyName = "GenderStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            UserGender.DefaultCellStyle = dataGridViewCellStyle5;
            UserGender.HeaderText = "性别";
            UserGender.MinimumWidth = 6;
            UserGender.Name = "UserGender";
            UserGender.ReadOnly = true;
            UserGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            UserGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserTel
            // 
            UserTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserTel.DataPropertyName = "MobilePhone";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            UserTel.DefaultCellStyle = dataGridViewCellStyle6;
            UserTel.HeaderText = "手机";
            UserTel.MinimumWidth = 6;
            UserTel.Name = "UserTel";
            UserTel.ReadOnly = true;
            UserTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            UserTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserDepartment
            // 
            UserDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserDepartment.DataPropertyName = "DeptName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            UserDepartment.DefaultCellStyle = dataGridViewCellStyle7;
            UserDepartment.HeaderText = "部门";
            UserDepartment.MinimumWidth = 6;
            UserDepartment.Name = "UserDepartment";
            UserDepartment.ReadOnly = true;
            UserDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            UserDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(0, 0);
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
            panel5.Size = new System.Drawing.Size(0, 0);
            panel5.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(pagination);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(0, 0);
            panel1.TabIndex = 13;
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
            pagination.PageSize = 10;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(1, 42);
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
            panel6.Size = new System.Drawing.Size(0, 70);
            panel6.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnModify);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(uiSymbolButton1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(0, 70);
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
            btnAdd.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.StyleCustomMode = true;
            btnAdd.Symbol = 61846;
            btnAdd.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAdd.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAdd.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.TabIndex = 0;
            btnAdd.Tag = "user-add";
            btnAdd.TagString = "";
            btnAdd.Text = "新增用户";
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
            btnModify.Location = new System.Drawing.Point(10, 70);
            btnModify.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnModify.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Style = Sunny.UI.UIStyle.Custom;
            btnModify.StyleCustomMode = true;
            btnModify.Symbol = 61508;
            btnModify.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnModify.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnModify.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.TabIndex = 4;
            btnModify.Tag = "user-edit";
            btnModify.TagString = "";
            btnModify.Text = "修改用户";
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
            btnDelete.Location = new System.Drawing.Point(10, 127);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.StyleCustomMode = true;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.TabIndex = 5;
            btnDelete.Tag = "user-delete";
            btnDelete.TagString = "";
            btnDelete.Text = "删除用户";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
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
            uiSymbolButton1.Location = new System.Drawing.Point(10, 184);
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
            panel7.Controls.Add(txtKeywords);
            panel7.Controls.Add(btnQuery);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(-281, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(281, 70);
            panel7.TabIndex = 3;
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
            txtKeywords.Location = new System.Drawing.Point(21, 14);
            txtKeywords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKeywords.Maximum = 2147483647D;
            txtKeywords.Minimum = -2147483648D;
            txtKeywords.MinimumSize = new System.Drawing.Size(1, 16);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtKeywords.Size = new System.Drawing.Size(204, 42);
            txtKeywords.Style = Sunny.UI.UIStyle.White;
            txtKeywords.StyleCustomMode = true;
            txtKeywords.TabIndex = 2;
            txtKeywords.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtKeywords.Watermark = "用户账号或姓名";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(232, 12);
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
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(-30, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 0);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 0);
            panel3.TabIndex = 4;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(0, 0);
            Controls.Add(panel2);
            Name = "UserPage";
            Style = Sunny.UI.UIStyle.Custom;
            StyleCustomMode = true;
            Symbol = 61447;
            Text = "用户管理";
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
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