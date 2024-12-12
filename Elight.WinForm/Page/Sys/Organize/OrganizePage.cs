using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
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

namespace Elight.WinForm.Page.Sys.Organize
{
    [PageCode("sys-organize")]
    public partial class OrganizePage : MyPage
    {
        private SysOrganizeLogic organizeLogic;
        public OrganizePage()
        {
            InitializeComponent();
            organizeLogic = new SysOrganizeLogic();
            dataGridView.AutoGenerateColumns = false;
        }
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrganizePage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(null, null);
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //调用服务器获得数据 
            int totalCount = 0;
            List<SysOrganize> list = organizeLogic.GetList(pagination.ActivePage, pagination.PageSize, txtKeywords.Text, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }

        /// <summary>
        /// 关键字Enter键处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }

        /// <summary>
        /// 新增组织机构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrganizeForm form = new AddOrganizeForm();
            form.ParentPage = this;
            form.Id = string.Empty;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 修改组织机构
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
            string id = dataGridView.Rows[index].Cells["OrganizeId"].Value.ToString();
            AddOrganizeForm form = new AddOrganizeForm();
            form.ParentPage = this;
            form.Id = id;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 删除组织机构
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
            string id = dataGridView.Rows[index].Cells["OrganizeId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该角色？", UIStyle.White))
            {
                return;
            }
            try
            {
                int row = 0;
                int count = organizeLogic.GetChildCount(id);
                if (count > 0)
                {
                    this.ShowWarningDialog($"操作失败，请先删除该项的{count}个子级机构。", UIStyle.White);
                    return;
                }
                row = organizeLogic.Delete(id);
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了组织机构");

                if (row == 0)
                {
                    this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
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
        /// 页码发生改变
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
