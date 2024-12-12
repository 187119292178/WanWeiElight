using Elight.Entity;
using Elight.Entity.WanWei;
using Elight.Logic;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.Utility.Core;
using Elight.WinForm.Common;
using LabelManager2;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.WIP
{
    public partial class RePrintPacking : UIForm
    {
        private BasRuleSerialLogic ruleLogic;
        private WIPPackagingBoxLogic boxLogic;
        private WIPPrintLogic printLogic;
        private OrderLogic logic;

        private string sMsg = "";
        private string OperCode = "PACKING";
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
        private BaseItemLogic itemLogic;
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
        private List<WIPSNTracking> WIPSNList = new List<WIPSNTracking>();

        public RePrintPacking()
        {
            InitializeComponent();
        }

        private void RePrintPacking_Load(object sender, EventArgs e)
        {
            logic = new OrderLogic();
            labApp = new LabelManager2.ApplicationClass();

            tempLogic = new BasTemplateLogic();
            ruleLogic = new BasRuleSerialLogic();
            snResLogic = new WIPSNResLogic();
            boxLogic = new WIPPackagingBoxLogic();
            wipsnLogic = new WIPSNTrackingLogic();
            printLogic = new WIPPrintLogic();
            itemLogic = new BaseItemLogic();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();
        }

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (ScanList != null)
                {
                    ScanList.Clear();
                }

                if (string.IsNullOrEmpty(txtSW.Text.Trim()))
                {
                    this.ShowWarningDialog($"SW版号不能为空", UIStyle.Blue);
                    txtSW.Select();
                    txtSW.Focus();

                    return;
                }
                ScanSN = txtSN.Text.Trim();
                if (string.IsNullOrEmpty(ScanSN))
                    return;

                ScanList = wipsnLogic.GetPackings(ScanSN);
                if (CheckScan(ScanList, ref sMsg) == false)
                {
                    this.ShowWarningDialog($"不满足补打条件：{sMsg}", UIStyle.Blue);
                    return;
                }

                dataGridView.DataSource = ScanList;
                txtSN.Text = "";
                txtSN.Focus();

                //打印条码
                RePrintBOX(ScanList);
                //WIPSNList.Clear();
            }
        }

        private bool CheckScan(List<WIPSNTracking> wips, ref string msg)
        {
            msg = "";
            bool bFlag = true;

            //1.验证条码是否存在
            if (wips == null || wips.Count == 0)
            {
                msg = $"条码SN或者箱号[{ScanSN}]不存在";
                return false;
            }
            if (string.IsNullOrEmpty(wips[0].CartonNo))
            {
                msg = $"条码SN的箱号为空";
                return false;
            }

            //3.判断标签模板文件是否有上传
            BasTemplate template = tempLogic.GetOnedeleteMark(wips[0].ItemCode, TemplateType, "N");
            if ((template == null))
            {
                msg = $"条码[{wips[0].SN}]对应料号[{wips[0].ItemCode}]没有上传外箱打印模板文件";
                return false;
            }
            return bFlag;
        }

        private void RePrintBOX(List<WIPSNTracking> wips)
        {
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(wips[0].ItemCode.Trim().ToString(), TemplateType, "N");
            string typeName = "彩盒打印模板";
            if (TemplateType == "BOX_TYPE")
                typeName = "外箱打印模板";

            if (template == null)
            {
                this.ShowWarningDialog($"产品对应料号[{wips[0].ItemCode}]没有上传{typeName}，请上传后在打印", UIStyle.Blue);
                return;
            }
            System.DateTime dateTime = (System.DateTime)template.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName, username, password, template.HostURL);
            if (downloadFile < 0)
            {
                this.ShowWarningDialog($"产品对应料号[{wips[0].ItemCode}]{typeName}下载失败", UIStyle.Blue);
                return;
            }
            string LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;
            int qty = template.PrintCount == null ? 1 : (int)template.PrintCount;

            //获取物料编码型号规格
            BasItem item = itemLogic.Get(wips[0].ItemCode);
            if ((item == null))
            {
                this.ShowWarningDialog($"料号[{wips[0].ItemCode}]在系统中不存在", UIStyle.Blue);
                return;
            }

            bool bFlag = PrintHelper.PrintCartonLabel(labApp, LabelPath, qty, txtSW.Text.Trim(), ScanList, item.ItemDesc, ref sMsg);
            if (!bFlag)
            {
                this.ShowWarningDialog($"{typeName}补打失败：{sMsg}", UIStyle.Blue);
            }

            //记录补打日志
            List<WIPPrintLog> logs = GetWIPPrintLogs(ScanList);
            printLogic.Insert(logs[0]);
        }

        private List<WIPPrintLog> GetWIPPrintLogs(List<WIPSNTracking> list)
        {
            List<WIPPrintLog> logs = new List<WIPPrintLog>();

            if (list.Count > 0)
            {
                foreach (WIPSNTracking snRes in list)
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
                    model.PrintTime = System.DateTime.Now;
                    model.PrinterId = GlobalConfig.CurrentUser.Account;

                    logs.Add(model);
                }
            }

            return logs;
        }

        private void txtSW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSW.Text.Trim()))
                    return;
                txtSN.Select();
                txtSN.Focus();
            }
        }
    }
}
