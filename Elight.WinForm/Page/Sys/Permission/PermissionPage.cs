using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys.Permission
{
    [PageCode("sys-permission")]
    public partial class PermissionPage : MyPage
    {
        private SysPermissionLogic permissionLogic;
        public PermissionPage()
        {
            InitializeComponent();
            permissionLogic = new SysPermissionLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserPage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            int totalCount = 0;
            List<SysPermission> list = permissionLogic.GetList(pagination.ActivePage, pagination.PageSize, txtKeywords.Text, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }


        /// <summary>
        /// 图标渲染
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == ("Symbols"))
            {
                int symbolIndex = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Icons"].Value.ToString());
                e.Value = FontImageHelper.CreateImage(symbolIndex, 18, Color.Black);
            }
        }

        /// <summary>
        /// 关键词Enter键处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }


        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPermissionForm form = new AddPermissionForm();
            form.ParentPage = this;
            form.Id = string.Empty;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 修改权限
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
            string id = dataGridView.Rows[index].Cells["PermissionId"].Value.ToString();
            AddPermissionForm form = new AddPermissionForm();
            form.ParentPage = this;
            form.Id = id;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行删除", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行删除", UIStyle.White); return;
            }
            string id = dataGridView.Rows[index].Cells["PermissionId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该权限？", UIStyle.White))
            {
                return;
            }
            try
            {
                long count = permissionLogic.GetChildCount(id);
                if (count > 0)
                {
                    this.ShowWarningDialog($"操作失败，请先删除该项的{count}个子级权限。", UIStyle.White);
                    return;

                }
                int row = permissionLogic.Delete(id.SplitToList().ToArray());
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了权限");
                if (row == 0)
                {
                    this.ShowWarningDialog($"对不起，操作失败", UIStyle.White);
                    return;
                }
                //重新查询
                btnQuery_Click(null, null);
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后再试", UIStyle.White);
            }
        }


        /// <summary>
        /// 页码变更触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }

        public override void Stop()
        {

        }
    }
}
