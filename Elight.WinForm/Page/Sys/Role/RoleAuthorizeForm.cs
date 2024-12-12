using Sunny.UI;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.WinForm.Common;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;

namespace Elight.WinForm.Page.Sys.Role
{
    public partial class RoleAuthorizeForm : UIForm
    {
        private SysRoleAuthorizeLogic roleAuthorizeLogic;
        private SysPermissionLogic permissionLogic;
        public RoleAuthorizeForm()
        {
            InitializeComponent();
            roleAuthorizeLogic = new SysRoleAuthorizeLogic();
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
        public RolePage ParentPage { get; set; }
        public string Id { get; set; }

        /// <summary>
        /// 画面加载，读取用户信息，显示在界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRoleForm_Load(object sender, EventArgs e)
        {

            try
            {
                List<string> listPerIds = roleAuthorizeLogic.GetList(Id).Select(c => c.ModuleId).ToList();
                List<SysPermission> listAllPers;
                if (new SysUserLogic().ContainsUser("admin", GlobalConfig.CurrentUser.Id))
                {
                    listAllPers = permissionLogic.GetList();
                }
                else
                {
                    listAllPers = permissionLogic.GetList(GlobalConfig.CurrentUser.Id);
                }
                listAllPers = HandleData(listAllPers);
                List<ZTreeNode> result = new List<ZTreeNode>();
                foreach (var item in listAllPers)
                {
                    ZTreeNode model = new ZTreeNode();
                    model.@checked = listPerIds.Where(it => (it + "-view").StartsWith(item.Id)).Count() > 0 ? model.@checked = true : model.@checked = false;
                    model.id = item.Id;
                    model.pId = item.ParentId;
                    model.name = item.Name;
                    model.open = true;
                    result.Add(model);
                }
                List<ZTreeNode> fistNode = result.Where(it => it.pId == "0").ToList();
                foreach (ZTreeNode node in fistNode)
                {
                    TreeNode parentNode = new TreeNode(node.name);
                    parentNode.Tag = node.id;
                    parentNode.Checked = node.@checked;
                    //二级菜单
                    List<ZTreeNode> secondList = result.Where(it => it.pId == node.id).ToList();
                    foreach (ZTreeNode second in secondList)
                    {
                        TreeNode seconds = new TreeNode(second.name);
                        seconds.Checked = second.@checked;
                        seconds.Tag = second.id;
                        //三级菜单
                        List<ZTreeNode> thirdList = result.Where(it => it.pId == second.id).ToList();
                        foreach (ZTreeNode third in thirdList)
                        {
                            TreeNode thirds = new TreeNode(third.name);
                            thirds.Tag = third.id;
                            thirds.Checked = third.@checked;
                            seconds.Nodes.Add(thirds);
                        }
                        parentNode.Nodes.Add(seconds);
                    }
                    treeView.Nodes.Add(parentNode);
                }
                treeView.ExpandAll();
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                btnClose_Click(null, null);
            }
        }


        private List<SysPermission> HandleData(List<SysPermission> listAllPers)
        {
            List<SysPermission> list = new List<SysPermission>();

            List<SysPermission> firstNode = listAllPers.Where(it => it.ParentId == "0").ToList();
            foreach (SysPermission permission in firstNode)
            {
                list.Add(permission);
                List<SysPermission> secondNode = listAllPers.Where(it => it.ParentId == permission.Id).ToList();
                foreach (SysPermission per in secondNode)
                {
                    list.Add(per);
                    List<SysPermission> thirdNode = listAllPers.Where(it => it.ParentId == per.Id).ToList();
                    list.Add(new SysPermission
                    {
                        Id = per.Id + "-view",
                        ParentId = per.Id,
                        Layer = 2,
                        EnCode = per.EnCode,
                        Name = "显示",
                    });
                    foreach (SysPermission per2 in thirdNode)
                    {
                        list.Add(per2);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //获得所有的Tag 
                List<string> userPermissionList = new List<string>();//用于保存所有的id
                foreach (TreeNode parentNode in treeView.Nodes)
                {
                    if (parentNode.Checked)
                    {
                        userPermissionList.Add((string)parentNode.Tag);
                    }

                    //二级
                    foreach (TreeNode second in parentNode.Nodes)
                    {
                        if (second.Checked)
                        {
                            userPermissionList.Add((string)second.Tag);
                        }
                        //三级
                        foreach (TreeNode third in second.Nodes)
                        {
                            if (third.Checked)
                            {
                                userPermissionList.Add((string)third.Tag);
                            }
                        }
                    }
                }
                roleAuthorizeLogic.AppAuthorize(GlobalConfig.CurrentUser.Account, Id, userPermissionList.Select(it => it.Replace("-view", "")).Distinct().ToArray());
                btnClose_Click(null, null);
            }
            catch
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
        }
    }
}
