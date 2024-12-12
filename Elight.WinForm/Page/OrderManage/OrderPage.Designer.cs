namespace Elight.WinForm.Page.OrderManage
{
    partial class OrderPage
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
            btnSave = new Sunny.UI.UISymbolButton();
            btnCreated = new Sunny.UI.UISymbolButton();
            btnImport = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            btnModify = new Sunny.UI.UISymbolButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnQuery = new Sunny.UI.UISymbolButton();
            txtItemCode = new Sunny.UI.UITextBox();
            pagination = new Sunny.UI.UIPagination();
            dataGridView = new Sunny.UI.UIDataGridView();
            OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrganizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TargetQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PackQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1 = new Sunny.UI.UIPanel();
            cmbMatType = new Sunny.UI.UIComboBox();
            uiLabel2 = new Sunny.UI.UILabel();
            cmbState = new Sunny.UI.UIComboBox();
            uiLabel4 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            dpEnd = new Sunny.UI.UIDatePicker();
            dpFrom = new Sunny.UI.UIDatePicker();
            uiLabel1 = new Sunny.UI.UILabel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 0);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(-30, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 0);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCreated);
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnModify);
            panel2.Controls.Add(btnDelete);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(30, 58);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(0, 69);
            panel2.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSave.Location = new System.Drawing.Point(759, 12);
            btnSave.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(163, 44);
            btnSave.Symbol = 61508;
            btnSave.TabIndex = 12;
            btnSave.Tag = "orderinfo-save";
            btnSave.Text = "批量保存提交";
            btnSave.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnSave.Visible = false;
            // 
            // btnCreated
            // 
            btnCreated.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreated.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnCreated.Location = new System.Drawing.Point(438, 13);
            btnCreated.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnCreated.MinimumSize = new System.Drawing.Size(1, 1);
            btnCreated.Name = "btnCreated";
            btnCreated.Size = new System.Drawing.Size(125, 44);
            btnCreated.Symbol = 61508;
            btnCreated.TabIndex = 11;
            btnCreated.Tag = "orderinfo-createdsn";
            btnCreated.Text = "工单生码";
            btnCreated.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnCreated.Visible = false;
            btnCreated.Click += btnCreated_Click;
            // 
            // btnImport
            // 
            btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImport.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnImport.Location = new System.Drawing.Point(605, 13);
            btnImport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnImport.MinimumSize = new System.Drawing.Size(1, 1);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(125, 44);
            btnImport.Symbol = 61508;
            btnImport.TabIndex = 9;
            btnImport.Tag = "orderinfo-import";
            btnImport.Text = "批量导入";
            btnImport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnImport.Visible = false;
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
            btnAdd.Tag = "orderinfo-add";
            btnAdd.Text = "新增工单";
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
            btnModify.Tag = "orderinfo-edit";
            btnModify.Text = "修改工单";
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
            btnDelete.Tag = "orderinfo-delete";
            btnDelete.Text = "删除工单";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(-58, 5);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 10;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
            // 
            // txtItemCode
            // 
            txtItemCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtItemCode.ButtonFillColor = System.Drawing.Color.White;
            txtItemCode.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtItemCode.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtItemCode.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtItemCode.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtItemCode.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemCode.FillColor2 = System.Drawing.Color.White;
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtItemCode.Location = new System.Drawing.Point(-484, 9);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtItemCode.Size = new System.Drawing.Size(204, 35);
            txtItemCode.Style = Sunny.UI.UIStyle.White;
            txtItemCode.StyleCustomMode = true;
            txtItemCode.TabIndex = 4;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtItemCode.Watermark = "物料编码";
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(30, -42);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 25;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.ShowJumpButton = false;
            pagination.Size = new System.Drawing.Size(1, 42);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 12;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderId, ItemCode, OrganizeName, MatType, OrganizeType, OrderType, TargetQty, OrderStatus, ProductType, CreatedQty, PackQty, Column1, Column2 });
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
            dataGridView.Location = new System.Drawing.Point(30, 127);
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
            dataGridView.TabIndex = 13;
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "OrderId";
            OrderId.HeaderText = "工单号";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Width = 200;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "ItemCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemCode.DefaultCellStyle = dataGridViewCellStyle3;
            ItemCode.HeaderText = "物料编码";
            ItemCode.MinimumWidth = 6;
            ItemCode.Name = "ItemCode";
            ItemCode.ReadOnly = true;
            ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ItemCode.Width = 200;
            // 
            // OrganizeName
            // 
            OrganizeName.DataPropertyName = "BasItemName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrganizeName.HeaderText = "物料名称";
            OrganizeName.MinimumWidth = 6;
            OrganizeName.Name = "OrganizeName";
            OrganizeName.ReadOnly = true;
            OrganizeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeName.Width = 250;
            // 
            // MatType
            // 
            MatType.DataPropertyName = "MatType";
            MatType.HeaderText = "物料类型";
            MatType.MinimumWidth = 6;
            MatType.Name = "MatType";
            MatType.ReadOnly = true;
            MatType.Width = 125;
            // 
            // OrganizeType
            // 
            OrganizeType.DataPropertyName = "BasItemDesc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.DefaultCellStyle = dataGridViewCellStyle5;
            OrganizeType.HeaderText = "规格型号";
            OrganizeType.MinimumWidth = 6;
            OrganizeType.Name = "OrganizeType";
            OrganizeType.ReadOnly = true;
            OrganizeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrganizeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrganizeType.Width = 300;
            // 
            // OrderType
            // 
            OrderType.DataPropertyName = "OrderType";
            OrderType.HeaderText = "工单类型";
            OrderType.MinimumWidth = 6;
            OrderType.Name = "OrderType";
            OrderType.ReadOnly = true;
            OrderType.Width = 125;
            // 
            // TargetQty
            // 
            TargetQty.DataPropertyName = "TargetQty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TargetQty.DefaultCellStyle = dataGridViewCellStyle6;
            TargetQty.HeaderText = "工单数量";
            TargetQty.MinimumWidth = 6;
            TargetQty.Name = "TargetQty";
            TargetQty.ReadOnly = true;
            TargetQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TargetQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            TargetQty.Width = 132;
            // 
            // OrderStatus
            // 
            OrderStatus.DataPropertyName = "OrderStatus";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            OrderStatus.DefaultCellStyle = dataGridViewCellStyle7;
            OrderStatus.HeaderText = "工单状态";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            OrderStatus.Width = 133;
            // 
            // ProductType
            // 
            ProductType.DataPropertyName = "ProductType";
            ProductType.HeaderText = "生产类型";
            ProductType.MinimumWidth = 6;
            ProductType.Name = "ProductType";
            ProductType.ReadOnly = true;
            ProductType.Visible = false;
            ProductType.Width = 120;
            // 
            // CreatedQty
            // 
            CreatedQty.DataPropertyName = "CreatedQty";
            CreatedQty.HeaderText = "生码数量";
            CreatedQty.MinimumWidth = 6;
            CreatedQty.Name = "CreatedQty";
            CreatedQty.ReadOnly = true;
            CreatedQty.Width = 132;
            // 
            // PackQty
            // 
            PackQty.DataPropertyName = "PackQty";
            PackQty.HeaderText = "包装数量";
            PackQty.MinimumWidth = 6;
            PackQty.Name = "PackQty";
            PackQty.ReadOnly = true;
            PackQty.Width = 132;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ReleaseDate";
            Column1.HeaderText = "下达日期";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 180;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Remark";
            Column2.HeaderText = "备注";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(cmbMatType);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(cmbState);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(btnQuery);
            uiPanel1.Controls.Add(txtOrderId);
            uiPanel1.Controls.Add(dpEnd);
            uiPanel1.Controls.Add(dpFrom);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(txtItemCode);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(30, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1, 58);
            uiPanel1.TabIndex = 14;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMatType
            // 
            cmbMatType.DataSource = null;
            cmbMatType.FillColor = System.Drawing.Color.White;
            cmbMatType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbMatType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbMatType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbMatType.Location = new System.Drawing.Point(835, 8);
            cmbMatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbMatType.MinimumSize = new System.Drawing.Size(63, 0);
            cmbMatType.Name = "cmbMatType";
            cmbMatType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbMatType.Size = new System.Drawing.Size(158, 36);
            cmbMatType.TabIndex = 18;
            cmbMatType.Text = "uiComboBox1";
            cmbMatType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel2.Location = new System.Drawing.Point(736, 12);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(94, 29);
            uiLabel2.TabIndex = 17;
            uiLabel2.Text = "物料类型";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbState
            // 
            cmbState.DataSource = null;
            cmbState.FillColor = System.Drawing.Color.White;
            cmbState.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            cmbState.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmbState.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cmbState.Location = new System.Drawing.Point(575, 8);
            cmbState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbState.MinimumSize = new System.Drawing.Size(63, 0);
            cmbState.Name = "cmbState";
            cmbState.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cmbState.Size = new System.Drawing.Size(158, 36);
            cmbState.TabIndex = 16;
            cmbState.Text = "uiComboBox1";
            cmbState.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel4.Location = new System.Drawing.Point(476, 12);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(94, 29);
            uiLabel4.TabIndex = 15;
            uiLabel4.Text = "工单状态";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtOrderId.ButtonFillColor = System.Drawing.Color.White;
            txtOrderId.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtOrderId.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtOrderId.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtOrderId.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtOrderId.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderId.FillColor2 = System.Drawing.Color.White;
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtOrderId.Location = new System.Drawing.Point(-272, 9);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtOrderId.Size = new System.Drawing.Size(204, 35);
            txtOrderId.Style = Sunny.UI.UIStyle.White;
            txtOrderId.StyleCustomMode = true;
            txtOrderId.TabIndex = 13;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtOrderId.Watermark = "工单号";
            // 
            // dpEnd
            // 
            dpEnd.FillColor = System.Drawing.Color.White;
            dpEnd.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpEnd.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpEnd.Location = new System.Drawing.Point(287, 8);
            dpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpEnd.MaxLength = 10;
            dpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            dpEnd.Name = "dpEnd";
            dpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpEnd.Size = new System.Drawing.Size(183, 36);
            dpEnd.SymbolDropDown = 61555;
            dpEnd.SymbolNormal = 61555;
            dpEnd.TabIndex = 11;
            dpEnd.Text = "2024-09-04";
            dpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpEnd.Value = new System.DateTime(2024, 9, 4, 1, 14, 9, 887);
            // 
            // dpFrom
            // 
            dpFrom.FillColor = System.Drawing.Color.White;
            dpFrom.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            dpFrom.Font = new System.Drawing.Font("微软雅黑", 12F);
            dpFrom.Location = new System.Drawing.Point(97, 8);
            dpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dpFrom.MaxLength = 10;
            dpFrom.MinimumSize = new System.Drawing.Size(63, 0);
            dpFrom.Name = "dpFrom";
            dpFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dpFrom.Size = new System.Drawing.Size(183, 36);
            dpFrom.SymbolDropDown = 61555;
            dpFrom.SymbolNormal = 61555;
            dpFrom.TabIndex = 10;
            dpFrom.Text = "2024-09-04";
            dpFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dpFrom.Value = new System.DateTime(2024, 9, 4, 1, 14, 9, 887);
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(4, 12);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(92, 29);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "下达日期";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(0, 0);
            Controls.Add(dataGridView);
            Controls.Add(pagination);
            Controls.Add(panel2);
            Controls.Add(uiPanel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "OrderPage";
            Text = "OrderPage";
            Initialize += OrderPage_Initialize;
            Load += OrderPage_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolButton btnImport;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnModify;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UITextBox txtItemCode;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UIDatePicker dpEnd;
        private Sunny.UI.UIDatePicker dpFrom;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cmbState;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UISymbolButton btnCreated;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UIComboBox cmbMatType;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
    }
}