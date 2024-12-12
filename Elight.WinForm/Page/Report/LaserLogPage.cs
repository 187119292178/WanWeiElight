using Elight.Entity.WanWei;
using Elight.Logic.WIP;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Report
{
    [PageCode("laser-interface-report")]
    public partial class LaserLogPage : MyPage
    {
        private ReportLogic reportLogic;
        private WIPLaserLogic wIPLaserLogic;
        public LaserLogPage()
        {
            InitializeComponent();

            reportLogic = new ReportLogic();
            wIPLaserLogic = new WIPLaserLogic();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LaserLogPage_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            dpTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dpFrom.Text = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd");
            txtSN.Text = "";
            txtOrderId.Text = "";
            txtOrderId.Focus();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            string fromdate = dpFrom.Value.ToString();
            string todate = dpTo.Value.ToString();
            string sn = txtSN.Text.Trim();
            string orderid = txtOrderId.Text.Trim();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(orderid))
            {
                dict.Add("OrderId", orderid);
            }
            if (!string.IsNullOrEmpty(sn))
            {
                dict.Add("sn", sn);
            }
            if (!string.IsNullOrEmpty(fromdate))
            {
                dict.Add("FromDate", fromdate);
            }
            if (!string.IsNullOrEmpty(todate))
            {
                dict.Add("ToDate", todate);
            }

            int totalCount = 0;
            List<WIPLaserLog> list = wIPLaserLogic.GetList(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            QueryData();

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e == null || e.Value == null || !(sender is DataGridView))
                return;
            DataGridView view = (DataGridView)sender;
            try
            {
                if (view.Columns[e.ColumnIndex].DataPropertyName == "ResultStatus")
                {
                    int val = Convert.ToInt32(e.Value);
                    switch (val)
                    {
                        case 0:
                            e.Value = "成功";
                            break;
                        case 1:
                            e.Value = "失败";
                            break;
                        default:
                            break;
                    }
                    e.FormattingApplied = true;
                }
            }
            catch (System.Exception ex)
            {
                e.FormattingApplied = false;
                this.ShowWarningDialog(ex.ToString(), UIStyle.Blue);
            }
        }
    }
}
