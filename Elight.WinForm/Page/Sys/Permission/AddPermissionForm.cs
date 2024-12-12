using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Utility.Core;
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

namespace Elight.WinForm.Page.Sys.Permission
{
    public partial class AddPermissionForm : UIForm
    {
        private SysPermissionLogic permissionLogic;


        public AddPermissionForm()
        {
            InitializeComponent();
            permissionLogic = new SysPermissionLogic();
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
        public PermissionPage ParentPage { get; set; }
        public string Id { get; set; }

        private int symbolIndex;

        Dictionary<string, TreeNode> nodeDict = new Dictionary<string, TreeNode>();
        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPermissionForm_Load(object sender, EventArgs e)
        {
            txtType.Items.Add("请选择");
            txtType.Items.Add("主菜单");
            txtType.Items.Add("子菜单");
            txtType.Items.Add("按钮");
            txtType.SelectedIndex = 0;
            //获取部门下拉列表的值
            bool flag = GetPermissionCombox();
            if (!flag)
            {
                btnClose_Click(null, null);
                return;
            }
            if (StringHelper.IsNullOrEmpty(Id))
            {
                lblTitle.Text = "新增权限";
                txtEnCode.Enabled = true;
            }
            else
            {
                lblTitle.Text = "修改权限";
                txtEnCode.Enabled = false;
            }
            //获取部门下拉列表的值
            if (StringHelper.IsNullOrEmpty(Id))
            {
                return;
            }
            //获得用户信息
            SysPermission entity = permissionLogic.Get(Id);
            if (entity == null)
            {
                this.ShowWarningDialog("权限信息不存在", UIStyle.White);
                btnClose_Click(null, null);
                return;
            }
            //给文本框赋值
            txtEnCode.Text = entity.EnCode;
            txtName.Text = entity.Name;
            uiComboTreeView1.SelectedNode = GetNode(entity.ParentId);
            txtType.SelectedIndex = entity.Type.Value == 2 ? 1 : entity.Type.Value == 0 ? 2 : 3;
            txtIcon.Text = entity.Icon;
            symbolIndex = entity.SymbolIndex;
            txtSortCode.Value = entity.SortCode.Value;
            txtRemark.Text = entity.Remark;
        }

        /// <summary>
        /// 获得节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        private TreeNode GetNode(string parentId)
        {
            if (nodeDict.ContainsKey(parentId))
            {
                return nodeDict[parentId];
            }
            return nodeDict.FirstOrDefault().Value;
        }


        /// <summary>
        /// 获得权限下拉列表
        /// </summary>
        /// <returns></returns>
        private bool GetPermissionCombox()
        {

            try
            {
                var data = permissionLogic.GetList();
                var treeList = new List<TreeSelect>();
                foreach (SysPermission item in data)
                {
                    TreeSelect model = new TreeSelect();
                    model.id = item.Id;
                    model.text = item.Name;
                    model.parentId = item.ParentId;
                    treeList.Add(model);
                }
                BindData(uiComboTreeView1, treeList);
                return true;
            }
            catch (Exception ex)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return false;
            }
        }


        /// <summary>
        /// 绑定TreeView数据
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="list"></param>
        private void BindData(UIComboTreeView treeView, List<TreeSelect> list)
        {
            bool first = true;
            List<TreeSelect> list2 = list.Where(it => it.parentId == "0").ToList();
            foreach (TreeSelect select in list2)
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Name = select.id;
                rootNode.Tag = select.id;
                rootNode.Text = select.text;
                treeView.Nodes.Add(rootNode);
                nodeDict.Add(select.id, rootNode);
                if (first)
                {
                    treeView.SelectedNode = rootNode;
                    first = false;
                }
                BindChildAreas(rootNode, list);//调用添加子节点的方法
            }
        }

