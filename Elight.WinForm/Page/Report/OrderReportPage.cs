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
    [PageCode("order-report")]

    public partial class OrderReportPage : MyPage
    {
        private ReportLogic reportLogic;
        private WIPLaserLogic wIPLaserLogic;
        private OrderLogic orderLogic;
        public OrderReportPage()
        {
            InitializeComponent();

            reportLogic = new ReportLogic();
            wIPLaserLogic = new WIPLaserLogic();
            orderLogic = new OrderLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        private void OrderReportPage_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            dpTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dpFrom.Text = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd");
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
            string orderid = txtOrderId.Text.Trim();
            string itemCode = txtItemCode.Text.Trim();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(itemCode))
            {
                dict.Add("ItemCode", itemCode);
            }
            if (!string.IsNullOrEmpty(orderid))
            {
                dict.Add("OrderId", orderid);
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
            List<OrderInfo> list = orderLogic.GetList(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            dataGridView.DataSource = list;
            pagination.TotalCount = totalCount;
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            QueryData();

        }
    }
}
