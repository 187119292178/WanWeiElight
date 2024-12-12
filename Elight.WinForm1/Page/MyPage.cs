using Elight.Entity.Sys; 
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page
{
    public class MyPage : UIPage
    {
        public virtual void Stop() { }

        public List<SysPermission> ButtonPermissionList
        {
            set
            {
                List<SysPermission> list = value;
                SetPermission(list, this.Controls);
            }
        }

        private void SetPermission(List<SysPermission> list, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                {
                    SetPermission(list, control.Controls);
                    continue;
                }
                if (control is UIButton)
                {
                    UIButton button = (UIButton)control;
                    object tag = button.Tag;
                    if (tag == null)
                        continue;
                    string strTag = tag as string;
                    if (strTag == null)
                        continue;
                    SysPermission permission = list.Where(it => it.EnCode == strTag).FirstOrDefault();
                    if (permission == null)
                        continue;
                    button.Visible = true;
                    continue;
                }
                if (control is UISymbolButton)
                {
                    UISymbolButton button = (UISymbolButton)control;
                    object tag = button.Tag;
                    if (tag == null)
                        continue;
                    string strTag = tag as string;
                    if (strTag == null)
                        continue;
                    SysPermission permission = list.Where(it => it.EnCode == strTag).FirstOrDefault();
                    if (permission == null)
                        continue;
                    button.Visible = true;
                    continue;
                }
                if (control is Button)
                {
                    Button button = (Button)control;
                    object tag = button.Tag;
                    if (tag == null)
                        continue;
                    string strTag = tag as string;
                    if (strTag == null)
                        continue;
                    SysPermission permission = list.Where(it => it.EnCode == strTag).FirstOrDefault();
                    if (permission == null)
                        continue;
                    button.Visible = true;
                    continue;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyPage
            // 
            this.Size = new System.Drawing.Size(1150, 637);
            this.Name = "MyPage";
            this.ResumeLayout(false);

        }
    }

    public class PageCodeAttribute : Attribute
    {
        public string Encode { get; set; }
        public PageCodeAttribute() { }
        public PageCodeAttribute(string encode)
        {
            this.Encode = encode;
        }
    }
}
