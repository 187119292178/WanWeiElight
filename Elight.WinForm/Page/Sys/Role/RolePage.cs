using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Elight.WinForm.Page.Sys.User;
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

namespace Elight.WinForm.Page.Sys.Role
{
    [PageCode("sys-role")]
    public partial class RolePage : MyPage
    {
        private SysRoleLogic roleLogic;
        private SysUserRoleRelationLogic roleRelationLogic;
        public RolePage()
        {
            InitializeComponent();
            roleLogic = new SysRoleLogic();
            roleRelationLogic = new SysUserRoleRelationLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 界面初始化，查询显示数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RolePage_Initialize(object sender, EventArgs e)
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
            List<SysRole> list = roleLogic.GetList(pagination.ActivePage, pagination.PageSize, txtKeywords.Text, ref totalCount);
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
        /// 新增角色按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoleForm form = new AddRoleForm();
            form.ParentPage = this;
            form.Id = string.Empty;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 修改角色按钮事件处理
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
            string id = dataGridView.Rows[index].Cells["RoleId"].Value.ToString();
            AddRoleForm form = new AddRoleForm();
            form.ParentPage = this;
            form.Id = id;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 删除角色按钮事件处理
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
            string id = dataGridView.Rows[index].Cells["RoleId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该角色？", UIStyle.White))
            {
                return;
            }
            try
            {
                //判断这些权限是不是被用户绑定了，一旦绑定了，就不能删除，提示请先将用户解除绑定
                List<string> ids = id.SplitToList();
                List<SysUserRoleRelation> roleRelationList = roleRelationLogic.GetByRoles(ids);
                if (roleRelationList.Count > 0)
                {
                    this.ShowWarningDialog("请先从用户中解除角色绑定", UIStyle.White);
                    return;
                }
                int row = roleLogic.Delete(ids);
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了角色");
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
        /// 角色授权按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuthorize_Click(object sender, EventArgs e)
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
            string id = dataGridView.Rows[index].Cells["RoleId"].Value.ToString();
            RoleAuthorizeForm form = new RoleAuthorizeForm();
            form.ParentPage = this;
            form.Id = id;
            FormHelper.ShowSubForm(form);
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
