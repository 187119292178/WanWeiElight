namespace Elight.WinForm.UserControls
{
    partial class ProgressForm
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
            this.uiProcessBar1 = new Sunny.UI.UIProcessBar();
            this.SuspendLayout();
            // 
            // uiProcessBar1
            // 
            this.uiProcessBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiProcessBar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiProcessBar1.Location = new System.Drawing.Point(0, 0);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(70, 3);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.Size = new System.Drawing.Size(704, 41);
            this.uiProcessBar1.TabIndex = 0;
            this.uiProcessBar1.Text = "uiProcessBar1";
            // 
            // ProgressForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 41);
            this.ControlBox = false;
            this.Controls.Add(this.uiProcessBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ProgressForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "下载进度";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIProcessBar uiProcessBar1;
    }
}