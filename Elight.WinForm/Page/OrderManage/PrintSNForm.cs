using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.Utility.Files;
using Elight.WinForm.Common;
using Google.Protobuf.Collections;
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


namespace Elight.WinForm.Page.OrderManage
{
    public partial class PrintSNForm : UIForm
    {
        private OrderLogic orderLogic;
        private BasTemplateLogic tempLogic;
        private WIPSNResLogic wipSNResLogin;
        private string sMsg = "";
        private string LabelPath = "";
        private string username = "ftpuser";
        private string password = "Test123456";
        private string serverUrl = "ftp://47.107.77.75"; // 替换为你的服务器地址
        LabelManager2.ApplicationClass labApp;
        public string OrderId { get; set; }
        public BasTemplate basTemplate { get; set; }
        private UIWaitingBar waitingBar;

        public PrintSNForm()
        {
            InitializeComponent();

            orderLogic = new OrderLogic();
            tempLogic = new BasTemplateLogic();
            wipSNResLogin = new WIPSNResLogic();
            labApp = new LabelManager2.ApplicationClass();
            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();

            //打印时界面等待效果
            //waitingBar = new UIWaitingBar();
            //waitingBar.Style = UIStyle.Blue;
            //waitingBar.Parent = this;
            //waitingBar.Dock = DockStyle.Fill;
            //waitingBar.BringToFront();
            //waitingBar.Visible = false;
        }

        private void PrintSNForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = OrderId;

            BindData(OrderId);
            txtQty.Select();
            txtQty.Focus();
        }

