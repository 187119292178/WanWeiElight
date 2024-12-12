using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using LabelManager2;
using Mysqlx.Crud;
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
    [PageCode("packingdetail-report")]

    public partial class PackingDetailPage : MyPage
    {

        private ReportLogic reportLogic;
        private WIPLaserLogic wIPLaserLogic;
        private OrderLogic orderLogic;
        public PackingDetailPage()
        {
            InitializeComponent();

            reportLogic = new ReportLogic();
            wIPLaserLogic = new WIPLaserLogic();
            orderLogic = new OrderLogic();
            uiDataGridView1.AutoGenerateColumns = false;
        }

        private void PackingDetailPage_Load(object sender, EventArgs e)
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
            string boxNumber = txtBoxNumber.Text.Trim();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(orderid))
            {
                dict.Add("OrderId", orderid);
            }
            if (!string.IsNullOrEmpty(boxNumber))
            {
                dict.Add("BoxNumber", boxNumber);
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
            List<WIP_SNRes> snRess = orderLogic.GetSNResbyOrderId(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            pagination.TotalCount = totalCount;
            uiDataGridView1.DataSource = snRess;
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            QueryData();

        }
    }
}
