namespace Elight.WinForm.Page.Logs
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
            this.txtKeywords = new Sunny.UI.UITextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToday = new Sunny.UI.UIButton();
            this.btnSevenDay = new Sunny.UI.UIButton();
            this.btnOneMonth = new Sunny.UI.UIButton();
            this.btnThreeMonth = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.btnExport = new Sunny.UI.UISymbolButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logDataGridView = new Sunny.UI.UIDataGridView();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagination = new Sunny.UI.UIPagination();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
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
            this.txtKeywords.Location = new System.Drawing.Point(18, 13);
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
            this.txtKeywords.Watermark = "日志信息";
            this.txtKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywords_KeyDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQuery);
            this.panel7.Controls.Add(this.txtKeywords);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1288, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 70);
            this.panel7.TabIndex = 3;
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
            this.btnQuery.TabIndex = 4;
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnToday);
            this.flowLayoutPanel1.Controls.Add(this.btnSevenDay);
            this.flowLayoutPanel1.Controls.Add(this.btnOneMonth);
            this.flowLayoutPanel1.Controls.Add(this.btnThreeMonth);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 70);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnToday
            // 
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FillColor = System.Drawing.Color.White;
            this.btnToday.FillColor2 = System.Drawing.Color.White;
            this.btnToday.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnToday.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnToday.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnToday.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnToday.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnToday.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnToday.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnToday.Location = new System.Drawing.Point(10, 13);
            this.btnToday.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnToday.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnToday.Name = "btnToday";
            this.btnToday.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnToday.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnToday.Size = new System.Drawing.Size(87, 44);
            this.btnToday.Style = Sunny.UI.UIStyle.White;
            this.btnToday.StyleCustomMode = true;
            this.btnToday.TabIndex = 11;
            this.btnToday.Text = "今天";
            this.btnToday.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnSevenDay
            // 
            this.btnSevenDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSevenDay.FillColor = System.Drawing.Color.White;
            this.btnSevenDay.FillColor2 = System.Drawing.Color.White;
            this.btnSevenDay.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSevenDay.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSevenDay.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSevenDay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSevenDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnSevenDay.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSevenDay.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnSevenDay.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnSevenDay.Location = new System.Drawing.Point(107, 13);
            this.btnSevenDay.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnSevenDay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSevenDay.Name = "btnSevenDay";
            this.btnSevenDay.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnSevenDay.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSevenDay.Size = new System.Drawing.Size(87, 44);
            this.btnSevenDay.Style = Sunny.UI.UIStyle.White;
            this.btnSevenDay.StyleCustomMode = true;
            this.btnSevenDay.TabIndex = 12;
            this.btnSevenDay.Text = "近7天";
            this.btnSevenDay.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSevenDay.Click += new System.EventHandler(this.btnSevenDay_Click);
            // 
            // btnOneMonth
            // 
            this.btnOneMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneMonth.FillColor = System.Drawing.Color.White;
            this.btnOneMonth.FillColor2 = System.Drawing.Color.White;
            this.btnOneMonth.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnOneMonth.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnOneMonth.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnOneMonth.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOneMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnOneMonth.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOneMonth.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnOneMonth.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnOneMonth.Location = new System.Drawing.Point(204, 13);
            this.btnOneMonth.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnOneMonth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOneMonth.Name = "btnOneMonth";
            this.btnOneMonth.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnOneMonth.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnOneMonth.Size = new System.Drawing.Size(87, 44);
            this.btnOneMonth.Style = Sunny.UI.UIStyle.White;
            this.btnOneMonth.StyleCustomMode = true;
            this.btnOneMonth.TabIndex = 13;
            this.btnOneMonth.Text = "近1月";
            this.btnOneMonth.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOneMonth.Click += new System.EventHandler(this.btnOneMonth_Click);
            // 
            // btnThreeMonth
            // 
            this.btnThreeMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThreeMonth.FillColor = System.Drawing.Color.White;
            this.btnThreeMonth.FillColor2 = System.Drawing.Color.White;
            this.btnThreeMonth.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnThreeMonth.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnThreeMonth.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnThreeMonth.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnThreeMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnThreeMonth.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThreeMonth.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnThreeMonth.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnThreeMonth.Location = new System.Drawing.Point(301, 13);
            this.btnThreeMonth.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnThreeMonth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThreeMonth.Name = "btnThreeMonth";
            this.btnThreeMonth.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnThreeMonth.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnThreeMonth.Size = new System.Drawing.Size(87, 44);
            this.btnThreeMonth.Style = Sunny.UI.UIStyle.White;
            this.btnThreeMonth.StyleCustomMode = true;
            this.btnThreeMonth.TabIndex = 14;
            this.btnThreeMonth.Text = "近3月";
            this.btnThreeMonth.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnThreeMonth.Click += new System.EventHandler(this.btnThreeMonth_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(398, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.Size = new System.Drawing.Size(125, 44);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.Symbol = 61460;
            this.btnDelete.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnDelete.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDelete.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Tag = "error_log_delete";
            this.btnDelete.Text = "删除日志";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.White;
            this.btnExport.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnExport.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnExport.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnExport.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnExport.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnExport.Location = new System.Drawing.Point(533, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(10, 13, 0, 3);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnExport.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.Size = new System.Drawing.Size(125, 44);
            this.btnExport.Style = Sunny.UI.UIStyle.Custom;
            this.btnExport.Symbol = 61677;
            this.btnExport.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnExport.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnExport.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnExport.TabIndex = 15;
            this.btnExport.Tag = "error_log_export";
            this.btnExport.Text = "导出数据";
            this.btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1626, 902);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(30, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1566, 902);
            this.panel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logDataGridView);
            this.panel1.Controls.Add(this.pagination);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 762);
            this.panel1.TabIndex = 16;
            // 
            // logDataGridView
            // 
            this.logDataGridView.AllowUserToAddRows = false;
            this.logDataGridView.AllowUserToDeleteRows = false;
            this.logDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.logDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.logDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.logDataGridView.ColumnHeadersHeight = 32;
            this.logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogId,
            this.CreateTime,
            this.ThreadId,
            this.Message});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.logDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDataGridView.EnableHeadersVisualStyles = false;
            this.logDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.logDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.logDataGridView.Location = new System.Drawing.Point(0, 0);
            this.logDataGridView.MultiSelect = false;
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.ReadOnly = true;
            this.logDataGridView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.logDataGridView.RowHeadersVisible = false;
            this.logDataGridView.RowHeadersWidth = 51;
            this.logDataGridView.RowHeight = 29;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.logDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.logDataGridView.RowTemplate.Height = 29;
            this.logDataGridView.SelectedIndex = -1;
            this.logDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logDataGridView.ShowGridLine = true;
            this.logDataGridView.Size = new System.Drawing.Size(1566, 720);
            this.logDataGridView.StripeOddColor = System.Drawing.Color.White;
            this.logDataGridView.Style = Sunny.UI.UIStyle.White;
            this.logDataGridView.StyleCustomMode = true;
            this.logDataGridView.TabIndex = 15;
            // 
            // LogId
            // 
            this.LogId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LogId.DataPropertyName = "Id";
            this.LogId.HeaderText = "日志编号";
            this.LogId.MinimumWidth = 6;
            this.LogId.Name = "LogId";
            this.LogId.ReadOnly = true;
            this.LogId.Width = 120;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss.fff";
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreateTime.HeaderText = "时间";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 80;
            // 
            // ThreadId
            // 
            this.ThreadId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThreadId.DataPropertyName = "ThreadId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ThreadId.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThreadId.HeaderText = "线程号";
            this.ThreadId.MinimumWidth = 6;
            this.ThreadId.Name = "ThreadId";
            this.ThreadId.ReadOnly = true;
            this.ThreadId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThreadId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThreadId.Width = 77;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Message.DefaultCellStyle = dataGridViewCellStyle5;
            this.Message.HeaderText = "日志信息";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pagination
            // 
            this.pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination.FillColor = System.Drawing.Color.White;
            this.pagination.FillColor2 = System.Drawing.Color.White;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(0, 720);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 5;
            this.pagination.PageSize = 10;
            this.pagination.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.Size = new System.Drawing.Size(1566, 42);
            this.pagination.Style = Sunny.UI.UIStyle.White;
            this.pagination.StyleCustomMode = true;
            this.pagination.TabIndex = 14;
            this.pagination.Text = "uiPagination1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1566, 70);
            this.panel6.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 832);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1566, 70);
            this.panel8.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1596, 0);
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
            // ErrorLogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1626, 902);
            this.Controls.Add(this.panel2);
            this.Name = "ErrorLogPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Symbol = 61607;
            this.Text = "操作日志";
            this.Initialize += new System.EventHandler(this.OperationLogPage_Initialize);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

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