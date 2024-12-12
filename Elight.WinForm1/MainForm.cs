using MES.WinForm.Page;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using Elight.Utility.Network;
using Elight.WinForm.Common;
using Elight.Entity.Sys;
using Elight.WinForm.Page;

namespace Elight.WinForm
{
    /// <summary>
    /// 主界面
    /// </summary>
    public partial class MainForm : UIAsideMainFrame
    {
        private List<UIPage> pageList = new List<UIPage>();

        public MainForm()
        {
            InitializeComponent();
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

            //List<SysPermission> list;
            //if (userLogic.ContainsUser("admin", GlobalConfig.CurrentUser.Id))
            //{
            //    list = permissionLogic.GetList();
            //}
            //else
            //{
            //    list = permissionLogic.GetList(GlobalConfig.CurrentUser.Id);
            //}
            //if (list.IsNullOrEmpty())
            //{
            //    this.ShowInfoDialog("网络或服务器异常，请稍后重试", UIStyle.White);
            //    return;
            //};
            Dictionary<string, string> parms = new Dictionary<string, string>();
            parms.Add("userId", GlobalConfig.CurrentUser.Id);
            RetMessage<List<SysPermission>> result2 = WebApiRequest.DoGet<List<SysPermission>>($"{GlobalConfig.Config.ServerUrl}app/home/getPermission", parms);
            if (result2 == null)
            {
                this.ShowInfoDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result2.code != RetCode.success)
            {
                this.ShowInfoDialog(result2.message, UIStyle.White);
                return;
            }
            List<SysPermission> list = result2.data;
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
            //TreeNode parent = Aside.CreateNode("系统管理", 61641, 24, 10000);
            //Aside.CreateChildNode(parent, AddPage(new UserPage(), 10100));
            //Aside.CreateChildNode(parent, AddPage(new PermissionPage(), 10200));
            //Aside.CreateChildNode(parent, AddPage(new RolePage(), 10300));
            //Aside.CreateChildNode(parent, AddPage(new OrganizePage(), 10400));
            //Aside.CreateChildNode(parent, AddPage(new ItemPage(), 10500));

            //parent = Aside.CreateNode("仓储管理", 61888, 24, 20000);
            //Aside.CreateChildNode(parent, AddPage(new StoragePage(), 20100));//库位管理
            //Aside.CreateChildNode(parent, AddPage(new MaterialPage(), 20200));//材料管理

            //parent = Aside.CreateNode("任务管理", 61704, 24, 30000);
            //Aside.CreateChildNode(parent, AddPage(new ProductPage(), 30100));//产品管理
            //Aside.CreateChildNode(parent, AddPage(new OrderPage(), 30200));//订单管理
            //Aside.CreateChildNode(parent, AddPage(new WarehouseTaskPage(), 30300));//仓库任务
            //Aside.CreateChildNode(parent, AddPage(new LoadTaskPage(), 30400));//上料任务 
            //Aside.CreateChildNode(parent, AddPage(new CutTaskPage(), 30500));//切割任务
            //Aside.CreateChildNode(parent, AddPage(new SortTaskPage(), 30600));//分拣任务
            //Aside.CreateChildNode(parent, AddPage(new AgvTaskPage(), 30700));//AGV任务
            //Aside.CreateChildNode(parent, AddPage(new BendTaskPage(), 30800));//折弯任务
            //Aside.CreateChildNode(parent, AddPage(new WeldingTaskPage(), 30900));//焊接任务
            //Aside.CreateChildNode(parent, AddPage(new SprayTaskPage(), 31000));//喷涂任务

            //parent = Aside.CreateNode("设备管理", 61879, 24, 40000);
            //Aside.CreateChildNode(parent, AddPage(new InOutboundDevicePage(), 40100));//出入库设备
            //Aside.CreateChildNode(parent, AddPage(new LoadDevicePage(), 40200));//上下料
            //Aside.CreateChildNode(parent, AddPage(new CutDevicePage(), 40300));//切割机
            //Aside.CreateChildNode(parent, AddPage(new SortDevicePage(), 40400));//分拣机
            //Aside.CreateChildNode(parent, AddPage(new AgvDevicePage(), 40500));//AGV
            //Aside.CreateChildNode(parent, AddPage(new BendDevicePage(), 40600));//折弯机
            //Aside.CreateChildNode(parent, AddPage(new WeldingDevicePage(), 40700));//焊接机
            //Aside.CreateChildNode(parent, AddPage(new SprayDevicePage(), 40800));//喷涂机

            //parent = Aside.CreateNode("报表管理", 61952, 24, 50000);
            //Aside.CreateChildNode(parent, AddPage(new ReportPage(), 50100));//待完成

            //parent = Aside.CreateNode("日志管理", 61639, 24, 60000);
            //Aside.CreateChildNode(parent, AddPage(new OperationLogPage(), 60100));//操作日志
            //Aside.CreateChildNode(parent, AddPage(new RunningLogPage(), 60200));//运行日志
            //Aside.CreateChildNode(parent, AddPage(new ErrorLogPage(), 60300));//异常日志
            //Aside.SelectFirst();
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
            if (this.ShowAskDialog("您确定要退出吗？", UIStyle.White))
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
        //private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        //{
        //    GlobalConfig.CurrentMenuText = node.Text;
        //}

        private void MainForm_Selecting(object sender, TabControlCancelEventArgs e, UIPage page)
        {
            if (page != null)
                GlobalConfig.CurrentMenuText = page.Text;
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {
            if (uiSymbolLabel1.Symbol == 61500)
            {
                Aside.Visible = true;
                uiSymbolLabel1.Symbol = 61499;
            }
            else
            {
                Aside.Visible = false;
                uiSymbolLabel1.Symbol = 61500;
            }
        }
    }
}