        //显示工单相关信息
        private void BindData(string orderId)
        {
            OrderInfo order = orderLogic.Get(orderId);
            if (order != null)
            {
                txtTargetQty.Text = order.TargetQty.ToString();
                txtPlanDate.Text = order.PlanStartDate?.ToString("yyyy-MM-dd");
                txtRuleName.Text = order.SNRule;
                txtPrintedQty.Text = order.PrintedQty.ToString();
                txtUnQty.Text = (order.TargetQty - order.PrintedQty).ToString();
                txtQty.Text = txtUnQty.Text;    //打印数量默认等于剩余数量
                txtCount.Text = basTemplate?.PrintCount.ToString();
                if (string.IsNullOrEmpty(txtCount.Text))
                    txtCount.Text = "1";

                //起始条码，结束条码需要逻辑计算
                string startSN = wipSNResLogin.GetStartSNByOrder(orderId);
                txtFromSN.Text = startSN;
                List<WIP_SNRes> list = wipSNResLogin.GetWIPSNRes(orderId, Convert.ToInt32(txtQty.Text));
                if(list != null && list.Count > 0)
                    txtToSN.Text = list[list.Count - 1].SN;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //打印
            if (CheckInput())
            {
                FileUtil fileUtil = new FileUtil();

                int iQty = Convert.ToInt32(txtQty.Text.Trim());
                string startSN = txtFromSN.Text.Trim();
                string endSN = txtToSN.Text.Trim();
                int Qty = int.Parse( txtQty.Text.Trim().ToString());

                List<WIP_SNRes> list = wipSNResLogin.GetList(OrderId, startSN, endSN,Qty);

                BasTemplate template = tempLogic.GetOnedeleteMark(list[0].ItemCode.Trim().ToString(), "SN_TYPE", "N");
                if (template == null)
                {
                    this.ShowWarningDialog("产品没有上传打印模板，请上传后在打印", UIStyle.Blue);
                    return;
                }
                DateTime dateTime = (DateTime)template.ModifyTime;
                int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName,username,password, template.HostURL);
                if (downloadFile<0)
                {
                    this.ShowWarningDialog("模板下载失败", UIStyle.Blue);
                    return;
                }
                LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;

                bool bFlag = PrintHelper.PrintLabel(labApp, LabelPath, 1, list, ref sMsg);
                if (bFlag)
                {
                    List<WIPPrintLog> printLog = GetWIPPrintLogs(list);
                    List<WIPSNTracking> list_sn = GetWIPSNTrackings(list);
                    List<WIPSNTrackingHis> list_his = GetWIPSNTrackingHis(list_sn);
                    int end = list.Count - 1;
                    //将打印后的数据逻辑保存到数据库
                    //1.修改工单表已打印数量,；2.修改条码资源表状态；3.打印记录保存到打印日志表；4.打印的SN保存到SN当前表
                    int row = wipSNResLogin.PrintSave(OrderId, iQty, printLog, list[0].SN , list[end].SN,  list_sn, list_his, ref sMsg);

                    BindData(OrderId);  //刷新界面
                }
                else
                {
                    this.ShowWarningDialog("打印失败打印模板加载异常！", UIStyle.Blue);
                }
                


            }
        }

       
            private bool CheckInput()
        {
            bool bFlag = true;
            string qty = txtQty.Text.Trim();
            if(string.IsNullOrEmpty(qty))
            {
                this.ShowWarningDialog("打印数量不能为空", UIStyle.Blue);
                txtQty.Focus();
                return false;
            }
            bool bInt = CommonHelper.IsInt(qty);
            if (!bInt)
            {
                this.ShowWarningDialog("打印数量必须为正整数", UIStyle.Blue);
                return false;
            }
            int iQty = Convert.ToInt32(qty);
            if(iQty <= 0)
            {
                this.ShowWarningDialog("打印数量必须大于0", UIStyle.Blue);
                return false;
            }
            string count = txtCount.Text.Trim();
            if(string.IsNullOrEmpty(count))
            {
                this.ShowWarningDialog("打印份数不能为空", UIStyle.Blue);
                txtCount.Focus();
                return false;
            }
        
            bInt = CommonHelper.IsInt(count);
            if (!bInt)
            {
                this.ShowWarningDialog("打印份数必须为正整数", UIStyle.Blue);
                return false;
            }
            int iCount = Convert.ToInt32(count);
            if (iCount <= 0)
            {
                this.ShowWarningDialog("打印份数必须大于0", UIStyle.Blue);
                return false;
            }

            return bFlag;
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
                    model.PrintType = 0;    //0-正常打印/1-补打
                    model.PrintNum = 1;
                    model.PrintParam = "";
                    model.PrintTime = DateTime.Now;
                    model.PrinterId = GlobalConfig.CurrentUser.Account;

                    logs.Add(model);
                }
            }

            return logs;
        }


        private List<WIPSNTrackingHis> GetWIPSNTrackingHis(List<WIPSNTracking> list)
        {
            List<WIPSNTrackingHis> sns = new List<WIPSNTrackingHis>();

            if (list.Count > 0)
            {
                foreach (WIPSNTracking sn in list)
                {
                    WIPSNTrackingHis model = new WIPSNTrackingHis();

                    model.SN = sn.SN;
                    model.OrderId = sn.OrderId;
                    model.ItemCode = sn.ItemCode;
                    model.MatModel = sn.MatModel;
                    model.CustomerCode = sn.CustomerCode;
                    model.LineCode = sn.LineCode;
                    model.OperCode = sn.OperCode;
                    model.ResCode = sn.ResCode;
                    model.ModuleSN = sn.ModuleSN;
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = sn.OperationId;
                    model.CartonNo = sn.CartonNo;
                    model.PalletNO = sn.PalletNO;
                    model.SNStatus = sn.SNStatus;
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    model.IsFinished = sn.IsFinished;
                    model.FinishTime = sn.FinishTime;

                    sns.Add(model);
                }
            }

            return sns;
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
                    model.OrderId= sn.OrderId;
                    model.ItemCode= sn.ItemCode;
                    model.MatModel = sn.MatModel;
                    model.CustomerCode = "";
                    model.LineCode = "";
                    model.OperCode = "Create";
                    model.ResCode = "Create_Printed";
                    model.ModuleSN = "";
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime= DateTime.Now;
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

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            //waitingBar.Visible = true;
            //await Task.Delay(3000);
            //waitingBar.Visible = false;
        }


        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                string qty = txtQty.Text.Trim();
                bool bFlag = CommonHelper.IsInt(qty);
                if(!bFlag)
                {
                    this.ShowWarningDialog("打印数量必须为正整数", UIStyle.Blue);
                    return;
                }

                //起始条码和终止条码显示出来
                List<WIP_SNRes> list = wipSNResLogin.GetWIPSNRes(OrderId, Convert.ToInt32(qty));
                if (list != null && list.Count > 0)
                {
                    txtToSN.Text = list[list.Count - 1].SN;
                }
            }
        }


    }
}
