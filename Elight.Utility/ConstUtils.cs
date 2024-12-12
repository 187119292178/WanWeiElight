using System;
#if NETFRAMEWORK
using System.Configuration;
#else
using Elight.Utility.Files;
#endif

namespace Elight.Utility
{
    /// <summary>
    /// 全局配置文件
    /// </summary>
    public class ConstUtils
    {
        public static readonly string SoftwareName = ConfigurationManager.AppSettings["SoftwareName"];
    }
}