        private void BindChildAreas(TreeNode fNode, List<TreeSelect> list)
        {
            string fAreaId = fNode.Name; //父id
            List<TreeSelect> list2 = list.Where(it => it.parentId == fAreaId).ToList();
            if (list2.IsNullOrEmpty()) //递归终止，区域不包含子区域时
            {
                return;
            }
            foreach (TreeSelect select in list2)
            {
                TreeNode node = new TreeNode();
                node.Name = select.id;
                node.Tag = select.id; ;
                node.Text = select.text;
                //添加子节点
                fNode.Nodes.Add(node);
                nodeDict.Add(select.id, node);
                BindChildAreas(node, list);
            }
        }

        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Id))
            {
                DoAdd();
            }
            else
            {
                DoUpdate();
            }
        }


        /// <summary>
        /// 执行更新操作
        /// </summary>
        private void DoUpdate()
        {
            bool flag = ChechEmpty();
            if (!flag)
            {
                return;
            }
            SysPermission model = new SysPermission();
            model.Id = Id;
            model.ParentId = uiComboTreeView1.SelectedNode.Name;
            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.Icon = txtIcon.Text;
            model.SymbolIndex = symbolIndex;
            model.Remark = txtRemark.Text;
            model.Type = Convert.ToInt32(GetPermissionType());
            model.SortCode = txtSortCode.Value;
            model.ModifyUserId = GlobalConfig.CurrentUser.Id;

            SysPermissionLogic pLogic = new SysPermissionLogic();
            //当前类型是啥
            if (model.Type == 2)
            {
                model.ParentId = "0";
            }
            else if (model.Type == 0)
            {
                SysPermission permission = pLogic.Get(model.ParentId);
                if (permission.Type != 2)
                {
                    this.ShowWarningDialog("当前类型的父级必须为主菜单", UIStyle.White);
                    return;
                }

            }
            else
            {
                SysPermission permission = pLogic.Get(model.ParentId);
                if (permission.Type != 0)
                {
                    this.ShowWarningDialog("当前类型的父级必须为子菜单", UIStyle.White);
                    return;
                }
            }
            int row = permissionLogic.AppUpdate(model, model.ModifyUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            ParentPage.Init();
            btnClose_Click(null, null);

        }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty()
        {
            if (StringHelper.IsNullOrEmpty(txtEnCode.Text))
            {
                this.ShowWarningDialog("编码不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtName.Text))
            {
                this.ShowWarningDialog("名称不能为空", UIStyle.White);
                return false;
            }
            if (uiComboTreeView1.SelectedNode == null)
            {
                this.ShowWarningDialog("父级不能为空", UIStyle.White);
                return false;
            }
            if (txtType.SelectedIndex == 0)
            {
                this.ShowWarningDialog("类型不能为空", UIStyle.White);
                return false;
            }
            return true;
        }


        /// <summary>
        /// 执行新增操作
        /// </summary>
        private void DoAdd()
        {
            bool flag = ChechEmpty();
            if (!flag)
                return;
            SysPermission model = new SysPermission();
            model.ParentId = uiComboTreeView1.SelectedNode.Name;
            model.EnCode = txtEnCode.Text;
            model.Name = txtName.Text;
            model.Icon = txtIcon.Text;
            model.SymbolIndex = symbolIndex;
            model.Remark = txtRemark.Text;
            model.Type = Convert.ToInt32(GetPermissionType());
            model.SortCode = txtSortCode.Value;
            model.CreateUserId = GlobalConfig.CurrentUser.Id;

            SysPermissionLogic pLogic = new SysPermissionLogic();
            //当前类型是啥
            if (model.Type == 2)
            {
                model.ParentId = "0";
            }
            else if (model.Type == 0)
            {
                SysPermission permission = pLogic.Get(model.ParentId);
                if (permission.Type != 2)
                {
                    this.ShowWarningDialog("当前类型的父级必须为主菜单", UIStyle.White);
                    return;
                }
            }
            else
            {
                SysPermission permission = pLogic.Get(model.ParentId);
                if (permission.Type != 0)
                {

                    this.ShowWarningDialog("当前类型的父级必须为子菜单", UIStyle.White);
                    return;
                }

            }
            int row = permissionLogic.AppInsert(model, model.CreateUserId);
            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;
            }
            ParentPage.Init();
            btnClose_Click(null, null);

        }

        private string GetPermissionType()
        {
            if (txtType.SelectedIndex == 1)
            {
                return "2";
            }
            if (txtType.SelectedIndex == 2)
            {
                return "0";
            }
            if (txtType.SelectedIndex == 3)
            {
                return "1";
            }
            return "0";
        }


        /// <summary>
        /// 设置图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            IconForm form = new IconForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = form.IconName;
                symbolIndex = form.SymbolIndex;
            }
        }
    }
}
