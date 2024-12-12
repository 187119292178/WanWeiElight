using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Elight.WinForm.Page.Sys.Item
{
    [PageCode("lay-item")]
    public partial class ItemPage : MyPage
    {
        private SysItemLogic itemLogic;
        private SysItemsDetailLogic itemDetaillogic;
        public ItemPage()
        {
            InitializeComponent();
            itemLogic = new SysItemLogic();
            itemDetaillogic = new SysItemsDetailLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemPage_Initialize(object sender, EventArgs e)
        {
            //加载TreeView 
            var listAllItems = itemLogic.GetList();
            List<ZTreeNode> result = new List<ZTreeNode>();
            foreach (var item in listAllItems)
            {
                ZTreeNode model = new ZTreeNode();
                model.id = item.Id;
                model.pId = item.ParentId;
                model.name = item.Name;
                model.open = true;
                result.Add(model);
            }
            List<ZTreeNode> allNode = result.Where(it => it.pId != "0").ToList();
            treeView.Nodes.Clear();
            bool first = true;
            foreach (ZTreeNode node in allNode)
            {
                TreeNode firstNode = new TreeNode(node.name);
                firstNode.Tag = node.id;
                treeView.Nodes.Add(firstNode);
                if (first)
                {
                    treeView.SelectedNode = firstNode;
                    first = false;
                }
            }
            if (!allNode.IsNullOrEmpty())
            {
                ShowCurrentItemDetail();
            }

        }

        private string currentId;

        /// <summary>
        /// 显示当前选项
        /// </summary>
        public void ShowCurrentItemDetail()
        {
            if (treeView.SelectedNode == null)
            {
                return;
            }
            currentId = (string)treeView.SelectedNode.Tag;
            ShowItemDetailData();
        }


        /// <summary>
        /// 显示字典选项
        /// </summary>
        public void ShowItemDetailData()
        {
            int totalCount = 0;
            List<SysItemDetail> list = itemDetaillogic.GetList(pagination.ActivePage, pagination.PageSize, currentId, "", ref totalCount);

            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;

        }

        /// <summary>
        /// treeView点击后触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowCurrentItemDetail();
        }

        /// <summary>
        /// 字典管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManage_Click(object sender, EventArgs e)
        {
            ItemManagerForm form = new ItemManagerForm();
            form.Parent = this;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 新增选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemDetailForm form = new AddItemDetailForm();
            form.Id = "";
            form.ParentPage = this;
            form.ItemId = currentId;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 修改选项
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
            string id = dataGridView.Rows[index].Cells["ItemDetailId"].Value.ToString();
            AddItemDetailForm form = new AddItemDetailForm();
            form.Id = id;
            form.ItemId = currentId;
            form.ParentPage = this;
            FormHelper.ShowSubForm(form);
        }


        /// <summary>
        /// 删除选项
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
            string id = dataGridView.Rows[index].Cells["ItemDetailId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该选项吗？", UIStyle.White))
            {
                return;
            }
            int row = itemDetaillogic.Delete(id);
            Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了字典选项");
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;

            }
            //重新查询
            ShowItemDetailData();
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
            ShowItemDetailData();
        }
        public override void Stop()
        {

        }
    }
}
