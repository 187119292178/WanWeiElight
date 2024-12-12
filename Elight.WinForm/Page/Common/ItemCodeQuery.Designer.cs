namespace Elight.WinForm.Page.Common
{
    partial class ItemCodeQuery
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
            uiPanel1 = new Sunny.UI.UIPanel();
            btnSelected = new Sunny.UI.UIButton();
            btnQuery = new Sunny.UI.UISymbolButton();
            txtkey = new Sunny.UI.UITextBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            dataGridView = new Sunny.UI.UIDataGridView();
            pagination = new Sunny.UI.UIPagination();
            ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MatModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PackQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnSelected);
            uiPanel1.Controls.Add(btnQuery);
            uiPanel1.Controls.Add(txtkey);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(0, 35);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1127, 63);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelected
            // 
            btnSelected.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSelected.Location = new System.Drawing.Point(881, 9);
            btnSelected.MinimumSize = new System.Drawing.Size(1, 1);
            btnSelected.Name = "btnSelected";
            btnSelected.Size = new System.Drawing.Size(103, 42);
            btnSelected.TabIndex = 89;
            btnSelected.Text = "选择";
            btnSelected.Click += btnSelected_Click;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQuery.Location = new System.Drawing.Point(379, 8);
            btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(43, 43);
            btnQuery.StyleCustomMode = true;
            btnQuery.Symbol = 61442;
            btnQuery.SymbolSize = 30;
            btnQuery.TabIndex = 14;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
            // 
            // txtkey
            // 
            txtkey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtkey.ButtonFillColor = System.Drawing.Color.White;
            txtkey.ButtonFillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtkey.ButtonFillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtkey.ButtonForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            txtkey.ButtonForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtkey.ButtonForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            txtkey.ButtonRectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtkey.ButtonRectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            txtkey.ButtonSymbol = 61761;
            txtkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtkey.FillColor2 = System.Drawing.Color.White;
            txtkey.Font = new System.Drawing.Font("微软雅黑", 12F);
            txtkey.Location = new System.Drawing.Point(29, 12);
            txtkey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtkey.Maximum = 2147483647D;
            txtkey.Minimum = -2147483648D;
            txtkey.MinimumSize = new System.Drawing.Size(1, 16);
            txtkey.Name = "txtkey";
            txtkey.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            txtkey.Size = new System.Drawing.Size(326, 35);
            txtkey.Style = Sunny.UI.UIStyle.White;
            txtkey.StyleCustomMode = true;
            txtkey.TabIndex = 15;
            txtkey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtkey.Watermark = "物料编码或名称";
            txtkey.KeyDown += txtkey_KeyDown;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(dataGridView);
            uiPanel2.Controls.Add(pagination);
            uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel2.Location = new System.Drawing.Point(0, 98);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new System.Drawing.Size(1127, 445);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ItemCode, ItemName, MatModel, ItemDesc, MatType, IsEnabled, PackQty });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView.Location = new System.Drawing.Point(0, 0);
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
            dataGridView.Size = new System.Drawing.Size(1127, 403);
            dataGridView.StyleCustomMode = true;
            dataGridView.TabIndex = 15;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 403);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 15;
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.Size = new System.Drawing.Size(1127, 42);
            pagination.Style = Sunny.UI.UIStyle.Custom;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 14;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            // 
            // ItemCode
            // 
            ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemName.DefaultCellStyle = dataGridViewCellStyle4;
            ItemName.HeaderText = "物料名称";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MatModel
            // 
            MatModel.DataPropertyName = "MatModel";
            MatModel.HeaderText = "机型代码";
            MatModel.MinimumWidth = 6;
            MatModel.Name = "MatModel";
            MatModel.ReadOnly = true;
            MatModel.Visible = false;
            MatModel.Width = 125;
            // 
            // ItemDesc
            // 
            ItemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemDesc.DataPropertyName = "ItemDesc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ItemDesc.DefaultCellStyle = dataGridViewCellStyle5;
            ItemDesc.HeaderText = "规格型号";
            ItemDesc.MinimumWidth = 6;
            ItemDesc.Name = "ItemDesc";
            ItemDesc.ReadOnly = true;
            ItemDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ItemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MatType
            // 
            MatType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            MatType.DataPropertyName = "MatType";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            MatType.DefaultCellStyle = dataGridViewCellStyle6;
            MatType.HeaderText = "物料类型";
            MatType.MinimumWidth = 6;
            MatType.Name = "MatType";
            MatType.ReadOnly = true;
            MatType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            MatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsEnabled
            // 
            IsEnabled.DataPropertyName = "IsEnabled";
            IsEnabled.HeaderText = "是否可用";
            IsEnabled.MinimumWidth = 6;
            IsEnabled.Name = "IsEnabled";
            IsEnabled.ReadOnly = true;
            IsEnabled.Width = 125;
            // 
            // PackQty
            // 
            PackQty.DataPropertyName = "PackQty";
            PackQty.HeaderText = "包装数量";
            PackQty.MinimumWidth = 6;
            PackQty.Name = "PackQty";
            PackQty.ReadOnly = true;
            PackQty.Width = 80;
            // 
            // ItemCodeQuery
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1127, 543);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemCodeQuery";
            Text = "物料查询";
            Load += ItemCodeQuery_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtkey;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIButton btnSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackQty;
    }
}