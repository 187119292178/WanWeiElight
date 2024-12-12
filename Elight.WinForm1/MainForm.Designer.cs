using Elight.WinForm.UserControls;

namespace Elight.WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topPanel = new System.Windows.Forms.Panel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            lblTitle = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new AccountControl();
            panel3 = new System.Windows.Forms.Panel();
            uiNavMenu1 = new Sunny.UI.UINavMenu();
            topPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Aside
            // 
            Aside.LineColor = System.Drawing.Color.Black;
            Aside.Location = new System.Drawing.Point(0, 80);
            Aside.ShowOneNode = true;
            Aside.Size = new System.Drawing.Size(216, 688);
            Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.Transparent;
            topPanel.Controls.Add(uiSymbolLabel1);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(panel1);
            topPanel.Controls.Add(panel2);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 35);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1366, 45);
            topPanel.TabIndex = 0;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new System.Drawing.Point(133, 3);
            uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            uiSymbolLabel1.Size = new System.Drawing.Size(39, 36);
            uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolLabel1.Symbol = 61499;
            uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            uiSymbolLabel1.TabIndex = 9;
            uiSymbolLabel1.Click += uiSymbolLabel1_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("微软雅黑", 20F);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(130, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(1061, 45);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "XXX管理系统";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.logo2;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(130, 45);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(1191, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(175, 45);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(uiNavMenu1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1366, 688);
            panel3.TabIndex = 1;
            // 
            // uiNavMenu1
            // 
            uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            uiNavMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiNavMenu1.FullRowSelect = true;
            uiNavMenu1.ItemHeight = 50;
            uiNavMenu1.Location = new System.Drawing.Point(0, 0);
            uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavMenu1.Name = "uiNavMenu1";
            uiNavMenu1.ShowLines = false;
            uiNavMenu1.Size = new System.Drawing.Size(246, 688);
            uiNavMenu1.Style = Sunny.UI.UIStyle.Custom;
            uiNavMenu1.TabIndex = 0;
            uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1366, 768);
            Controls.Add(panel3);
            Controls.Add(topPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsForbidAltF4 = true;
            MaximizeBox = false;
            Movable = false;
            Name = "MainForm";
            RectColor = System.Drawing.Color.Gray;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "XXX管理系统";
            TitleColor = System.Drawing.Color.Gray;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Selecting += MainForm_Selecting;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Controls.SetChildIndex(topPanel, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(Aside, 0);
            topPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UINavMenu uiNavMenu1;
        private System.Windows.Forms.Panel panel1;
        private AccountControl panel2;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
