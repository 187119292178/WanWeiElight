namespace Elight.WinForm.Page
{
    partial class DefaultPage
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
            uiLabel1 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLabel1.Location = new System.Drawing.Point(172, 108);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(600, 128);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "您好，欢迎使用条码打印追溯系统";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DefaultPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 241, 243);
            ClientSize = new System.Drawing.Size(1436, 726);
            Controls.Add(uiLabel1);
            Name = "DefaultPage";
            Style = Sunny.UI.UIStyle.Custom;
            Text = "EmptyPage";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
    }
}