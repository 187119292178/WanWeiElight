using Elight.Entity.Sys;
using Elight.Utility.Core; 
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using Elight.Logic.Sys;
using Elight.WinForm.Page;

namespace Elight.WinForm
{
    /// <summary>
    /// 主界面
    /// </summary>
    public partial class MainForm : UIAsideMainFrame
    {
        private SysUserLogic userLogic;
        private SysPermissionLogic permissionLogic;
        private List<UIPage> pageList = new List<UIPage>();
        public MainForm()
        {
            InitializeComponent();
            userLogic = new SysUserLogic();
            permissionLogic = new SysPermissionLogic();
        }


        /// <summary>
        /// 画面加载 显示菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置关联
            //Aside.TabControl = MainTabControl;
            //获得用户权限
            List<SysPermission> list;
            if (userLogic.ContainsUser("admin", GlobalConfig.CurrentUser.Id))
            {
                list = permissionLogic.GetList();
            }
            else
            {
                list = permissionLogic.GetList(GlobalConfig.CurrentUser.Id);
            }
            if (list.IsNullOrEmpty())
            {
                this.ShowInfoDialog("该账号没有任何权限", UIStyle.White);
                return;
            }
            GlobalConfig.PermissionList = list;
            Guid guid = Guid.NewGuid();
            AddPage(new DefaultPage(), guid);
            SelectPage(guid);
            //取出一级菜单
            List<SysPermission> root = list.Where(it => it.ParentId == "0").ToList();
            foreach (SysPermission permission in root)
            {
                TreeNode parent = Aside.CreateNode(permission.Name, permission.SymbolIndex, 24, permission.SortCode.Value);
                List<SysPermission> childList = list.Where(it => it.ParentId == permission.Id).ToList();
                foreach (SysPermission child in childList)
                {
                    UIPage page = CreateUIPage(child);
                    pageList.Add(page);
                    Aside.CreateChildNode(parent, AddPage(page, Guid.NewGuid()));
                }
            }
        }


        /// <summary>
        /// 根据不同的权限，创建不同的Page
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        private UIPage CreateUIPage(SysPermission permission)
        {

            //反射创建具体的页面
            List<Type> typeList = Assembly.GetExecutingAssembly().GetTypes().Where(it => it.IsClass).ToList();
            foreach (Type type in typeList)
            {
                PageCodeAttribute attribute = type.GetCustomAttribute(typeof(PageCodeAttribute)) as PageCodeAttribute;
                if (attribute == null)
                    continue;
                if (attribute.Encode != permission.EnCode)
                    continue;
                try
                {
                    MyPage page = (MyPage)type.CreateInstance();
                    page.Text = permission.Name;
                    page.Symbol = permission.SymbolIndex;
                    page.ButtonPermissionList = GlobalConfig.PermissionList.Where(it => it.ParentId == permission.Id).ToList();
                    return page;
                }
                catch
                {
                    MyPage page = new EmptyPage();
                    page.Text = permission.Name;
                    page.Symbol = permission.SymbolIndex;
                    return page;
                }
            }
            MyPage page1 = new EmptyPage();
            page1.Text = permission.Name;
            page1.Symbol = permission.SymbolIndex;
            return page1;
        }

        /// <summary>
        /// 退出提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ShowAskDialog("您确定要退出吗？", UIStyle.Blue))
            {
                foreach (UIPage page in pageList)
                {
                    if (page is MyPage)
                        ((MyPage)page).Stop();
                }
                Environment.Exit(0);
                return;
            }
            e.Cancel = true;
        }





        /// <summary>
        /// 菜单选择
        /// </summary>
        /// <param name="node"></param>
        /// <param name="item"></param>
        /// <param name="pageIndex"></param>
        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            GlobalConfig.CurrentMenuText = node.Text;
        }

        private void MainForm_Selecting(object sender, TabControlCancelEventArgs e, UIPage page)
        {
            if (page != null)
                GlobalConfig.CurrentMenuText = page.Text;
        }

    }
}
