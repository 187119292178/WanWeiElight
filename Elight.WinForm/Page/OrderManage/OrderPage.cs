using Elight.Entity.Sys;
using Elight.Entity.WanWei;
using Elight.Logic;
using Elight.Logic.Base;
using Elight.Logic.Sys;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.OrderManage
{
    [PageCode("wip-order")]
    public partial class OrderPage : MyPage
    {
        private OrderLogic logic;
        private string sMsg = "";
        private List<OrderInfo> ImportList;
        private SysItemsDetailLogic detailLogic;

        public OrderPage()
        {
            InitializeComponent();
            detailLogic = new SysItemsDetailLogic();
            logic = new OrderLogic();

            dataGridView.AutoGenerateColumns = false;
            CommonHelper.InitDataGridView(dataGridView, DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void OrderPage_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            BindOrderInfoType();
            BindMatType();
            dpFrom.Text = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            dpEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");

            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 绑定工单状态下拉框
        /// </summary>
        private void BindOrderInfoType()
        {
            string orderStatusId = ConfigurationManager.AppSettings["OrderStatusId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("status");
            cmbState.ValueMember = "EnCode";
            cmbState.DisplayMember = "Name";
            cmbState.DataSource = list;
        }

        /// <summary>
        /// 绑定物料类型下拉框
        /// </summary>
        private void BindMatType()
        {
            string materialTypeId = ConfigurationManager.AppSettings["MaterialTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("MaterialType");
            cmbMatType.ValueMember = "EnCode";
            cmbMatType.DisplayMember = "Name";
            cmbMatType.DataSource = list;
        }


        /// <summary>
        /// 工单生码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreated_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }

            string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
            OrderInput form = new OrderInput();
            form.ParentPage = this;
            form.Id = orderId;
            if (string.IsNullOrEmpty(orderId))
            {
                this.ShowWarningDialog("选择的工单号不能为空", UIStyle.Blue);
                return;
            }

            form.TargetQty = Convert.ToInt32(dataGridView.Rows[index].Cells["TargetQty"].Value.ToString());
            form.CreatedQty = Convert.ToInt32(dataGridView.Rows[index].Cells["CreatedQty"].Value.ToString());
            form.ItemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            form.ProductType = dataGridView.Rows[index].Cells["ProductType"].Value == null ? ""
                : dataGridView.Rows[index].Cells["ProductType"].Value.ToString();

            if (string.IsNullOrEmpty(form.ItemCode))
            {
                this.ShowWarningDialog($"选择的工单号[{orderId}]对应物料编码不能为空", UIStyle.Blue);
                return;
            }
            if (form.ItemCode.Length < 13)
            {
                this.ShowWarningDialog($"选择的工单号[{orderId}]对应物料编码[{form.ItemCode}]长度必须大于等于13位", UIStyle.Blue);
                return;
            }

            FormHelper.ShowSubForm(form);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(txtOrderId.Text.Trim()))
            {
                dict.Add("OrderId", txtOrderId.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtItemCode.Text.Trim()))
            {
                dict.Add("ItemCode", txtItemCode.Text.Trim());
            }
            if (!string.IsNullOrEmpty(dpFrom.Text.Trim()))
            {
                dict.Add("dpFromDate", dpFrom.Text.Trim());
            }

            if (!string.IsNullOrEmpty(dpEnd.Text.Trim()))
            {
                dict.Add("dpEndDate", dpEnd.Text.Trim());
            }

            if (cmbMatType.SelectedValue != null)
            {
                dict.Add("MatType", cmbMatType.SelectedValue.ToString());
            }

            if (cmbState.SelectedValue != null)
            {
                dict.Add("State", cmbState.SelectedValue.ToString());
            }
            int totalCount = 0;
            List<OrderInfo> list = logic.GetList(pagination.ActivePage, pagination.PageSize, dict, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrderForm form = new AddOrderForm();
            form.ParentPage = this;
            form.OrderId = string.Empty;
            FormHelper.ShowSubForm(form);
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White); return;
            }

            string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
            AddOrderForm form = new AddOrderForm();
            form.ParentPage = this;
            form.OrderId = orderId;
            FormHelper.ShowSubForm(form);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White); return;
            }
            string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该选项吗？", UIStyle.White))
            {
                return;
            }
            //已经生产了不能删除

            int row = logic.Delete(orderId);
            Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了选项工单");

            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.White);
                return;

            }
            //重新查询
            btnQuery_Click(sender, e);

        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderPage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }
    }
}
