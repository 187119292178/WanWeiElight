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
            txtKeywords = new Sunny.UI.UITextBox();
            panel7 = new System.Windows.Forms.Panel();
            btnQuery = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnAuthorize = new Sunny.UI.UISymbolButton();
            pagination = new Sunny.UI.UIPagination();
            dataGridView = new Sunny.UI.UIDataGridView();
            RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoleSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
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
            txtKeywords.Location = new System.Drawing.Point(7, 13);
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
            txtKeywords.Watermark = "角色名称或编码";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnQuery);
            panel7.Controls.Add(txtKeywords);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(-326, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(326, 70);
            panel7.TabIndex = 3;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(218, 12);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 2;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
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
            btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnAdd.Size = new System.Drawing.Size(125, 44);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.Symbol = 61846;
            btnAdd.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAdd.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAdd.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAdd.TabIndex = 0;
            btnAdd.Tag = "role-add";
            btnAdd.Text = "新增角色";
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
            btnModify.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnModify.Size = new System.Drawing.Size(125, 44);
            btnModify.Style = Sunny.UI.UIStyle.Custom;
            btnModify.Symbol = 61508;
            btnModify.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnModify.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnModify.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnModify.TabIndex = 4;
            btnModify.Tag = "role-edit";
            btnModify.Text = "修改角色";
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
            btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.TabIndex = 5;
            btnDelete.Tag = "role-delete";
            btnDelete.Text = "删除角色";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnModify);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnAuthorize);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(0, 70);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAuthorize
            // 
            btnAuthorize.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAuthorize.FillColor = System.Drawing.Color.White;
            btnAuthorize.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAuthorize.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAuthorize.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnAuthorize.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAuthorize.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAuthorize.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAuthorize.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAuthorize.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAuthorize.Location = new System.Drawing.Point(10, 184);
            btnAuthorize.Margin = new System.Windows.Forms.Padding(10, 13, 0, 0);
            btnAuthorize.MinimumSize = new System.Drawing.Size(1, 1);
            btnAuthorize.Name = "btnAuthorize";
            btnAuthorize.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnAuthorize.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnAuthorize.Size = new System.Drawing.Size(125, 44);
            btnAuthorize.Style = Sunny.UI.UIStyle.Custom;
            btnAuthorize.Symbol = 61606;
            btnAuthorize.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnAuthorize.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnAuthorize.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAuthorize.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnAuthorize.TabIndex = 6;
            btnAuthorize.Tag = "role-authorize";
            btnAuthorize.Text = "角色授权";
            btnAuthorize.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAuthorize.Visible = false;
            btnAuthorize.Click += btnAuthorize_Click;
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
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(1, 42);
            pagination.Style = Sunny.UI.UIStyle.White;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 11;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { RoleId, RoleEncode, RoleName, RoleType, RoleDept, RoleSortCode });
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
            dataGridView.Size = new System.Drawing.Size(0, 367);
            dataGridView.StripeOddColor = System.Drawing.Color.White;
            dataGridView.Style = Sunny.UI.UIStyle.White;
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 10;
            // 
            // RoleId
            // 
            RoleId.DataPropertyName = "Id";
            RoleId.HeaderText = "Id";
            RoleId.MinimumWidth = 6;
            RoleId.Name = "RoleId";
            RoleId.ReadOnly = true;
            RoleId.Visible = false;
            RoleId.Width = 125;
            // 
            // RoleEncode
            // 
            RoleEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleEncode.DataPropertyName = "Encode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleEncode.DefaultCellStyle = dataGridViewCellStyle3;
            RoleEncode.HeaderText = "编码";
            RoleEncode.MinimumWidth = 6;
            RoleEncode.Name = "RoleEncode";
            RoleEncode.ReadOnly = true;
            RoleEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleName
            // 
            RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleName.DefaultCellStyle = dataGridViewCellStyle4;
            RoleName.HeaderText = "名称";
            RoleName.MinimumWidth = 6;
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            RoleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleType
            // 
            RoleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleType.DataPropertyName = "TypeStr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleType.DefaultCellStyle = dataGridViewCellStyle5;
            RoleType.HeaderText = "类型";
            RoleType.MinimumWidth = 6;
            RoleType.Name = "RoleType";
            RoleType.ReadOnly = true;
            RoleType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleDept
            // 
            RoleDept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoleDept.DataPropertyName = "DeptName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RoleDept.DefaultCellStyle = dataGridViewCellStyle6;
            RoleDept.HeaderText = "所属部门";
            RoleDept.MinimumWidth = 6;
            RoleDept.Name = "RoleDept";
            RoleDept.ReadOnly = true;
            RoleDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            RoleDept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(0, 0);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(0, 0);
            panel5.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(pagination);
            panel8.Controls.Add(dataGridView);
            panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            panel8.Location = new System.Drawing.Point(30, 70);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(0, 0);
            panel8.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(30, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(0, 70);
            panel6.TabIndex = 12;
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
            // RolePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(0, 0);
            Controls.Add(panel2);
            Name = "RolePage";
            Style = Sunny.UI.UIStyle.Custom;
            StyleCustomMode = true;
            Symbol = 61632;
            Text = "角色管理";
            Initialize += RolePage_Initialize;
            panel7.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
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