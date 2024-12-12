using Elight.Utility.Core;
using Elight.Utility.Extension;
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
