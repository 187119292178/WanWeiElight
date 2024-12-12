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
            lblTitle = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            uiNavMenu1 = new Sunny.UI.UINavMenu();
            topPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Aside
            // 
            Aside.LineColor = System.Drawing.Color.Black;
            Aside.Location = new System.Drawing.Point(0, 115);
            Aside.ShowOneNode = true;
            Aside.Size = new System.Drawing.Size(210, 653);
            Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.Transparent;
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(panel1);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 35);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1366, 80);
            topPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("微软雅黑", 20F);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(210, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(1156, 80);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "条码追溯管理系统";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(210, 80);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(uiNavMenu1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1366, 653);
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
            uiNavMenu1.Size = new System.Drawing.Size(246, 653);
            uiNavMenu1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1366, 768);
            Controls.Add(panel3);
            Controls.Add(topPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsForbidAltF4 = true;
            MaximizeBox = false;
            Movable = false;
            Name = "MainForm";
            ShowTitleIcon = true;
            Text = "条码打印追溯系统";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}
