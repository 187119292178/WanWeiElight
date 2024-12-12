using Elight.Utility.Other;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys
{
    public partial class BaseSubForm : UIForm
    {
        public BaseSubForm()
        {
            InitializeComponent();
        }

        public event EventHandler OnFormClose;

        /// <summary>
        ///  标题
        /// </summary>
        public string Title
        {
            get
            {
                return uiLabel15.Text;
            }
            set
            {
                uiLabel15.Text = value;
            }
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {
            OnFormClose?.Invoke(this, EventArgs.Empty);
            FormHelper.subForm = null;
            this.Close();
        }
        private Point mPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void uiSymbolLabel1_MouseEnter(object sender, EventArgs e)
        {
            uiSymbolLabel1.BackColor = Color.FromArgb(231, 231, 231);
        }

        private void uiSymbolLabel1_MouseLeave(object sender, EventArgs e)
        {
            uiSymbolLabel1.BackColor = Color.Transparent;
        }
    }
}
