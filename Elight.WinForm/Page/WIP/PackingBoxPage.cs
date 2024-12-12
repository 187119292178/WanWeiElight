using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Elight.Utility.Core;


namespace Elight.WinForm.Page.WIP
{
    [PageCode("wip-PackingBoxPage")]
    public partial class PackingBoxPage : MyPage
    {
        private BasRuleSerialLogic ruleLogic;
        private WIPPackagingBoxLogic boxLogic;
        private OrderLogic logic;


        private string sMsg = "";
        private string OperCode = "PACKINGBOX";
        private int Qty = 0;
        private string ScanSN = "";
        private string sItemCode = "";
        private string sOrderId = "";
        private string sCartonNo = "";
        private string ruleName = "BOX_RULE";
        private OrderInfo order = new OrderInfo();
        private WIP_PackagingBox wIP_PackagingBox = new WIP_PackagingBox();
        private BasTemplateLogic tempLogic;
        LabelManager2.ApplicationClass labApp;

        /// <summary>
        /// 默认装箱数量
        /// </summary>
        private List<WIPSNTracking> ScanList = new List<WIPSNTracking>();
        private WIP_SNRes SNResInfo;

        public BasTemplate basTemplate { get; set; }
        private WIPSNResLogic snResLogic;
        private WIPSNTrackingLogic wipsnLogic;
        private string username = "";
        private string password = "";
        private string serverUrl = "";

