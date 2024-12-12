using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Common
{
    public class ScanHelpler
    {

        public static void SetScanFocus(UITextBox txtInput, Label lbl)
        {
            txtInput.ReadOnly = false;
            txtInput.BackColor = Color.GreenYellow;
            txtInput.SelectAll();
            txtInput.Focus();
            lbl.Visible = false;
        }


        public static void ShowSuccess(Label lblMsg, string sMsg)
        {
            lblMsg.BackColor = Color.FromArgb(123, 172, 231);
            lblMsg.ForeColor = Color.White;
            lblMsg.Text = sMsg;
        }

        public static void ShowFail(Label lblMsg, string sMsg)
        {
            lblMsg.BackColor = Color.FromArgb(123, 172, 231);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Text = sMsg;
        }

        public static void ScanSuccess(UITextBox txtInput, Label lblStatus, Label lblMsg, string sMsg)
        {
            txtInput.Text = "";
            //txtInput.ReadOnly = true;
            txtInput.BackColor = Color.WhiteSmoke;

            lblStatus.BackColor = Color.Green;
            lblStatus.Text = "PASS";
            lblStatus.Visible = true;
            lblMsg.BackColor = Color.FromArgb(123, 172, 231);
            lblMsg.ForeColor = Color.White;
            lblMsg.Text = sMsg;
        }
      

        public static void ScanFail(UITextBox txtInput, Label lblStatus, Label lblMsg, string sMsg)
        {
            txtInput.Text = "";
            //txtInput.ReadOnly = false;
            txtInput.Select();
            txtInput.Focus();
            lblStatus.BackColor = Color.Red;
            lblStatus.Text = "NG";
            lblStatus.Visible = true;
            lblMsg.BackColor = Color.FromArgb(123, 172, 231);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Text = sMsg;
        }

    }
}
