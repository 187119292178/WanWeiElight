﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Elight.Entity.Enum;
using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Utility.Files;
using Elight.Utility.Operator;
using Elight.Utility.ResponseModels;
using Elight.WebUI.Filters;
using Elight.Utility;
using Elight.Utility.Core;
using Elight.WebUI.Controllers;
using Elight.WebUI;

namespace Elight.WebUI.Controllers
{
    [HiddenApi]
    public class HomeController : BaseController
    {
        private SysUserLogic userLogic;
        private SysItemsDetailLogic itemDetailLogic;
        private SysUserLogOnLogic userLogOnLogic;
        private SysPermissionLogic permissionLogic;

        public HomeController()
        {
            userLogic = new SysUserLogic();
            itemDetailLogic = new SysItemsDetailLogic();
            userLogOnLogic = new SysUserLogOnLogic();
            permissionLogic = new SysPermissionLogic();
        }

        /// <summary>
        /// 后台首页视图。
        /// </summary>
        /// <returns></returns>
        [Route("home/index")]
        [HttpGet, LoginChecked]
        public ActionResult Index()
        {
            if (OperatorProvider.Instance.Current != null)
            {
                ViewBag.SoftwareName = AppSetting.WebSoftwareName;
                ViewBag.Copyright = AppSetting.Copyright;
                ViewBag.CurrentUser = OperatorProvider.Instance.Current;
                return View();
            }
            else
            {
                return Redirect("/account/login");
            }
        }
        /// <summary>
        /// 默认显示视图。
        /// </summary>
        /// <returns></returns>
        [Route("home/default")]
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }

        /// <summary>
        /// 获取左侧菜单。
        /// </summary>
        /// <returns></returns>
        [Route("home/getLeftMenu")]
        [HttpGet, LoginChecked]
        public ActionResult GetLeftMenu()
        {
            List<SysPermission> listModules;
            List<LayNavbar> listNavbar = new List<LayNavbar>();

            //如果是系统管理员，就应该具有所有的权限，不应该从角色权限表中获取
            string acccount = OperatorProvider.Instance.Current.Account;
            if (acccount == "admin")
            {
                listModules = permissionLogic.GetList();
            }
            else
            {
                string userId = OperatorProvider.Instance.Current.UserId;
                listModules = permissionLogic.GetList(userId);
            }
            foreach (var item in listModules.Where(c => c.Type == ModuleType.Menu && c.Layer == 0).ToList())
            {
                LayNavbar navbarEntity = new LayNavbar();
                var listChildNav = listModules.Where(c => c.Type == ModuleType.SubMenu && c.Layer == 1 && c.ParentId == item.Id).Select(c => new LayChildNavbar() { href = c.Url, icon = c.Icon, title = c.Name }).ToList();
                navbarEntity.icon = item.Icon;
                navbarEntity.spread = false;
                navbarEntity.title = item.Name;
                navbarEntity.children = listChildNav;
                listNavbar.Add(navbarEntity);
            }
            return Content(listNavbar.ToJson());
        }

        /// <summary>
        /// 获取登录用户权限。
        /// </summary>
        /// <returns></returns>
        [Route("home/getPermission")]
        [HttpGet, LoginChecked]
        public ActionResult GetPermission()
        {
            var account = OperatorProvider.Instance.Current.Account;
            if (account == "admin")
            {
                return Content(permissionLogic.GetList().ToJson());
            }
            return Content(permissionLogic.GetList(OperatorProvider.Instance.Current.UserId).ToJson());
        }

        /// <summary>
        /// 获取用户权限信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Route("app/home/getPermission")]
        [HttpGet]
        public ActionResult AppGetPermission(string userId)
        {
            try
            {
                if (new SysUserLogic().ContainsUser("admin", userId))
                {
                    return AppSuccess<List<SysPermission>>(permissionLogic.GetList());
                }
                return AppSuccess<List<SysPermission>>(permissionLogic.GetList(userId));
            }
            catch (Exception ex)
            {
                return AppError(ex);
            }
        }
    }
}
