#if NETFRAMEWORK || WINDOWS
using System;
using System.Collections.Generic;
using System.Data;
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
            //form.Show();
            form.ShowDialog();
        }


        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
#endif
