using Elight.Entity.Sys;
using System.Collections.Generic;
using System.Drawing;

namespace Elight.WinForm.Common
{
    /// <summary>
    /// 全局数据存放
    /// </summary>
    public class GlobalConfig
    {
        public static MyConfig Config { get; set; }
        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static SysUser CurrentUser;

        /// <summary>
        /// 当前用户头像
        /// </summary>
        public static Image Avatar;

        /// <summary>
        /// 当前选的哪个菜单
        /// </summary>
        public static string CurrentMenuText;

        /// <summary>
        /// 当前用户权限
        /// </summary>
        internal static List<SysPermission> PermissionList;


    }
}
