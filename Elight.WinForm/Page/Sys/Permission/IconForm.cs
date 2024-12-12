using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys.Permission
{
    public partial class IconForm : UIForm
    {
        public IconForm()
        {
            InitializeComponent();
        }

        #region 标题栏
        private void btnClose_Click(object sender, EventArgs e)
        {
            FormHelper.subForm = null;
            this.Close();
        }
        private Point mPoint;
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 231, 231);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }
        #endregion

        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }



        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private readonly ConcurrentQueue<Label> FontAwesomeV4Labels = new ConcurrentQueue<Label>();

        /// <summary>
        /// 后台加载Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (KeyValuePair<string, int> keyValue in IconDict.MyIconDict)
            {
                FontAwesomeV4Labels.Enqueue(CreateLabel(keyValue.Key, keyValue.Value));
            }
        }


        /// <summary>
        /// 创建Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        private Label CreateLabel(string name, int icon)
        {
            Label lbl = new Label
            {
                Name = name,
                AutoSize = false,
                Size = new Size(45, 45),
                ForeColor = UIColor.Blue,
                Image = FontImageHelper.CreateImage(icon, 40, UIFontColor.Primary),
                ImageAlign = ContentAlignment.MiddleCenter,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(2),
                Tag = icon
            };
            lbl.MouseDown += lbl_MouseDown;
            return lbl;
        }

        public string IconName { get; set; }
        public int SymbolIndex { get; set; }
        private Label lastLabel;

        /// <summary>
        /// Label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_MouseDown(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                IconName = lbl.Name;
                SymbolIndex = (int)lbl.Tag;
                if (lastLabel != null)
                {
                    lastLabel.Image = FontImageHelper.CreateImage((int)lastLabel.Tag, 40, UIFontColor.Primary);
                }
                lastLabel = lbl;
                lastLabel.Image = FontImageHelper.CreateImage((int)lastLabel.Tag, 40, UIColor.Blue);
            }
        }

        /// <summary>
        /// 定时器从队列中加载到界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            while (!FontAwesomeV4Labels.IsEmpty)
            {
                if (FontAwesomeV4Labels.TryDequeue(out Label lbl))
                {
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
            timer1.Start();
        }
    }
}
