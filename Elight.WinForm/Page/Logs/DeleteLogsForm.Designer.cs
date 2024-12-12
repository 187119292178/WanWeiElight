namespace Elight.WinForm.Page.Logs
{
    partial class DeleteLogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteLogsForm));
            this.mainPanel = new Sunny.UI.UIPanel();
            this.uiRadioButton4 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton3 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolLabel();
            this.mainPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.uiRadioButton4);
            this.mainPanel.Controls.Add(this.uiRadioButton3);
            this.mainPanel.Controls.Add(this.uiRadioButton2);
            this.mainPanel.Controls.Add(this.uiRadioButton1);
            this.mainPanel.Controls.Add(this.uiPanel2);
            this.mainPanel.Controls.Add(this.btnConfirm);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.White;
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.mainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainPanel.Location = new System.Drawing.Point(0, 43);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.mainPanel.Size = new System.Drawing.Size(565, 314);
            this.mainPanel.Style = Sunny.UI.UIStyle.Custom;
            this.mainPanel.StyleCustomMode = true;
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Text = null;
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiRadioButton4
            // 
            this.uiRadioButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton4.Location = new System.Drawing.Point(282, 169);
            this.uiRadioButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton4.Name = "uiRadioButton4";
            this.uiRadioButton4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton4.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiRadioButton4.Size = new System.Drawing.Size(178, 38);
            this.uiRadioButton4.Style = Sunny.UI.UIStyle.White;
            this.uiRadioButton4.StyleCustomMode = true;
            this.uiRadioButton4.TabIndex = 4;
            this.uiRadioButton4.Text = "全部清空";
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton3.Location = new System.Drawing.Point(282, 112);
            this.uiRadioButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton3.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiRadioButton3.Size = new System.Drawing.Size(178, 38);
            this.uiRadioButton3.Style = Sunny.UI.UIStyle.White;
            this.uiRadioButton3.StyleCustomMode = true;
            this.uiRadioButton3.TabIndex = 2;
            this.uiRadioButton3.Text = "保留最近7天";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton2.Location = new System.Drawing.Point(57, 169);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiRadioButton2.Size = new System.Drawing.Size(178, 38);
            this.uiRadioButton2.Style = Sunny.UI.UIStyle.White;
            this.uiRadioButton2.StyleCustomMode = true;
            this.uiRadioButton2.TabIndex = 3;
            this.uiRadioButton2.Text = "保留最近3个月";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton1.Location = new System.Drawing.Point(57, 112);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiRadioButton1.Size = new System.Drawing.Size(178, 38);
            this.uiRadioButton1.Style = Sunny.UI.UIStyle.White;
            this.uiRadioButton1.StyleCustomMode = true;
            this.uiRadioButton1.TabIndex = 1;
            this.uiRadioButton1.Text = "保留最近1个月";
            // 
            // uiPanel2
            // 
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel2.Location = new System.Drawing.Point(57, 32);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel2.Size = new System.Drawing.Size(425, 43);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel2.StyleCustomMode = true;
            this.uiPanel2.TabIndex = 15;
            this.uiPanel2.Text = "提醒：日志删除后无法恢复，请谨慎操作。";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.White;
            this.btnConfirm.FillColor2 = System.Drawing.Color.White;
            this.btnConfirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnConfirm.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnConfirm.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnConfirm.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnConfirm.Location = new System.Drawing.Point(417, 247);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnConfirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnConfirm.Size = new System.Drawing.Size(125, 44);
            this.btnConfirm.Style = Sunny.UI.UIStyle.White;
            this.btnConfirm.StyleCustomMode = true;
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Controls.Add(this.btnClose);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(565, 43);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 43);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "删除日志";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(520, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 43);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.Symbol = 77;
            this.btnClose.SymbolSize = 60;
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // DeleteLogsForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 357);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteLogsForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.ShowTitle = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "新增用户";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.TopMost = true;
            this.mainPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion 
        private System.Windows.Forms.Panel titlePanel;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UISymbolLabel btnClose;
        private Sunny.UI.UIPanel mainPanel;
        private Sunny.UI.UIRadioButton uiRadioButton4;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnConfirm;
    }
}