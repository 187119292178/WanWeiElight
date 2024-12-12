using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Elight.Utility.Core;
using System.Configuration;
using Elight.Entity.Sys;
using Elight.Logic.Sys;

namespace Elight.WinForm.Page.OrderManage
{
    [PageCode("barcode-print")]
    public partial class PrintOrderPage : MyPage
    {
        string sMsg = "";
        private OrderLogic orderLogic;
        private BasTemplateLogic tempLogic;
        private WIPSNResLogic wipsnResLogic;
        private SysItemsDetailLogic detailLogic;

        LabelManager2.ApplicationClass labApp;

        public BasTemplate basTemplate { get; set; }
        private string username = "";
        private string password = "";
        private string serverUrl = "";

        public PrintOrderPage()
        {
            InitializeComponent();

            orderLogic = new OrderLogic();
            tempLogic = new BasTemplateLogic();
            wipsnResLogic = new WIPSNResLogic();
            detailLogic = new SysItemsDetailLogic();
            labApp = new LabelManager2.ApplicationClass();
            dataGridView.AutoGenerateColumns = false;
            CommonHelper.InitDataGridView(dataGridView, DataGridViewAutoSizeColumnsMode.AllCells);

            dgv2.AutoGenerateColumns = false;
            MyConfig myConfig = new MyConfig();
            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();
        }

        private void PrintOrderPage_Load(object sender, EventArgs e)
        {
            //默认显示未打印完成的工单信息
            txtKeywords.Select();
            txtKeywords.Focus();

            //BindMatType();

            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 绑定物料类型下拉框
        /// </summary>
        //private void BindMatType()
        //{
        //    string materialTypeId = ConfigurationManager.AppSettings["MaterialTypeId"];
        //    List<SysItemDetail> list = detailLogic.GetListByItemId(materialTypeId);
        //    cmbMatType.ValueMember = "EnCode";
        //    cmbMatType.DisplayMember = "Name";
        //    cmbMatType.DataSource = list;
        //}

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string orderId = txtKeywords.Text.Trim();
            string sn = txtSN.Text.Trim();
            //如果SN不为空则根据SN获取工单号
            if (!string.IsNullOrEmpty(sn) && string.IsNullOrEmpty(orderId))
            {
                WIP_SNRes SNRes = wipsnResLogic.GetOne(sn);
                if ((SNRes != null))
                {
                    orderId = SNRes.OrderId;
                }
            }

            List<OrderInfo> list = orderLogic.GetPrintOrder(orderId);
            dataGridView.DataSource = list;

            //条码明细
            int index = dataGridView.SelectedIndex;
            if (index >= 0)
            {
                orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
                if (!string.IsNullOrEmpty(orderId))
                {
                    int totalCount = 0;
                    List<WIP_SNRes> snRess = orderLogic.GetSNResbyOrderId(pagination.ActivePage, pagination.PageSize, orderId, ref totalCount);
                    pagination.TotalCount = totalCount;
                    dgv2.DataSource = snRess;
                }
            }
        }

        /// <summary>
        /// 测试打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择要打印的工单", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择要打印的工单", UIStyle.White);
                return;
            }

