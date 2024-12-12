using Elight.Entity.Sys;
using Elight.Utility.Network;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Sys.Organize
{
    [PageCode("sys-organize")]
    public partial class OrganizePage : MyPage
    {
        public OrganizePage()
        {
            InitializeComponent();
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
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/index";
            RetMessage<LayPadding<SysOrganize>> result = WebApiRequest.DoPostJson<LayPadding<SysOrganize>>(url, new { pageIndex = pagination.ActivePage, pageSize = pagination.PageSize, keyWord = txtKeywords.Text });
            if (result == null)
            {
                this.ShowInfoDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowInfoDialog(result.message, UIStyle.White);
                return;
            }
            List<SysOrganize> list = result.data.list;
            pagination.TotalCount = (int)result.data.count;
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
                string url = $"{GlobalConfig.Config.ServerUrl}app/system/organize/delete";
                RetMessage<string> result = WebApiRequest.DoPostJson<string>(url, new { primaryKey = id, operateUser = GlobalConfig.CurrentUser.Account });
                if (result == null)
                {
                    this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                    return;
                }
                if (result.code != RetCode.success)
                {
                    this.ShowWarningDialog(result.message, UIStyle.White);
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
