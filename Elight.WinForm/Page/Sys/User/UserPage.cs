using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.Utility.Security;
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

namespace Elight.WinForm.Page.Sys.User
{

    [PageCode("sys-user")]
    public partial class UserPage : MyPage
    {
        private SysUserLogic userLogic;
        private SysUserRoleRelationLogic userRoleRelationLogic;
        private SysUserLogOnLogic userLogOnLogic;
        public UserPage()
        {
            InitializeComponent();
            userLogic = new SysUserLogic();
            userRoleRelationLogic = new SysUserRoleRelationLogic();
            userLogOnLogic = new SysUserLogOnLogic();
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
            int totalCount = 0;
            List<SysUser> list = userLogic.GetList(pagination.ActivePage, pagination.PageSize, txtKeywords.Text, ref totalCount);
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
                //过滤系统管理员
                if (userLogic.ContainsUser("admin", userIdList.ToArray()))
                {
                    this.ShowWarningDialog("系统管理员用户不能删除", UIStyle.White);
                    return;
                }
                if (userIdList.Contains(GlobalConfig.CurrentUser.Id))
                {
                    this.ShowWarningDialog("不能删除自己", UIStyle.White);
                    return;
                }
                //多用户删除。
                int row = userLogic.Delete(userIdList);
                userRoleRelationLogic.Delete(userIdList);
                userLogOnLogic.Delete(userIdList);
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Id}删除了用户");
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
            string[] userIdList = new string[] { id };
            if (userLogic.ContainsUser("admin", new string[] { id }))
            {
                this.ShowWarningDialog("不能重置系统管理员密码", UIStyle.White);
                return;
            }
            if (userIdList.Contains(GlobalConfig.CurrentUser.Id))
            {
                this.ShowWarningDialog("不能重置自己密码，请从账号管理中修改密码", UIStyle.White);
                return;
            }
            //重置密码
            SysUserLogOn sysUserLogOn = userLogOnLogic.GetByAccount(id);
            sysUserLogOn.Password = "123456".MD5Encrypt().DESEncrypt(sysUserLogOn.SecretKey).MD5Encrypt();
            int row = userLogOnLogic.UpdatePassword(sysUserLogOn);
            if (row > 0)
            {
                this.ShowSuccessDialog("该用户密码已重置为123456");
                return;
            }
            else
            {
                this.ShowErrorDialog("重置失败");
            }
        }

        
    }
}
