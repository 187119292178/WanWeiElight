namespace Elight.WinForm.Page.Sys
{
    partial class BaseSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSubForm));
            uiPanel1 = new Sunny.UI.UIPanel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            uiLabel15 = new Sunny.UI.UILabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(panel1);
            uiPanel1.Controls.Add(panel2);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            uiPanel1.FillColor = System.Drawing.Color.FromArgb(235, 241, 243);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(0, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = System.Drawing.Color.Silver;
            uiPanel1.Size = new System.Drawing.Size(686, 530);
            uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            uiPanel1.StyleCustomMode = true;
            uiPanel1.TabIndex = 6;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(686, 487);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(216, 219, 227);
            panel2.Controls.Add(uiLabel15);
            panel2.Controls.Add(uiSymbolLabel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(686, 43);
            panel2.TabIndex = 7;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // uiLabel15
            // 
            uiLabel15.Dock = System.Windows.Forms.DockStyle.Fill;
            uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel15.Location = new System.Drawing.Point(0, 0);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new System.Drawing.Size(641, 43);
            uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            uiLabel15.TabIndex = 1;
            uiLabel15.Text = "标题";
            uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            uiLabel15.MouseDown += panel2_MouseDown;
            uiLabel15.MouseMove += panel2_MouseMove;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiSymbolLabel1.Location = new System.Drawing.Point(641, 0);
            uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            uiSymbolLabel1.Size = new System.Drawing.Size(45, 43);
            uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolLabel1.Symbol = 77;
            uiSymbolLabel1.SymbolSize = 60;
            uiSymbolLabel1.TabIndex = 0;
            uiSymbolLabel1.Click += uiSymbolLabel1_Click;
            uiSymbolLabel1.MouseEnter += uiSymbolLabel1_MouseEnter;
            uiSymbolLabel1.MouseLeave += uiSymbolLabel1_MouseLeave;
            // 
            // BaseSubForm
            // 
            AllowShowTitle = false;
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(686, 530);
            Controls.Add(uiPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BaseSubForm";
            Padding = new System.Windows.Forms.Padding(0);
            ShowTitle = false;
            ShowTitleIcon = true;
            Text = "新增用户";
            TopMost = true;
            uiPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}