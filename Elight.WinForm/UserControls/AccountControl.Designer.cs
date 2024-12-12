namespace Elight.WinForm.UserControls
{
    partial class AccountControl
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
            this.userAvatar = new Sunny.UI.UIAvatar();
            this.lblUserName = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // userAvatar
            // 
            this.userAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.userAvatar.FillColor = System.Drawing.Color.Transparent;
            this.userAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.userAvatar.ForeColor = System.Drawing.Color.White;
            this.userAvatar.Location = new System.Drawing.Point(0, 0);
            this.userAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(55, 60);
            this.userAvatar.Style = Sunny.UI.UIStyle.Custom;
            this.userAvatar.TabIndex = 2;
            this.userAvatar.Click += new System.EventHandler(this.userAvatar_Click);
            this.userAvatar.MouseEnter += new System.EventHandler(this.lblUserName_MouseEnter);
            this.userAvatar.MouseLeave += new System.EventHandler(this.userAvatar_Leave);
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(55, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(122, 60);
            this.lblUserName.Style = Sunny.UI.UIStyle.Custom;
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Admin";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Click += new System.EventHandler(this.userAvatar_Click);
            this.lblUserName.MouseEnter += new System.EventHandler(this.lblUserName_MouseEnter);
            this.lblUserName.MouseLeave += new System.EventHandler(this.userAvatar_Leave);
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.userAvatar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(177, 60);
            this.Load += new System.EventHandler(this.AccountControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIAvatar userAvatar;
        private Sunny.UI.UILabel lblUserName;
    }
}