            string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            if (string.IsNullOrEmpty(orderId))
            {
                this.ShowWarningDialog("选择的工单号不能为空", UIStyle.Blue);
                return;
            }
        }

        /// <summary>
        /// 条码补打，直接查询SN然后选择打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRePrint_Click(object sender, EventArgs e)
        {
            string sn;
            WIP_SNRes sWIPSNRes = new WIP_SNRes();
            List<WIP_SNRes> sNReslist = new List<WIP_SNRes>();
            int index = dgv2.SelectedIndex;
            if (index >= 0)
            {
                sn = dgv2.Rows[index].Cells["SN"].Value.ToString();
                if (!string.IsNullOrEmpty(sn))
                {
                    sWIPSNRes = wipsnResLogic.GetOne(sn);
                    sNReslist.Add(sWIPSNRes);
                }
            }
            else
            {
                this.ShowWarningDialog("请选择要补打的条码SN记录", UIStyle.Blue);
                return;
            }


            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(sWIPSNRes.ItemCode, "SN_TYPE", "N");
            if (template == null)
            {
                sMsg = $"选择的条码SN[{sn}]对应料号[{sWIPSNRes.ItemCode}]没有上传产品机身打印模板，请先维护该料号的产品机身模板文件";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return;
            }
            DateTime dateTime = (DateTime)template.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName, username, password, template.HostURL);
            if (downloadFile < 0)
            {
                this.ShowWarningDialog("模板下载失败", UIStyle.Blue);
                return;
            }
            string LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;

            bool bFlag = PrintHelper.PrintLabel(labApp, LabelPath, 1, sNReslist, ref sMsg);
            if (bFlag)
            {
                List<WIPPrintLog> printLog = GetWIPPrintLogs(sNReslist);
                List<WIPSNTracking> list_sn = GetWIPSNTrackings(sNReslist);

                //将打印后的数据逻辑保存到数据库
                //1.补打记录保存到打印日志表；2.补打的SN保存到SN历史表
                int row = wipsnResLogic.RePrintSave(sNReslist[0].OrderId, 1, printLog, sNReslist[0].SN, sNReslist[0].SN, list_sn, ref sMsg);
            }
            else
            {
                this.ShowWarningDialog("打印失败打印模板加载异常！", UIStyle.Blue);

            }
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();
            WIP_SNRes list = new WIP_SNRes();
            string sn = "";
            int index = dgv2.SelectedIndex;
            if (index >= 0)
            {
                sn = dgv2.Rows[index].Cells["SN"].Value.ToString();
                if (!string.IsNullOrEmpty(sn))
                {
                    list = wipsnResLogic.GetOne(sn);
                }
            }
            else
            {
                this.ShowWarningDialog("请选择条码SN记录", UIStyle.Blue);
                return;
            }

            BasTemplate template = tempLogic.GetOnedeleteMark(list.ItemCode, "SN_TYPE", "N");
            if (template == null)
            {
                sMsg = $"选择的条码SN[{sn}]对应料号[{list.ItemCode}]没有上传产品机身打印模板，请先维护该料号的产品机身模板文件";
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return;
            }

            DateTime dateTime = (DateTime)template.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName, username, password, template.HostURL);
            if (downloadFile < 0)
            {
                this.ShowWarningDialog("模板下载失败", UIStyle.Blue);
                return;
            }
            string sFile = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;
            string sImageFile = sFile;
            //PrintHelper.PrintPreview(labApp, sFile, sn, ref sImageFile, ref sMsg);

            using (PreviewForm frm = new PreviewForm(sImageFile, sn, list.ItemCode, sFile))
            {
                //frm.SN = sn;
                //frm.ItemCode = list.ItemCode;
                frm.ShowDialog();
            }
        }

        #region 条码打印
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择要打印的工单", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择要打印的工单", UIStyle.White);
                return;
            }

            string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            if (string.IsNullOrEmpty(orderId))
            {
                this.ShowWarningDialog("选择的工单号不能为空", UIStyle.Blue);
                return;
            }
            //判断工单对应料号模板是否有维护
            //BasTemplate basTemplate = tempLogic.GetOne(itemCode, "SN");
            //if (basTemplate == null)
            //{
            //    this.ShowWarningDialog($"该工单对应的料号[{itemCode}]没有维护产品标签打印模板，请先维护好该打印模板", UIStyle.Blue);
            //    return;
            //}

            using (PrintSNForm frm = new PrintSNForm())
            {
                frm.OrderId = orderId;
                frm.ShowDialog();
            }
        }
        #endregion



        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            int index = dataGridView.SelectedIndex;
            if (index >= 0)
            {
                string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
                if (!string.IsNullOrEmpty(orderId))
                {
                    int totalCount = 0;
                    List<WIP_SNRes> snRess = orderLogic.GetSNResbyOrderId(pagination.ActivePage, pagination.PageSize, orderId, ref totalCount);
                    pagination.TotalCount = totalCount;
                    dgv2.DataSource = snRess;
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView.SelectedIndex;
            if (index >= 0)
            {
                string orderId = dataGridView.Rows[index].Cells["OrderId"].Value.ToString();
                if (!string.IsNullOrEmpty(orderId))
                {
                    int totalCount = 0;
                    List<WIP_SNRes> snRess = orderLogic.GetSNResbyOrderId(pagination.ActivePage, pagination.PageSize, orderId, ref totalCount);
                    pagination.TotalCount = totalCount;
                    dgv2.DataSource = snRess;
                }
            }
        }


        private List<WIPPrintLog> GetWIPPrintLogs(List<WIP_SNRes> list)
        {
            List<WIPPrintLog> logs = new List<WIPPrintLog>();

            if (list.Count > 0)
            {
                foreach (WIP_SNRes snRes in list)
                {
                    WIPPrintLog model = new WIPPrintLog();

                    model.ItemCode = snRes.ItemCode;
                    model.SN = snRes.SN;
                    model.OrderId = snRes.OrderId;
                    model.OperCode = "PRINTED_SN";
                    model.LabelType = "SN";
                    model.LabelName = basTemplate?.TemplateName;
                    model.LabelPath = basTemplate?.TemplateURL;
                    model.PrintType = 1;    //0-正常打印/1-补打
                    model.PrintNum = 1;
                    model.PrintParam = "";
                    model.PrintTime = DateTime.Now;
                    model.PrinterId = GlobalConfig.CurrentUser.Account;

                    logs.Add(model);
                }
            }

            return logs;
        }

        private List<WIPSNTracking> GetWIPSNTrackings(List<WIP_SNRes> list)
        {
            List<WIPSNTracking> wips = new List<WIPSNTracking>();
            if (list.Count > 0)
            {
                foreach (WIP_SNRes sn in list)
                {
                    WIPSNTracking model = new WIPSNTracking();
                    model.SN = sn.SN;
                    model.OrderId = sn.OrderId;
                    model.ItemCode = sn.ItemCode;
                    model.MatModel = sn.MatModel;
                    model.CustomerCode = "";
                    model.LineCode = "";
                    model.OperCode = "Create";
                    model.ResCode = "Create_Printed";
                    model.ModuleSN = "";
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = sn.CreateUser;
                    model.CartonNo = "";
                    model.PalletNO = "";
                    model.SNStatus = "INIT";
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    model.IsFinished = "N";
                    model.FinishTime = null;

                    wips.Add(model);
                }
            }

            return wips;
        }

        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }
    }
}
