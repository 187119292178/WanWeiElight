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
using Elight.Logic.Sys;
using Elight.Entity.Sys;
using Elight.WinForm.Common;
using Elight.Logic;
using Elight.Utility.Other;

namespace Elight.WinForm.Page.Sys.Item
{
    public partial class ItemManagerForm : UIForm
    {
        private SysItemLogic itemLogic;
        private SysItemsDetailLogic itemsDetailLogic;
        public ItemManagerForm()
        {
            InitializeComponent();
            itemLogic = new SysItemLogic();
            itemsDetailLogic = new SysItemsDetailLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        public new ItemPage Parent;

        #region 标题栏

        /// <summary>
        ///  标题
        /// </summary>
        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Parent.Init();
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
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemManagerForm_Load(object sender, EventArgs e)
        {
            //获得目前所有的字典 
            int totalCount = 0;
            List<SysItem> list = itemLogic.GetAppList(pagination.ActivePage, pagination.PageSize, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;


        }

        /// <summary>
        /// 新增字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ItemManagerForm_Load(null, null);
            }
        }

        /// <summary>
        /// 修改字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White); return;
            }
            string id = dataGridView.Rows[index].Cells["ItemId"].Value.ToString();

            AddItemForm form = new AddItemForm();
            form.Id = id;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ItemManagerForm_Load(null, null);
            }
        }

        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White); return;
            }
            string id = dataGridView.Rows[index].Cells["ItemId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该字典吗？", UIStyle.White))
            {
                return;
            }
            try
            {
                int count = itemLogic.GetChildCount(id);
                if (count > 0)
                {
                    this.ShowWarningDialog($"操作失败，请先删除该项的{count}个子级字典。", UIStyle.White);
                    return;
                }

                //删除字典。
                int row = itemLogic.Delete(id);
                //删除字典选项。
                itemsDetailLogic.Delete(id);
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了字典");
                if (row == 0)
                {
                    this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                    return;
                }
                //重新查询
                ItemManagerForm_Load(null, null);
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
            }
        }

        /// <summary>
        /// 页码发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            ItemManagerForm_Load(null, null);
        }
    }
}