        public PackingBoxPage()
        {
            InitializeComponent();
            logic = new OrderLogic();
            labApp = new LabelManager2.ApplicationClass();

            tempLogic = new BasTemplateLogic();
            ruleLogic = new BasRuleSerialLogic();
            snResLogic = new WIPSNResLogic();
            boxLogic = new WIPPackagingBoxLogic();
            wipsnLogic = new WIPSNTrackingLogic();

            uiListBox1.Items.Clear();

            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PackingPage_Load(object sender, EventArgs e)
        {
            txtUserId.Text = GlobalConfig.CurrentUser.Account + "-" + GlobalConfig.CurrentUser.RealName;
            txtOperCode.Text = "Box-整机彩盒包装工站";

            InitForm();
        }

        private void InitForm()
        {
            txtOrderId.Text = "";
            txtOrderNo.Text = "";
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtOrderQty.Text = "";
            txtInput.Text = "";
            lblMsg.Text = "";
            lblPackQty.Text = "";
            lblUnPackQty.Text = "";
            txtInput.Enabled = true;
            txtInput.Visible = true;
            txtInput.Select();
            txtInput.Focus();
            lblStatus.Visible = false;
            wIP_PackagingBox = new WIP_PackagingBox();
        }

        #region 扫描回车
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ScanSN = txtInput.Text.Trim();
                if (string.IsNullOrEmpty(ScanSN))
                    return;

                if (CheckScan(ScanSN, ref sMsg) == false)
                {
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    return;
                }

                //扫描成功后显示扫描的信息
                ShowScanInfo(SNResInfo);                

                //保存提交数据到数据库
                int row = TransferSave(SNResInfo);
                if(row <= 0)
                {
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    PlaySound(false);
                    return;
                }
                else
                {
                    //打印彩盒标签
                    sMsg = $"条码[{ScanSN}]扫描成功，开始打印彩盒标签，请稍等...";
                    ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                    PlaySound(true);

                    uiListBox1.Items.Add(ScanSN);

                    bool bFlag = PrintBoxLab();
                    if(bFlag)
                    {
                        ShowScanInfo(SNResInfo);

                        txtInput.Text = "";
                        txtInput.Enabled = true;
                        txtInput.Visible = true;
                        txtInput.Select();
                        txtInput.Focus();
                    }
                    else
                    {
                        ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, $"彩盒标签打印失败：{sMsg}");
                        PlaySound(false);
                    }
                }

            }
        }
        #endregion


        #region 扫描卡空
        private bool CheckScan(string sInput, ref string msg)
        {
            msg = "";
            bool bFlag = true;

            //1.验证条码是否存在
            SNResInfo = snResLogic.GetSNResInfo(sInput);
            if (SNResInfo == null)
            {
                msg = $"条码[{sInput}]在系统中不存在，请重新扫描";
                PlaySound(false);
                return false;
            }

            //2.验证是否已经扫了包装工站，是否打了报废
            WIPSNTracking wipsn = wipsnLogic.GetOne(sInput);
            if (wipsn != null)
            {
                if (wipsn.OperCode == OperCode)
                {
                    msg = $"条码[{sInput}]已经扫描过彩盒包装工站了，不能重复扫描";
                    PlaySound(false);
                    return false;
                }
                if (wipsn.SNStatus == "SCRAP")
                {
                    msg = $"条码[{sInput}]已经打了报废，不能包装";
                    PlaySound(false);
                    return false;
                }
                if (wipsn.SNStatus == "FAIL")
                {
                    msg = $"条码[{sInput}]为不良品，不能包装";
                    PlaySound(false);
                    return false;
                }
            }
            else 
            {
                msg = $"条码[{sInput}]没有打印，不能包装";
                PlaySound(false);
                return false;
            }

            //3.判断彩盒标签模板文件是否有上传
            BasTemplate template = tempLogic.GetOnedeleteMark(SNResInfo.ItemCode, "COLOR_TYPE", "N");
            if ((template == null))
            {
                msg = $"条码[{sInput}]对应料号[{SNResInfo.ItemCode}]没有上传彩盒打印模板文件";
                PlaySound(false);
                return false;
            }

            #region 多余的代码
            //if (!string.IsNullOrEmpty(SNResInfo.BoxNumber))
            //{
            //    msg = $"条码[{sInput}]已经绑定了彩盒号[{SNResInfo.BoxNumber}]，不能在包装";
            //    PlaySound(false);
            //    return false;
            //}

            //if (string.IsNullOrEmpty(sItemCode))
            //{
            //    sItemCode = SNResInfo.ItemCode;
            //}
            //else
            //{
            //    if (sItemCode != SNResInfo.ItemCode)
            //    {
            //        msg = $"条码[{sInput}]料号[{SNResInfo.ItemCode}]和以扫条码料[{sItemCode}]不一致，不能包装";
            //        PlaySound(false);
            //        return false;
            //    }
            //}

            //if (ScanList != null && ScanList.Count > 0)
            //{
            //    if (ScanList.Exists(t => t.SN == sInput))
            //    {
            //        msg = $"条码[{sInput}]已经在已扫列表中，不能重复扫描";
            //        PlaySound(false);
            //        return false;
            //    }
            //}
            #endregion

            return bFlag;
        }

        private void ShowScanInfo(WIP_SNRes snRes)
        {
            txtOrderId.Text = snRes.OrderId;
            txtOrderNo.Text = snRes.OrderId;
            txtItemCode.Text = snRes.ItemCode;
            txtItemName.Text = snRes.ItemName;
            txtMatType.Text = snRes.MatType;

            order = logic.Get(snRes.OrderId);
            if (order != null)
            {
                txtOrderQty.Text = order.TargetQty.ToString();
                lblPackQty.Text = order.BoxQty.ToString();
                int qty = (int)(order.TargetQty - order.BoxQty);
                lblUnPackQty.Text = qty.ToString();
            }
        }
        #endregion

        #region 表格新增

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

        private void RemoveScanInfo(WIP_SNRes snRes)
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
            model.OperationId = GlobalConfig.CurrentUser.Account;
            model.PalletNO = "";
            model.SNStatus = "GOOD";
            model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            model.IsFinished = "Y";

            if (ScanList != null && ScanList.Exists(t => t.SN == snRes.SN))
                ScanList.Remove(model);
        }
        #endregion

        # region 打印

        private void PlaySound(bool bfalg)
        {
            SoundPlayer player = new SoundPlayer();
            if (bfalg)
            {
                player.SoundLocation = @"Res\Sound\PASS.wav";
            }
            else
            {
                player.SoundLocation = @"Res\Sound\FAIL.wav";
            }

            player.Load();
            player.Play();
        }
        #endregion

        #region 重置按钮
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitForm();

            SNResInfo = null;
            ScanSN = "";
        }
        #endregion

        #region 补打

        private void uiButton1_Click(object sender, EventArgs e)
        {
            BoxReprint form = new BoxReprint();
            form.TemplateType = "COLOR_TYPE"; //指定模板类型
            //form.ShowDialog();
            FormHelper.ShowSubForm(form); 
        }
        #endregion

        /// <summary>
        /// 扫描后数据库后台逻辑
        /// </summary>
        /// <param name="sNRes"></param>
        /// <returns></returns>
        private int TransferSave(WIP_SNRes sNRes)
        {
            int row = 0;

            List<WIP_SNRes> sNReslist = new List<WIP_SNRes>();
            sNReslist.Add(sNRes);
            List<WIPPrintLog> printLog = GetWIPPrintLogs(sNReslist);
            WIPSNTrackingHis his = GetWIPSNTrackingHis(sNRes);
            row = snResLogic.ScanBOXSave(printLog, his, ref sMsg);

            return row;
        }

        /// <summary>
        /// 打印彩盒标签条码
        /// </summary>
        private bool PrintBoxLab()
        {
            bool bFlag = false;
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(SNResInfo.ItemCode, "COLOR_TYPE", "N");
            if (template == null)
            {
                this.ShowWarningDialog($"产品对应料号[{SNResInfo.ItemCode}]没有上传彩盒打印模板，请上传后在打印", UIStyle.Blue);
                return bFlag;

            }
            DateTime dateTime = (DateTime)template.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, template.RemoteName, username, password, template.HostURL);
            if (downloadFile < 0)
            {
                this.ShowWarningDialog("模板下载失败", UIStyle.Blue);
                return bFlag;
            }
            string LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + template.RemoteName;
            bFlag = PrintHelper.PrintBOXLabel(labApp, LabelPath, 1, SNResInfo, ref sMsg);

            return bFlag;
        }

        #region 保存

        private void uiButton2_Click(WIP_SNRes snRes)
        {

           
            if (snRes != null)
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

                List<WIPSNTracking> ScanList = new List<WIPSNTracking>();
                if (model != null) {
                    ScanList.Add(model);
                    wIP_PackagingBox.Quantity = ScanList.Count;
                    wIP_PackagingBox.TotalQuantity = ScanList.Count;
                    int box = boxLogic.SnbindingBox(ScanList);

                    if (box <= 0)
                    {
                        string textToSpeak = "NG!";
                        SpeechSynthesizer synthes = new SpeechSynthesizer();
                        synthes.Speak(textToSpeak);//同步
                        this.ShowWarningDialog("彩盒打印失败！", UIStyle.White); return;
                    }
                    else {
                       
                        AddScanInfo(SNResInfo);
                        sMsg = $"条码[{ScanSN}]扫描成功，请接着扫描";
                        ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                        PlaySound(true);
                        Print(SNResInfo);

                        string textToSpeak = "OK!";
                        SpeechSynthesizer synthes = new SpeechSynthesizer();
                        synthes.Speak(textToSpeak);
                        //this.ShowWarningDialog("箱号绑定成功！", UIStyle.White); return;

                    }
                }
            }

        }
        #endregion


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
                    model.LabelType = "COLOR_BOX";
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

        private WIPSNTrackingHis GetWIPSNTrackingHis(WIP_SNRes sn)
        {
            WIPSNTrackingHis model = new WIPSNTrackingHis();

            model.SN = sn.SN;
            model.OrderId = sn.OrderId;
            model.ItemCode = sn.ItemCode;
            model.MatModel = sn.MatModel;
            model.CustomerCode = "";
            model.LineCode = "";
            model.OperCode = OperCode;
            model.ResCode = OperCode;
            model.ModuleSN = "";
            model.InLineTime = DateTime.Now;
            model.OpeartionTime = DateTime.Now;
            model.OperationId = GlobalConfig.CurrentUser.Account;
            model.CartonNo = "";
            model.PalletNO = "";
            model.SNStatus = "OK";
            model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            model.IsFinished = "N";
            model.FinishTime = null;
            model.ActionCode = "PRINT_BOX";
            model.OperationMsg = "在线打印彩盒标签";

            return model;
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
                    model.OperCode = OperCode;
                    model.ResCode = "Reprint_Box";
                    model.ModuleSN = "";
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = sn.CreateUser;
                    model.CartonNo = "";
                    model.PalletNO = "";
                    model.SNStatus = "OK";
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    model.IsFinished = "N";
                    model.FinishTime = null;

                    wips.Add(model);
                }
            }

            return wips;
        }

        private void Print(WIP_SNRes sNRes)
        { 
            List<WIP_SNRes> sNReslist = new List<WIP_SNRes>();
            sNReslist.Add(sNRes);
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            BasTemplate template = tempLogic.GetOnedeleteMark(sNRes.ItemCode.Trim().ToString(), "COLOR_TYPE", "N");
            if (template == null)
            {
                this.ShowWarningDialog($"产品对应料号[{sNRes.ItemCode}]没有上传彩盒打印模板，请上传后在打印", UIStyle.Blue);
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
                 int row = snResLogic.RePrintSave(sNReslist[0].OrderId, 1, printLog, sNReslist[0].SN, sNReslist[0].SN, list_sn, ref sMsg);
            }
            else
            {
                this.ShowWarningDialog("打印失败打印模板加载异常！", UIStyle.Blue);
            }
        }


        public override void Stop()
        {

        }

    }
}
