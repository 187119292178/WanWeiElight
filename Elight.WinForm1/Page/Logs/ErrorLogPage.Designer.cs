namespace MES.WinForm.Page.Logs
{
    partial class ErrorLogPage
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
            txtKeywords = new Sunny.UI.UITextBox();
            panel7 = new System.Windows.Forms.Panel();
            btnQuery = new Sunny.UI.UISymbolButton();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnToday = new Sunny.UI.UIButton();
            btnSevenDay = new Sunny.UI.UIButton();
            btnOneMonth = new Sunny.UI.UIButton();
            btnThreeMonth = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnExport = new Sunny.UI.UISymbolButton();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            logDataGridView = new Sunny.UI.UIDataGridView();
            LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagination = new Sunny.UI.UIPagination();
            panel6 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logDataGridView).BeginInit();
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
            txtKeywords.Location = new System.Drawing.Point(18, 13);
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
            txtKeywords.Watermark = "日志信息";
            txtKeywords.KeyDown += txtKeywords_KeyDown;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnQuery);
            panel7.Controls.Add(txtKeywords);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(1163, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(278, 70);
            panel7.TabIndex = 3;
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
            btnQuery.TabIndex = 4;
            btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQuery.Click += btnQuery_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnToday);
            flowLayoutPanel1.Controls.Add(btnSevenDay);
            flowLayoutPanel1.Controls.Add(btnOneMonth);
            flowLayoutPanel1.Controls.Add(btnThreeMonth);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnExport);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1163, 70);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnToday
            // 
            btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToday.FillColor = System.Drawing.Color.White;
            btnToday.FillColor2 = System.Drawing.Color.White;
            btnToday.FillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnToday.FillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnToday.FillSelectedColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnToday.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnToday.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnToday.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnToday.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnToday.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnToday.Location = new System.Drawing.Point(10, 13);
            btnToday.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnToday.MinimumSize = new System.Drawing.Size(1, 1);
            btnToday.Name = "btnToday";
            btnToday.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnToday.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnToday.Size = new System.Drawing.Size(87, 44);
            btnToday.Style = Sunny.UI.UIStyle.White;
            btnToday.StyleCustomMode = true;
            btnToday.TabIndex = 11;
            btnToday.Text = "今天";
            btnToday.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnToday.Click += btnToday_Click;
            // 
            // btnSevenDay
            // 
            btnSevenDay.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSevenDay.FillColor = System.Drawing.Color.White;
            btnSevenDay.FillColor2 = System.Drawing.Color.White;
            btnSevenDay.FillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnSevenDay.FillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnSevenDay.FillSelectedColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnSevenDay.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnSevenDay.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnSevenDay.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnSevenDay.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnSevenDay.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnSevenDay.Location = new System.Drawing.Point(107, 13);
            btnSevenDay.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnSevenDay.MinimumSize = new System.Drawing.Size(1, 1);
            btnSevenDay.Name = "btnSevenDay";
            btnSevenDay.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnSevenDay.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnSevenDay.Size = new System.Drawing.Size(87, 44);
            btnSevenDay.Style = Sunny.UI.UIStyle.White;
            btnSevenDay.StyleCustomMode = true;
            btnSevenDay.TabIndex = 12;
            btnSevenDay.Text = "近7天";
            btnSevenDay.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnSevenDay.Click += btnSevenDay_Click;
            // 
            // btnOneMonth
            // 
            btnOneMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOneMonth.FillColor = System.Drawing.Color.White;
            btnOneMonth.FillColor2 = System.Drawing.Color.White;
            btnOneMonth.FillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnOneMonth.FillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnOneMonth.FillSelectedColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnOneMonth.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnOneMonth.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnOneMonth.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnOneMonth.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnOneMonth.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnOneMonth.Location = new System.Drawing.Point(204, 13);
            btnOneMonth.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnOneMonth.MinimumSize = new System.Drawing.Size(1, 1);
            btnOneMonth.Name = "btnOneMonth";
            btnOneMonth.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnOneMonth.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnOneMonth.Size = new System.Drawing.Size(87, 44);
            btnOneMonth.Style = Sunny.UI.UIStyle.White;
            btnOneMonth.StyleCustomMode = true;
            btnOneMonth.TabIndex = 13;
            btnOneMonth.Text = "近1月";
            btnOneMonth.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnOneMonth.Click += btnOneMonth_Click;
            // 
            // btnThreeMonth
            // 
            btnThreeMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            btnThreeMonth.FillColor = System.Drawing.Color.White;
            btnThreeMonth.FillColor2 = System.Drawing.Color.White;
            btnThreeMonth.FillHoverColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnThreeMonth.FillPressColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnThreeMonth.FillSelectedColor = System.Drawing.Color.FromArgb(235, 243, 255);
            btnThreeMonth.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnThreeMonth.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnThreeMonth.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnThreeMonth.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnThreeMonth.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnThreeMonth.Location = new System.Drawing.Point(301, 13);
            btnThreeMonth.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnThreeMonth.MinimumSize = new System.Drawing.Size(1, 1);
            btnThreeMonth.Name = "btnThreeMonth";
            btnThreeMonth.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnThreeMonth.RectHoverColor = System.Drawing.Color.FromArgb(197, 222, 255);
            btnThreeMonth.Size = new System.Drawing.Size(87, 44);
            btnThreeMonth.Style = Sunny.UI.UIStyle.White;
            btnThreeMonth.StyleCustomMode = true;
            btnThreeMonth.TabIndex = 14;
            btnThreeMonth.Text = "近3月";
            btnThreeMonth.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnThreeMonth.Click += btnThreeMonth_Click;
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
            btnDelete.Location = new System.Drawing.Point(398, 13);
            btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.Size = new System.Drawing.Size(125, 44);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnDelete.TabIndex = 10;
            btnDelete.Tag = "error_log_delete";
            btnDelete.Text = "删除日志";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExport.FillColor = System.Drawing.Color.White;
            btnExport.FillHoverColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnExport.FillPressColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnExport.FillSelectedColor = System.Drawing.Color.FromArgb(245, 244, 245);
            btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnExport.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnExport.ForeHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnExport.ForePressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnExport.ForeSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnExport.Location = new System.Drawing.Point(533, 13);
            btnExport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            btnExport.Name = "btnExport";
            btnExport.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            btnExport.RectHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnExport.Size = new System.Drawing.Size(125, 44);
            btnExport.Style = Sunny.UI.UIStyle.Custom;
            btnExport.Symbol = 61677;
            btnExport.SymbolColor = System.Drawing.Color.FromArgb(96, 98, 102);
            btnExport.SymbolHoverColor = System.Drawing.Color.FromArgb(80, 160, 255);
            btnExport.SymbolPressColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnExport.SymbolSelectedColor = System.Drawing.Color.FromArgb(74, 131, 229);
            btnExport.TabIndex = 15;
            btnExport.Tag = "error_log_export";
            btnExport.Text = "导出数据";
            btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnExport.Visible = false;
            btnExport.Click += btnExport_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1501, 430);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel8);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(30, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1441, 430);
            panel5.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(logDataGridView);
            panel1.Controls.Add(pagination);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1441, 290);
            panel1.TabIndex = 16;
            // 
            // logDataGridView
            // 
            logDataGridView.AllowUserToAddRows = false;
            logDataGridView.AllowUserToDeleteRows = false;
            logDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            logDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            logDataGridView.BackgroundColor = System.Drawing.Color.White;
            logDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(96, 98, 102);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            logDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            logDataGridView.ColumnHeadersHeight = 32;
            logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            logDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { LogId, CreateTime, ThreadId, Message });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            logDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            logDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            logDataGridView.EnableHeadersVisualStyles = false;
            logDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            logDataGridView.GridColor = System.Drawing.Color.FromArgb(216, 219, 227);
            logDataGridView.Location = new System.Drawing.Point(0, 0);
            logDataGridView.MultiSelect = false;
            logDataGridView.Name = "logDataGridView";
            logDataGridView.ReadOnly = true;
            logDataGridView.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            logDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            logDataGridView.RowHeadersVisible = false;
            logDataGridView.RowHeadersWidth = 51;
            logDataGridView.RowHeight = 29;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            logDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            logDataGridView.RowTemplate.Height = 29;
            logDataGridView.SelectedIndex = -1;
            logDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            logDataGridView.ShowGridLine = true;
            logDataGridView.Size = new System.Drawing.Size(1441, 248);
            logDataGridView.StripeOddColor = System.Drawing.Color.White;
            logDataGridView.Style = Sunny.UI.UIStyle.White;
            logDataGridView.StyleCustomMode = true;
            logDataGridView.TabIndex = 15;
            // 
            // LogId
            // 
            LogId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            LogId.DataPropertyName = "Id";
            LogId.HeaderText = "日志编号";
            LogId.MinimumWidth = 6;
            LogId.Name = "LogId";
            LogId.ReadOnly = true;
            LogId.Width = 98;
            // 
            // CreateTime
            // 
            CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss.fff";
            CreateTime.DefaultCellStyle = dataGridViewCellStyle3;
            CreateTime.HeaderText = "时间";
            CreateTime.MinimumWidth = 6;
            CreateTime.Name = "CreateTime";
            CreateTime.ReadOnly = true;
            CreateTime.Width = 66;
            // 
            // ThreadId
            // 
            ThreadId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ThreadId.DataPropertyName = "ThreadId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ThreadId.DefaultCellStyle = dataGridViewCellStyle4;
            ThreadId.HeaderText = "线程号";
            ThreadId.MinimumWidth = 6;
            ThreadId.Name = "ThreadId";
            ThreadId.ReadOnly = true;
            ThreadId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ThreadId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ThreadId.Width = 63;
            // 
            // Message
            // 
            Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Message.DataPropertyName = "Message";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Message.DefaultCellStyle = dataGridViewCellStyle5;
            Message.HeaderText = "日志信息";
            Message.MinimumWidth = 6;
            Message.Name = "Message";
            Message.ReadOnly = true;
            Message.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pagination
            // 
            pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination.FillColor = System.Drawing.Color.White;
            pagination.FillColor2 = System.Drawing.Color.White;
            pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            pagination.Location = new System.Drawing.Point(0, 248);
            pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pagination.MinimumSize = new System.Drawing.Size(1, 1);
            pagination.Name = "pagination";
            pagination.PagerCount = 5;
            pagination.PageSize = 10;
            pagination.RectColor = System.Drawing.Color.FromArgb(216, 219, 227);
            pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            pagination.Size = new System.Drawing.Size(1441, 42);
            pagination.Style = Sunny.UI.UIStyle.White;
            pagination.StyleCustomMode = true;
            pagination.TabIndex = 14;
            pagination.Text = "uiPagination1";
            pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pagination.PageChanged += pagination_PageChanged;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(panel7);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(1441, 70);
            panel6.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel8.Location = new System.Drawing.Point(0, 360);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(1441, 70);
            panel8.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(1471, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 430);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 430);
            panel3.TabIndex = 4;
            // 
            // ErrorLogPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(1501, 430);
            Controls.Add(panel2);
            Name = "ErrorLogPage";
            Style = Sunny.UI.UIStyle.Custom;
            StyleCustomMode = true;
            Symbol = 61607;
            Text = "操作日志";
            Initialize += OperationLogPage_Initialize;
            panel7.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logDataGridView).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtKeywords;
        private System.Windows.Forms.Panel panel7; 
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UIButton btnToday;
        private Sunny.UI.UIButton btnSevenDay;
        private Sunny.UI.UIButton btnOneMonth;
        private Sunny.UI.UIButton btnThreeMonth;
        private Sunny.UI.UISymbolButton btnDelete;
        private System.Windows.Forms.Panel panel8;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDataGridView logDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private Sunny.UI.UISymbolButton btnExport;
        private System.Windows.Forms.Panel panel1;
    }
}