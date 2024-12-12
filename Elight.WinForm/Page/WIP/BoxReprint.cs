using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.WinForm.Common;
using Org.BouncyCastle.Asn1.Cmp;
using Sunny.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elight.Utility.Core;

namespace Elight.WinForm.Page.WIP
{
    public partial class BoxReprint : UIForm
    {
        private BasRuleSerialLogic ruleLogic;
        private WIPPackagingBoxLogic boxLogic;
        private WIPPrintLogic printLogic;
        private OrderLogic logic;

        private string sMsg = "";
        private string OperCode = "PACKINGBOX";
        private int Qty = 0;
        private string ScanSN = "";
        private string sItemCode = "";
        private string sOrderId = "";
        private string sCartonNo = "";
        private string username = "";
        private string password = "";
        private string serverUrl = "";
        private string ruleName = "BOX_RULE";
        private OrderInfo oracle = new OrderInfo();
        private WIP_PackagingBox wIP_PackagingBox = new WIP_PackagingBox();
        private BasTemplateLogic tempLogic;
        LabelManager2.ApplicationClass labApp;

        /// <summary>
        /// 默认装箱数量
        /// </summary>
        private List<WIPSNTracking> ScanList = new List<WIPSNTracking>();
        private WIP_SNRes SNResInfo;
        /// <summary>
        /// 模板类型
        /// </summary>
        public string TemplateType { get; set; }

        public BasTemplate basTemplate { get; set; }

        private WIPSNResLogic snResLogic;
        private WIPSNTrackingLogic wipsnLogic;


        public BoxReprint()
        {
            InitializeComponent();
            logic = new OrderLogic();
            labApp = new LabelManager2.ApplicationClass();

            tempLogic = new BasTemplateLogic();
            ruleLogic = new BasRuleSerialLogic();
            snResLogic = new WIPSNResLogic();
            boxLogic = new WIPPackagingBoxLogic();
            wipsnLogic = new WIPSNTrackingLogic();
            printLogic = new WIPPrintLogic();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();

            //取消补打按钮功能，扫描条码后直接进行打印
            btnSave.Visible = false;

            if (TemplateType == "COLOR_TYPE")
                this.Text = "彩盒标签补打";
            else
                this.Text = "外箱标签补打";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<WIP_SNRes> sNReslist = new List<WIP_SNRes>();

            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行补打", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index >= 0)
            {
                string sn = dataGridView.Rows[index].Cells["SN"].Value.ToString();
                if (!string.IsNullOrEmpty(sn))
                {
                    WIP_SNRes list = snResLogic.GetOne(sn);
                    sNReslist.Add(list);
                }
            }
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(sNReslist[0].ItemCode.Trim().ToString(), "COLOR_TYPE", "N");
            if (template == null)
            {
                this.ShowWarningDialog("产品没有上传打印模板，请上传后在打印", UIStyle.Blue);
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
                //1.修改工单表已打印数量,；2.修改条码资源表状态；3.打印记录保存到打印日志表；4.打印的SN保存到SN当前表
                int row = snResLogic.RePrintSave(sNReslist[0].OrderId, 1, printLog, sNReslist[0].SN, sNReslist[0].SN, list_sn, ref sMsg);
            }
            else {
                this.ShowWarningDialog("打印失败打印模板加载异常！", UIStyle.Blue);

            }
        }


        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ScanSN = txtSN.Text.Trim();
                if (string.IsNullOrEmpty(ScanSN))
                    return;

                if(CheckScan(ScanSN, ref sMsg) == false)
                {
                    this.ShowWarningDialog(sMsg, UIStyle.Blue);
                    return;
                }
                else
                {
                    AddScanInfo(SNResInfo);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = ScanList;

                    RePrintBOX(SNResInfo);
                    txtSN.Text = "";
                    txtSN.Select();
                    txtSN.Focus();
                }
            }
        }


        private bool CheckScan(string sInput, ref string msg)
        {
            msg = "";
            bool bFlag = true;

            //1.验证条码是否存在
            SNResInfo = snResLogic.GetSNResInfo(sInput);
            if (SNResInfo == null)
            {
                msg = $"条码[{sInput}]在系统中不存在，请重新扫描";
                return false;
            }

            //2.验证是否已经扫了包装工站，是否打了报废
            WIPSNTracking wipsn = wipsnLogic.GetOne(sInput);
            if (wipsn != null)
            {
                if (wipsn.OperCode == "Create")
                {
                    msg = $"条码[{sInput}]没有过彩盒包装工站，不能补打";
                    return false;
                }
            }
            else
            {
                msg = $"条码[{sInput}]没有打印产品条码，不能补打彩盒标签";
                return false;
            }

            //3.判断彩盒标签模板文件是否有上传
            BasTemplate template = tempLogic.GetOnedeleteMark(SNResInfo.ItemCode, TemplateType, "N");
            if ((template == null))
            {
                msg = $"条码[{sInput}]对应料号[{SNResInfo.ItemCode}]没有上传彩盒打印模板文件";
                return false;
            }
            return bFlag;
        }


        private void RePrintBOX(WIP_SNRes sNRes)
        {
            List<WIP_SNRes> sNReslist = new List<WIP_SNRes>();
            sNReslist.Add(sNRes);
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(sNRes.ItemCode.Trim().ToString(), TemplateType, "N");
            string typeName = "彩盒打印模板";
            if (TemplateType == "BOX_TYPE")
                typeName = "外箱打印模板";

            if (template == null)
            {
                this.ShowWarningDialog($"产品对应料号[{SNResInfo.ItemCode}]没有上传{typeName}，请上传后在打印", UIStyle.Blue);
                return;
            }
            DateTime dateTime = (DateTime)template.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName, username, password, template.HostURL);
            if (downloadFile < 0)
            {
                this.ShowWarningDialog($"产品对应料号[{SNResInfo.ItemCode}]{typeName}下载失败", UIStyle.Blue);
                return;
            }
            string LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;
            int qty = template.PrintCount == null ? 1 : (int)template.PrintCount;
            bool bFlag = PrintHelper.PrintLabel(labApp, LabelPath, qty, sNReslist, ref sMsg);
            if (!bFlag)
            {
                this.ShowWarningDialog($"{typeName}补打失败：{sMsg}", UIStyle.Blue);
            }

            //记录补打日志
            List<WIPPrintLog> logs = GetWIPPrintLogs(sNReslist);
            printLogic.Insert(logs[0]);
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
                    model.OperCode = OperCode;
                    model.LabelType = TemplateType;
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
                    model.OperCode = "BOX";
                    model.ResCode = "REPRINT_BOX";
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

        private void AddScanInfo(WIP_SNRes snRes)
        {
            WIPSNTracking model = new WIPSNTracking();
            model.SN = snRes.SN;
            model.ItemCode = snRes.ItemCode;
            model.OrderId = snRes.OrderId;
            model.MatModel = snRes.MatModel;
            model.CustomerCode = "";
            model.LineCode = "";
            model.OperCode = OperCode;
            model.ResCode = "";
            model.ModuleSN = "";
            model.OpeartionTime = DateTime.Now;
            model.InLineTime = DateTime.Now;
            model.OperationId = GlobalConfig.CurrentUser.Account;
            model.PalletNO = "";
            model.SNStatus = "GOOD";
            model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            model.IsFinished = "Y";

            if (ScanList != null && !ScanList.Exists(t => t.SN == snRes.SN))
                ScanList.Add(model);
        }


    }
}
