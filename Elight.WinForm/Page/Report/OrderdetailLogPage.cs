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
    [PageCode("orderdetail-report")]

    public partial class OrderdetailLogPage : MyPage
    {
        private ReportLogic reportLogic;
        private WIPLaserLogic wIPLaserLogic;
        private WIPSNResLogic wIPSNResLogic;
        public OrderdetailLogPage()
        {
            InitializeComponent();

            reportLogic = new ReportLogic();
            wIPLaserLogic = new WIPLaserLogic();
            wIPSNResLogic = new WIPSNResLogic();
            uiDataGridView2.AutoGenerateColumns = false;
        }

        private void OrderdetailLogPage_Load(object sender, EventArgs e)
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
                dict.Add("SN", sn);
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
            List<WIP_SNRes> snRess = wIPSNResLogic.GetList(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            pagination.TotalCount = totalCount;
            uiDataGridView2.DataSource = snRess;
        }

        private void uiDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            QueryData();

        }
    }
}
