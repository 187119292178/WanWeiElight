using Elight.Entity.Sys;
using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.Sys;
using Elight.Logic.WIP;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
using Elight.WinForm.Common;
using System.Web;
using Mysqlx.Crud;

namespace Elight.WinForm.Page.OrderManage
{
    public partial class OrderInput : UIForm
    {
        private SysItemsDetailLogic detailLogic;
        private OrderLogic orderLogic;
        private WIPSNResLogic snresLogic;
        private BasRuleSerialLogic ruleLogic;
        private string sMsg = "";
        private OrderInfo orderInfo = new OrderInfo();
        private string RuleName = "SN_RULE";
        private int MaxCount = 46655;   //相同前缀固定值一天最多只能生成这么多条码

        public OrderPage ParentPage { get; set; }
        /// <summary>
        /// 工单号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 工单数量
        /// </summary>
        public int TargetQty { get; set; }
        /// <summary>
        /// 已投数量(已生码数量)
        /// </summary>
        public int CreatedQty { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// 生产类型
        /// </summary>
        public string ProductType { get; set; }

        public OrderInput()
        {
            InitializeComponent();

            detailLogic = new SysItemsDetailLogic();
            orderLogic = new OrderLogic();
            snresLogic = new WIPSNResLogic();
            ruleLogic = new BasRuleSerialLogic();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OrderInput_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        /// <summary>
        /// 根据选择的工单绑定界面控件
        /// </summary>
        private void InitForm()
        {
            txtOrderId.Text = Id;
            txtQty.Text = TargetQty.ToString();
            txtInputed.Text = CreatedQty.ToString();
            txtCanQty.Text = (TargetQty - CreatedQty).ToString();

            //如果可投数量为0，则保存按钮不可用
            if(TargetQty - CreatedQty <= 0)
            {
                btnSave.Enabled = false;
            }
            else
                { btnSave.Enabled = true; }

            string currentDay = DateTime.Now.ToString("yyyy-MM-dd");
            dpProductDate.Text = currentDay;

            txtInputQty.Text = txtCanQty.Text;  //批投数量默认等于可投数量
            txtInputQty.Select();
            txtInputQty.Focus();

            if (txtInputQty.Text == "0")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            BindRuleType();
            BindProductType();
            BindSpecialCode();

            if (!string.IsNullOrEmpty(ProductType))
                cmbProductType.SelectedValue = ProductType;

            //显示工单已经生成的条码
            BindSNList();
            getOracle();

        }

        //生产类型下拉框数据绑定
        private void BindProductType()
        {
            string ruleCodeTypeId = ConfigurationManager.AppSettings["ProductTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("product_type");
            cmbProductType.ValueMember = "EnCode";
            cmbProductType.DisplayMember = "Name";
            cmbProductType.DataSource = list;
        }

        //编码规则下拉框数据绑定
        private void BindRuleType()
        {
            string ruleCodeTypeId = ConfigurationManager.AppSettings["RuleCodeTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("coderule");  
            cmbRule.ValueMember = "EnCode";
            cmbRule.DisplayMember = "Name";
            cmbRule.DataSource = list;
        }

        //特殊代码下拉框数据绑定
        private void BindSpecialCode()
        {
            string itemId = ConfigurationManager.AppSettings["ProgrameId"];
           // List<SysItemDetail> list = detailLogic.GetListByItemId(itemId);
            List<SysItemDetail> list = detailLogic.GetItemDetailList("programe_code");
            cmbSpecial.ValueMember = "EnCode";
            cmbSpecial.DisplayMember = "Name";
            cmbSpecial.DataSource = list;
        }

        private void BindSNList()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                int totalCount = 0;
                List<WIP_SNRes> list = snresLogic.GetList(pagination.ActivePage, pagination.PageSize, Id, ref totalCount);
                pagination.TotalCount = totalCount;
                dataGridView.DataSource = list;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool bFlag = CheckInput();
            if (bFlag == false)
            {
                return;
            }

            //确定是否生成条码
            sMsg = $"您确定要为工单号[{Id}]，选择编码规则[{cmbRule.Text}]，特殊代码[{cmbProductType.Text}]，生产日期[{dpProductDate.Text}]的配置，生成[{txtInputQty.Text}]个产品序列号条码？";
            if (!this.ShowAskDialog(sMsg, UIStyle.Blue))
            {
                return;
            }

            int qty = Convert.ToInt32(txtInputQty.Text.Trim());

            try
            {
                bFlag = CreateSNBarcode(ItemCode, dpProductDate.Text, qty);

                if (bFlag)
                {
                    BindSNList();
                    this.ShowSuccessDialog($"工单[{Id}]批投 {qty} 个成功", UIStyle.Blue);
                }

                //刷新界面，防止重复生码
                OrderInfo order = orderLogic.Get(Id);
                if(order != null)
                {
                    txtInputed.Text = order.CreatedQty.ToString();
                    txtCanQty.Text = (order.TargetQty - order.CreatedQty).ToString();
                    txtInputQty.Text = txtCanQty.Text;
                    if (txtInputQty.Text == "0")
                        btnSave.Enabled = false;
                    else
                        btnSave.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                sMsg = $"工单批投出现异常：{ex.Message}";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
            }
        }

        private bool CheckInput()
        {
            bool bFlag = true;

            if (string.IsNullOrEmpty(Id))
            {
                sMsg = "工单号不能为空";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (string.IsNullOrEmpty(ItemCode))
            {
                sMsg = "工单对应的物料编码不能为空";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (string.IsNullOrEmpty(dpProductDate.Text))
            {
                sMsg = "生产日期不能为空";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (cmbProductType.SelectedValue.ToString().Length != 1)
            {
                sMsg = "生产类型配置的值的长度必须为1位";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (cmbSpecial.SelectedValue.ToString().Length != 1)
            {
                sMsg = "特殊代码配置的值的长度必须为1位";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (ItemCode.Length < 13)
            {
                sMsg = "物料编码的长度必须大于13位";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            if (CommonHelper.IsInt(ItemCode.Substring(0, 3)) == false)
            {
                sMsg = "物料编码的前3位必须是数字";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            try
            {
                //已投数量不能超过工单数量
                int targetqty = Convert.ToInt32(txtQty.Text);
                if (CreatedQty >= targetqty)
                {
                    this.ShowWarningDialog("工单数量已经全部生成条码，不能再多生码", UIStyle.Blue);
                    return false;
                }
                int qty = Convert.ToInt32(txtInputQty.Text.Trim());
                if (qty <= 0)
                {
                    this.ShowWarningDialog("批投数量必须为正整数", UIStyle.Blue);
                    return false;
                }
                if(qty > qty){

                    this.ShowWarningDialog("批投数量不能大剩余工单数量", UIStyle.Blue);
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.ShowWarningDialog("批投数量必须为正整数", UIStyle.Blue);
                return false;
            }

            return bFlag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="productDate">生产日期(yyyy-MM-dd)</param>
        /// <param name="iQty">生码数量</param>
        private bool CreateSNBarcode(string itemCode, string productDate, int iQty)
        {
            string productType = "";
            string specailCode = "";
            string matModel = "";
            string modelLast = "";
            string workdate = "";
            string year = "";
            string year19 = "";
            string year17 = "";
            string month = "";
            string day = "";
            string sPrefix = "";    
            string sPrefix19 = "";    //1位生产类型+9位机型代码+1位机型代码后缀+月+日+特殊代码+2位年份
            string sPrefix17 = "";   //1位生产类型+9位机型代码+1位机型代码后缀+年+月+日+特殊代码
            int iMaxSeq = 1;

            bool bFlag = true;
            matModel = RuleCodeHelper.GetMatModel(itemCode, ref sMsg);
            if (matModel.Length != 9)
            {
                if (string.IsNullOrEmpty(sMsg))
                    sMsg = $"物料料号[{itemCode}]生成的机型代码[{matModel}]长度不是9位";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }
            //机型代码后缀:取物料编码第14位的内容，如果总长度没有14位，则为0，如果第14位为-或者空字符串啥的也默认为0//matModelsubstring(atModel.rength-1，1)
            modelLast = RuleCodeHelper.GetMatModelLast(itemCode);    //机型代码后缀需要讨论 modelLast = matModel.Substring(matModel.Length - 1, 1);
            productType = cmbProductType.SelectedValue.ToString();
            specailCode = cmbSpecial.SelectedValue.ToString();
            workdate = productDate.Replace("-", "").Replace("/", "");
            year = workdate.Substring(2, 2);
            year19 = CommonHelper.TransformBase(year, 10, 36, "Y").PadLeft(2, '0');    //取年份后2位转2位36进制
            year17 = CommonHelper.TransformBase(year, 10, 36, "Y").PadLeft(1, '0');    //取年份后2位转1位36进制
            month = workdate.Substring(4, 2);
            month = CommonHelper.TransformBase(month, 10, 36, "M");      //月份转1位36进制
            day = workdate.Substring(6, 2);
            day = CommonHelper.TransformBase(day, 10, 36, "D");      //日期转1位36进制


            //获取流水码对应变化的固定值 -- 19位的共16位，17位的共14位
            sPrefix19 = productType + matModel + modelLast + month + day + specailCode + year19;

            sPrefix17 = productType + matModel + year17 + month + day + specailCode ;

            if (cmbRule.Text.Contains("19") && sPrefix19.Length != 16)
            {
                sMsg = "产品序列号编码规则生成有问题，请联系系统管理员";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }
            else if (cmbRule.Text.Contains("17") && sPrefix17.Length != 14)
            {
                sMsg = "产品序列号编码规则生成有问题，请联系系统管理员";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }
            if (cmbRule.Text.Contains("19"))
            {
                sPrefix = sPrefix19;
            }
            else if (cmbRule.Text.Contains("17"))
            {
                sPrefix = sPrefix17;
            }

            //根据固定值获取最大流水码
            BasRuleSerial serial = ruleLogic.GetRuleSerial(RuleName, sPrefix);
            if (serial == null)
            {
                iMaxSeq = 0;

                serial = new BasRuleSerial();
                serial.RULE_NAME = RuleName;
                serial.PREFIX = sPrefix;
            }
            else
            {
                iMaxSeq = serial.LAST_SEQNO;
            }

            //判断不能超过3位36进制的最大值
            if ((iMaxSeq + iQty) > MaxCount)
            {
                sMsg = "当天生码数量已经超过3位流水码最大值，请减小批投数量(生码数量)";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            serial.MatModel = matModel;
            serial.ModelSuffix = modelLast;
            serial.YearCode = year;
            serial.MonthCode = month;
            serial.DayCode = day;
            serial.ProductDate = productDate;

            //获取产品序列号列表
            List<string> snList = null;
            if (cmbRule.Text.Contains("19"))
            {

                serial.YearCode = year19;
                snList = GetSNList(serial, productType, specailCode, iQty, "19");

            }
            else if (cmbRule.Text.Contains("17"))
            {
               serial.YearCode = year17;
               snList = GetSNList(serial, productType, specailCode, iQty, "17");
            }
            List<WIP_SNRes> snResList = GetWIPSNResList(snList);

            //保存条码到条码资源表，同时保存最大序列号信息
            string ruleCode = cmbRule.SelectedValue.ToString();
            int row = ruleLogic.CreateBarcode(snResList, serial, ruleCode, ref sMsg);
            if (row <= 0)
            {
                sMsg = $"工单[{Id}]批投失败：{sMsg}";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return false;
            }

            //if (string.IsNullOrEmpty(orderInfo.SNRule)||orderInfo.SNRule == null) {
            //    orderInfo.SNRule = cmbRule.SelectedValue.ToString();
            //  int order =  orderLogic.UpdateSNRule(orderInfo);
            //}

            return bFlag;
        }



        /// <summary>
        /// 根据生码数量得到条码集合
        /// </summary>
        /// <param name="sPrefix">固定值</param>
        /// <param name="iMaxSeq">最大流水码</param>
        /// <param name="qty">生码数量</param>
        /// <returns></returns>
        private List<string> GetSNList(string sPrefix, int iMaxSeq, int qty)
        {
            List<string> list = new List<string>();
            int seqNo;
            string sn = "";

            if (qty > 0)
            {
                for (int i = 1; i <= qty; i++)
                {
                    seqNo = iMaxSeq + i;
                    sn = sPrefix + CommonHelper.TransformBase(seqNo.ToString(), 10, 36,"M").PadLeft(3, '0');
                    list.Add(sn);
                }
            }

            return list;
        }

        private List<string> GetSNList(BasRuleSerial ruleSerial, int qty)
        {
            List<string> list = new List<string>();
            int seqNo;
            string sn = "";

            if (qty > 0)
            {
                for (int i = 1; i <= qty; i++)
                {
                    seqNo = ruleSerial.LAST_SEQNO + i;
                    sn = ruleSerial.PREFIX + CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0');
                    list.Add(sn);

                    if (i == qty)
                    {
                        ruleSerial.LAST_SEQNO = seqNo;
                        ruleSerial.LAST_SERIALNO = CommonHelper.TransformBase(seqNo.ToString(), 10, 36,"Y").PadLeft(3, '0');
                    }
                }
            }

            return list;
        }
        
        private List<string> GetSNList(BasRuleSerial ruleSerial,string productType, string specailCode, int qty, string tpye)
        {
            List<string> list = new List<string>();
            int seqNo;
            string sn = "";

            if (qty > 0)
            {
                for (int i = 1; i <= qty; i++)
                {
                    seqNo = ruleSerial.LAST_SEQNO + i;
                    if (tpye.Equals("19"))
                    {
                        sn = productType + ruleSerial.MatModel + ruleSerial.ModelSuffix + ruleSerial.MonthCode + ruleSerial.DayCode + CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0') + specailCode + ruleSerial.YearCode ;
                    }
                    else if (tpye.Equals("17"))
                    {
                        sn = productType + ruleSerial.MatModel+ruleSerial.YearCode + ruleSerial.MonthCode + ruleSerial.DayCode + CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0') + specailCode;
                    }
                    list.Add(sn);

                    if (i == qty)
                    {
                        ruleSerial.LAST_SEQNO = seqNo;
                        ruleSerial.LAST_SERIALNO = CommonHelper.TransformBase(seqNo.ToString(), 10, 36,"M").PadLeft(3, '0');
                    }
                }
            }

            return list;
        }
        
        private List<string> Get17SNList(BasRuleSerial ruleSerial, int qty , string tpye)
        {
            List<string> list = new List<string>();
            int seqNo;
            string sn = "";

            if (qty > 0)
            {
                for (int i = 1; i <= qty; i++)
                {
                    seqNo = ruleSerial.LAST_SEQNO + i;

                    if (tpye.Equals("17"))
                    {
                        sn = ruleSerial.PREFIX + CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0');

                    }
                    else if (tpye.Equals("19"))
                    {
                        sn = ruleSerial.PREFIX + CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0');

                    }

                    list.Add(sn);

                    if (i == qty)
                    {
                        ruleSerial.LAST_SEQNO = seqNo;
                        ruleSerial.LAST_SERIALNO = CommonHelper.TransformBase(seqNo.ToString(), 10, 36,"M").PadLeft(3, '0');
                    }
                }
            }

            return list;
        }
        
        private List<WIP_SNRes> GetWIPSNResList(List<string> list)
        {
            List<WIP_SNRes> snRess = new List<WIP_SNRes>();
            if (list != null && list.Count > 0)
            {
                foreach (string sn in list)
                {
                    WIP_SNRes model = new WIP_SNRes();

                    model.SN = sn;
                    model.OrderId = Id;
                    model.ItemCode = ItemCode;
                    model.SNStatus = "INIT";
                    model.PrintStatus = "N";
                    model.SNType = "SN";
                    model.PrintNum = 0;
                    model.IsEnabled = "Y";
                    model.DeleteMark = "N";
                    model.CreateTime = DateTime.Now;
                    model.CreateUser = GlobalConfig.CurrentUser.Account;
                    model.ModifyTime = model.CreateTime;
                    model.ModifyUser = model.CreateUser;

                    snRess.Add(model);
                }
            }

            return snRess;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pagination_Click(object sender, EventArgs e)
        {
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            BindSNList();
        }

        private void getOracle() {
           orderInfo =  orderLogic.Get(txtOrderId.Text);
            if (!string.IsNullOrEmpty(orderInfo.SNRule)|| orderInfo.SNRule != null) {
                cmbRule.SelectedValue = orderInfo.SNRule;
                cmbRule.Enabled = false;
            }
        }
    }
}
