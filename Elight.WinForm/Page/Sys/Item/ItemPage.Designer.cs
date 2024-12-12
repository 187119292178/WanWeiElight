namespace Elight.WinForm.Page.Sys.Item
{
    partial class ItemPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel10 = new System.Windows.Forms.Panel();
            pagination = new Sunny.UI.UIPagination();
            dataGridView = new Sunny.UI.UIDataGridView();
            ItemDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemDetailEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemDetailName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemDetailSortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel9 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnManage = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            panel12 = new System.Windows.Forms.Panel();
            panel11 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            treeView = new Sunny.UI.UITreeView();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel9.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(2140, 1018);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel6);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(2140, 1018);
            panel5.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.Color.White;
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(panel11);
            panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            panel8.Location = new System.Drawing.Point(243, 30);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(1875, 988);
            panel8.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.Controls.Add(pagination);
            panel10.Controls.Add(dataGridView);
            panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            panel10.Location = new System.Drawing.Point(30, 70);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(1815, 918);
            panel10.TabIndex = 11;
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
            pagination.Size = new System.Drawing.Size(1815, 42);
            pagination.Style = Sunny.UI.UIStyle.White;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 14;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ItemDetailId, ItemDetailEncode, ItemDetailName, ItemDetailSortCode });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeight = 29;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectedIndex = -1;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowGridLine = true;
            dataGridView.Size = new System.Drawing.Size(1815, 367);
            dataGridView.StripeOddColor = System.Drawing.Color.White;
            dataGridView.Style = Sunny.UI.UIStyle.White;
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 13;
            // 
            // ItemDetailId
            // 
            ItemDetailId.DataPropertyName = "Id";
            ItemDetailId.HeaderText = "Id";
            ItemDetailId.MinimumWidth = 6;
            ItemDetailId.Name = "ItemDetailId";
            ItemDetailId.ReadOnly = true;
            ItemDetailId.Visible = false;
            ItemDetailId.Width = 125;
            // 
            // ItemDetailEncode
            // 
            ItemDetailEncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemDetailEncode.DataPropertyName = "Encode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailEncode.DefaultCellStyle = dataGridViewCellStyle3;
            ItemDetailEncode.HeaderText = "编码";
            ItemDetailEncode.MinimumWidth = 6;
            ItemDetailEncode.Name = "ItemDetailEncode";
            ItemDetailEncode.ReadOnly = true;
            ItemDetailEncode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailEncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemDetailName
            // 
            ItemDetailName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemDetailName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailName.DefaultCellStyle = dataGridViewCellStyle4;
            ItemDetailName.HeaderText = "名称";
            ItemDetailName.MinimumWidth = 6;
            ItemDetailName.Name = "ItemDetailName";
            ItemDetailName.ReadOnly = true;
            ItemDetailName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemDetailSortCode
            // 
            ItemDetailSortCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemDetailSortCode.DataPropertyName = "SortCode";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailSortCode.DefaultCellStyle = dataGridViewCellStyle5;
            ItemDetailSortCode.HeaderText = "排序码";
            ItemDetailSortCode.MinimumWidth = 6;
            ItemDetailSortCode.Name = "ItemDetailSortCode";
            ItemDetailSortCode.ReadOnly = true;
            ItemDetailSortCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemDetailSortCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel9
            // 
            panel9.Controls.Add(flowLayoutPanel1);
            panel9.Dock = System.Windows.Forms.DockStyle.Top;
            panel9.Location = new System.Drawing.Point(30, 0);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(1815, 70);
            panel9.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnManage);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnModify);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1815, 70);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnManage
            // 
            btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnManage.FillColor = System.Drawing.Color.White;
            btnManage.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnManage.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnManage.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnManage.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnManage.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnManage.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnManage.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnManage.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnManage.Location = new System.Drawing.Point(10, 13);
            btnManage.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnManage.MinimumSize = new System.Drawing.Size(1, 1);
            btnManage.Name = "btnManage";
            btnManage.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnManage.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnManage.Size = new System.Drawing.Size(125, 44);
            btnManage.Style = Sunny.UI.UIStyle.Custom;
            btnManage.Symbol = 61717;
            btnManage.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnManage.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnManage.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnManage.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnManage.TabIndex = 9;
            btnManage.Tag = "item-manage";
            btnManage.Text = "字典管理";
            btnManage.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnManage.Visible = false;
            btnManage.Click += btnManage_Click;
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
            btnAdd.Location = new System.Drawing.Point(145, 13);
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
            btnAdd.TabIndex = 6;
            btnAdd.Tag = "item-add";
            btnAdd.Text = "新增选项";
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
            btnModify.Location = new System.Drawing.Point(280, 13);
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
            btnModify.TabIndex = 7;
            btnModify.Tag = "item-edit";
            btnModify.Text = "修改选项";
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
            btnDelete.Location = new System.Drawing.Point(415, 13);
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
            btnDelete.TabIndex = 8;
            btnDelete.Tag = "item-delete";
            btnDelete.Text = "删除选项";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel12
            // 
            panel12.Dock = System.Windows.Forms.DockStyle.Left;
            panel12.Location = new System.Drawing.Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(30, 988);
            panel12.TabIndex = 12;
            // 
            // panel11
            // 
            panel11.Dock = System.Windows.Forms.DockStyle.Right;
            panel11.Location = new System.Drawing.Point(1845, 0);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(30, 988);
            panel11.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Dock = System.Windows.Forms.DockStyle.Left;
            panel7.Location = new System.Drawing.Point(233, 30);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(10, 988);
            panel7.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(treeView);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(19, 30);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(214, 988);
            panel1.TabIndex = 11;
            // 
            // treeView
            // 
            treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView.FillColor = System.Drawing.Color.White;
            treeView.FillColor2 = System.Drawing.Color.White;
            treeView.Font = new System.Drawing.Font("微软雅黑", 12F);
            treeView.Location = new System.Drawing.Point(0, 0);
            treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            treeView.MinimumSize = new System.Drawing.Size(1, 1);
            treeView.Name = "treeView";
            treeView.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            treeView.SelectedNode = null;
            treeView.Size = new System.Drawing.Size(214, 988);
            treeView.Style = Sunny.UI.UIStyle.White;
            treeView.StyleCustomMode = true;
            treeView.TabIndex = 0;
            treeView.Text = "uiTreeView1";
            treeView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(2118, 30);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(22, 988);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(19, 988);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(2140, 30);
            panel6.TabIndex = 9;
            // 
            // ItemPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(2140, 1018);
            Controls.Add(panel2);
            Name = "ItemPage";
            Style = Sunny.UI.UIStyle.Custom;
            StyleCustomMode = true;
            Symbol = 61672;
            Text = "数据字典";
            Initialize += ItemPage_Initialize;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel9.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnManage;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UITreeView treeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetailEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetailName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetailSortCode;
        private System.Windows.Forms.Panel panel10;
    }
}