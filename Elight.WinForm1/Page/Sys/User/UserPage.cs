using Elight.Entity.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Elight.Utility.ResponseModels;
using Elight.Utility.Network;
using Elight.WinForm.Common;
using Elight.Utility.Security;
using System.Linq;

namespace Elight.WinForm.Page.Sys.User
{

    [PageCode("sys-user")]
    public partial class UserPage : MyPage
    {
        public UserPage()
        {
            InitializeComponent();
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
        /// 查询按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetMessage<LayPadding<SysUser>> result = WebApiRequest.DoPostJson<LayPadding<SysUser>>($"{GlobalConfig.Config.ServerUrl}app/system/user/index", new { pageIndex = pagination.ActivePage, pageSize = pagination.PageSize, keyWord = txtKeywords.Text });
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
            pagination.TotalCount = (int)result.data.count;
            dataGridView.DataSource = result.data.list;
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
        /// 新增用户按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.ParentPage = this;
            form.Id = string.Empty;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 修改用户按钮事件处理
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
            string id = dataGridView.Rows[index].Cells["UserId"].Value.ToString();
            AddUserForm form = new AddUserForm();
            form.ParentPage = this;
            form.Id = id;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 删除用户按钮事件处理
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
            string id = dataGridView.Rows[index].Cells["UserId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该用户？", UIStyle.White))
            {
                return;
            }
            try
            {
                //多用户删除。
                List<string> userIdList = id.SplitToList();
                RetMessage<string> result = WebApiRequest.DoPostJson<string>($"{GlobalConfig.Config.ServerUrl}app/system/user/delete", new { userIdList = userIdList, currentUserId = GlobalConfig.CurrentUser.Id, operateUser = GlobalConfig.CurrentUser.Account });
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

        private void uiSymbolButton1_Click(object sender, EventArgs e)
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
            string id = dataGridView.Rows[index].Cells["UserId"].Value.ToString();
            List<string> userIdList = new List<string> { id };
            RetMessage<string> result = WebApiRequest.DoPostJson<string>($"{GlobalConfig.Config.ServerUrl}app/system/user/resetPassword", new { userIdList = userIdList, currentUserId = GlobalConfig.CurrentUser.Id, operateUser = GlobalConfig.CurrentUser.Account });
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
            this.ShowSuccessDialog(result.message);
            return;
        }

        public override void Stop()
        {

        }
    }
}
