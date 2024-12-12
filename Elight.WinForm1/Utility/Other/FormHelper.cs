#if NETFRAMEWORK || WINDOWS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.Utility.Other
{
    public class FormHelper
    {
        public static Form subForm;

        /// <summary>
        /// 显示子Form
        /// </summary>
        /// <param name="form"></param>
        public static void ShowSubForm(Form form)
        {
            //关闭之前的
            try { if (subForm != null) subForm.Close(); } catch { }
            //打开现在的
            subForm = form;
            form.Show();
        }
    }
}
#endif
