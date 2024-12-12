using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.WinForm.Common
{
    public class MyConfig
    {
        public int EveryPageDataCount { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; }
        /// <summary>
        /// 数据库主机IP
        /// </summary>
        public string DbHost { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// 数据库用户名
        /// </summary>
        public string DbUserName { get; set; }

        /// <summary>
        /// 数据库密码
        /// </summary>
        public string DbPassword { get; set; }

        /// <summary>
        /// FTPIP
        /// </summary>
        public string FtpHost { get; set; }
        
        /// <summary>
        /// FTP用户名
        /// </summary>
        public string FtpUserName { get; set; }
        /// <summary>
        /// FTP密码
        /// </summary>
        public string FtpPassword { get; set; }


        private bool _debug = false;
        /// <summary>
        /// 是否调试模式，调试模式将会输出日志
        /// </summary>
        public bool Debug { get { return _debug; } set { _debug = value; } }


    }
}
