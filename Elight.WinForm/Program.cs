using Elight.Logic.Base;
using Elight.Utility.Core;
using Elight.Utility.Extension;
using Elight.Utility.Logs;
using Elight.Utility.Security;
using Elight.WinForm.Common;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Elight.WinForm
{
    internal static class Program
    {

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyConfig config = File.ReadAllText(MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            GlobalConfig.Config = config;
            string message = "";
            bool flag = BaseLogic.InitDB(config.DbType, config.DbHost, config.DbName, config.DbUserName, config.DbPassword, ref message);
            if (!flag)
            {
                Console.Write(message);
                return;
            }
            //��ʼ��log4net�����ļ�
            LogHelper.Init(File.ReadAllText(MyEnvironment.RootPath("Configs/log4net.config")));

#if !NETFRAMEWORK
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#else
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            //��õ�ǰ��¼��Windows�û���ʾ  
            //WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            //if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            //{
            //    UIMessageBox.ShowWarning("���ѹ���Ա�������");
            //    return;
            //}
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
