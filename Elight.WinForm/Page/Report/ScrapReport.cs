using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using LabelManager2;
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
using DateTime = System.DateTime;

namespace Elight.WinForm.Page.Report
{
    [PageCode("scrap-report")]

    public partial class ScrapReport : MyPage
    {
        private ReportLogic reportLogic;
        private WIPScrapLogic wIPScrapLogic;
        private WIPLaserLogic wIPLaserLogic;
        private OrderLogic orderLogic;
        public ScrapReport()
        {
            InitializeComponent();

            reportLogic = new ReportLogic();
            wIPLaserLogic = new WIPLaserLogic();
            wIPScrapLogic = new WIPScrapLogic();
            orderLogic = new OrderLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        private void ScrapReport_Load(object sender, EventArgs e)
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
            List<WIPScrap> snRess = wIPScrapLogic.GetList(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = snRess;
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
                if (view.Columns[e.ColumnIndex].DataPropertyName == "IsScrap")
                {
                    string val = e.Value.ToString();
                    switch (val)
                    {
                        case "Y":
                            e.Value = "报废";
                            break;
                        case "N":
                            e.Value = "取消报废";
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
