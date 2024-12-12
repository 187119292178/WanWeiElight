using Elight.Entity.Sys;
using Elight.Utility.Network;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;
using Elight.WinForm.Common;
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

namespace Elight.WinForm.Page.Sys.Item
{
    public partial class ItemManagerForm : UIForm
    {
        public ItemManagerForm()
        {
            InitializeComponent();
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
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/item/index";
            RetMessage<LayPadding<SysItem>> result =WebApiRequest.DoPostJson<LayPadding<SysItem>>(url, new
            {
                pageIndex = pagination.ActivePage,
                pageSize = pagination.PageSize
            });
            if (result == null)
            {
                this.ShowWarningDialog("网络或者服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            pagination.TotalCount = (int)result.data.count;
            dataGridView.DataSource = result.data.list;
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
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/item/delete";
            RetMessage<string> result =WebApiRequest.DoPostJson<string>(url, new
            {
                primaryKey = id,
                operateUser = GlobalConfig.CurrentUser.Account
            });
            if (result == null)
            {
                this.ShowWarningDialog("网络或者服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            //重新查询
            ItemManagerForm_Load(null, null);
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
