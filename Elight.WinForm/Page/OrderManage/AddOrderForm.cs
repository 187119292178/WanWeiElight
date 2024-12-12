using Elight.Entity.DTO.Parms;
using Elight.Entity.Sys;
using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Elight.WinForm.Page.Common;
using NPOI.SS.Formula.Functions;
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
using static Org.BouncyCastle.Math.Primes;
using ZXing.Common;
using Elight.Entity;
using Elight.Logic;
//using Windows.ApplicationModel.Store;

namespace Elight.WinForm.Page.OrderManage
{
    public partial class AddOrderForm : UIForm
    {
        public OrderPage ParentPage { get; set; }
        private SysItemsDetailLogic detailLogic;
        private OrderLogic orderLogic;
        private BaseItemLogic baseItemLogic;

        /// <summary>
        /// 工单号
        /// </summary>
        public string OrderId { get; set; }
        private string MatType = "";

        /// <summary>
        /// 物料查询窗体
        /// </summary>
        private ItemCodeQuery itemQuery;


        public AddOrderForm()
        {
            InitializeComponent();
            baseItemLogic = new BaseItemLogic();

            detailLogic = new SysItemsDetailLogic();
            orderLogic = new OrderLogic();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(OrderId))
            {
                this.Text = "新增工单";
                txtOrderId.Enabled = true;
                string currentDay = DateTime.Now.ToString("yyyy-MM-dd");
                dpReleaseDate.Text = currentDay;
                dpFinshDate.Text = currentDay;
            }
            else
            {
                this.Text = "修改工单";
                txtOrderId.Enabled = false;
            }

            BindProductType();
            BindOrderType();
            BindModel();
        }

        /// <summary>
        /// 生产类型下拉框
        /// </summary>
        private void BindProductType()
        {
            string productTypeId = ConfigurationManager.AppSettings["ProductTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("product_type");
            cmbType.ValueMember = "EnCode";
            cmbType.DisplayMember = "Name";
            cmbType.DataSource = list;

        }

        private void BindOrderType()
        {
            string orderTypeId = ConfigurationManager.AppSettings["OrderTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("ordertype");
            cmbOrderType.ValueMember = "EnCode";
            cmbOrderType.DisplayMember = "Name";
            cmbOrderType.DataSource = list;
        }

        private void BindModel()
        {
            if (!string.IsNullOrEmpty(OrderId))
            {
                OrderInfo entity = orderLogic.Get(OrderId);
                if (entity != null)
                {
                    txtOrderId.Text = entity.OrderId;
                    txtQty.Value = entity.TargetQty.Value;
                    txtItemCode.Text = entity.ItemCode;
                    txtCreateQty.Text = entity.CreatedQty.ToString();
                    txtMatType.Text = entity.MatType;
                    MatType = entity.MatType;
                    if (!string.IsNullOrEmpty(txtItemCode.Text))
                    {
                        BasItem entityItem = baseItemLogic.Get(txtItemCode.Text);
                        if (entity != null)
                        {
                            txtItemCode.Text = entityItem.ItemCode;
                            txtItemName.Text = entityItem.ItemName;
                            txtItemDesc.Text = entityItem.ItemDesc;
                            
                        }
                    }
                    //其他几个要查物料表
                    cmbType.SelectedValue = entity.ProductType;
                    dpReleaseDate.Text = ((DateTime)entity.ReleaseDate).ToString("yyyy-MM-dd");
                    dpFinshDate.Text = ((DateTime)entity.PlanEndDate).ToString("yyyy-MM-dd");
                    txtRemark.Text = entity.Remark;
                }
            }
        }

        /// <summary>
        /// 物料查询选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //2 实例化查询子窗体
            itemQuery = new ItemCodeQuery();

            itemQuery.sendVauleEvent += new SendValue(fMain_ReceiveValueEvent);
            itemQuery.ShowDialog();
        }

        //父窗体接收参数事件
        public void fMain_ReceiveValueEvent(BasItemParams param)
        {
            if (param != null)
            {
                txtItemCode.Text = param.itemCode;
                txtItemName.Text = param.itemName;
                txtItemDesc.Text = param.itemDesc;
                //txtModel.Text = param.MatModel;
                MatType = param.MatType;
                txtMatType.Text = param.MatType;
                //txtPackQty.Text = param.PackQty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrderId))
            {
                DoAddUpdate("ADD");
            }
            else
            {
                DoAddUpdate("UPDATE");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoAddUpdate(string action)
        {
            bool flag = ChechEmpty();
            if (!flag)
            {
                return;
            }

            OrderInfo model = new OrderInfo();
            model.OrderId = txtOrderId.Text.Trim();
            model.TargetQty = txtQty.Value;
            model.ItemCode = txtItemCode.Text.Trim();
            //model.MatModel = txtModel.Text.Trim();
            model.MatType = MatType;
            model.PlanEndDate = dpFinshDate.Value;
            model.ReleaseDate = dpReleaseDate.Value;
            model.ProductType = cmbType.SelectedValue.ToString();
            model.Remark = txtRemark.Text.Trim();
            model.OrderType = cmbOrderType.SelectedValue.ToString();

            if (action == "ADD")
            {
                model.OrderStatus = "INIT";
                model.CreatedQty = 0;
                model.InputQty = 0;
                model.OutPutQty = 0;
                model.PackQty = 0;
                model.ScrapQty = 0;
                model.PrintedQty = 0;
                model.BoxQty = 0;
                model.CustomerCode = "";
                model.LineCode = "";
                model.RouteCode = "";
                model.BOMNo = "";

                model.CreateTime = DateTime.Now;
                model.ModifyTime = DateTime.Now;
                model.CreateUser = GlobalConfig.CurrentUser.Id; 
                model.ModifyUser = GlobalConfig.CurrentUser.Id;
                model.DeleteMark = "N";
                model.IsEnabled = "Y";
            }
            else
            {
                model.ModifyUser = GlobalConfig.CurrentUser.Id;
                model.ModifyTime = DateTime.Now;
            }

            int row = 0;
            if (action == "ADD")
                row = orderLogic.Insert(model);
            else
                row = orderLogic.Update(model);

            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.Blue);
                return;
            }

            ParentPage.Init();
            FormHelper.subForm = null;
            this.Close();
        }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty()
        {
            bool bFlag = true;
            if (StringHelper.IsNullOrEmpty(txtOrderId.Text))
            {
                this.ShowWarningDialog("工单号不能为空", UIStyle.Blue);
                return false;
            }
            if (txtQty.Text == "0")
            {
                this.ShowWarningDialog("工单数量必须大于0", UIStyle.Blue);
                return false;
            }

            if (StringHelper.IsNullOrEmpty(txtItemCode.Text))
            {
                this.ShowWarningDialog("物料编码不能为空", UIStyle.Blue);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtItemName.Text))
            {
                this.ShowWarningDialog("物料名称不能为空", UIStyle.Blue);
                return false;
            }
            //if (StringHelper.IsNullOrEmpty(txtModel.Text))
            //{
            //    this.ShowWarningDialog("机型代码不能为空", UIStyle.Blue);
            //    return false;
            //}

            //if(txtModel.Text.Trim().Length != 9)
            //{
            //    this.ShowWarningDialog("机型代码的长度规定必须为9位", UIStyle.White);
            //    return false;
            //}

            if (StringHelper.IsNullOrEmpty(dpReleaseDate.Text))
            {
                this.ShowWarningDialog("下达日期不能为空", UIStyle.White);
                return false;
            }

            return bFlag;
        }


    }
}
