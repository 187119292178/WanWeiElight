using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.WIP;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using ServiceStack;
using Sunny.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elight.Utility.Core;

namespace Elight.WinForm.Page.WIP
{
    [PageCode("wip-pcbpackingpage")]
    public partial class PCBPackingPage : MyPage
    {
        private BasRuleSerialLogic ruleLogic;
        private WIPPackagingBoxLogic boxLogic;
        private OrderLogic logic;
        private WIP_SNRes SNResInfo;
        private WIPSNResLogic snResLogic;
        private WIPSNTrackingLogic wipsnLogic;
        private BasTemplateLogic tempLogic;
        LabelManager2.ApplicationClass labApp;

        private string sMsg = "";
        private string OperCode = "PACKING";
        private int Qty = 0;
        private string ScanSN = "";
        private string sItemCode = "";
        private string sOrderId = "";
        private string sCartonNo = "";
        private string ruleName = "PACKING_RULE";
        private OrderInfo oracle = new OrderInfo();
        private string username = "";
        private string password = "";
        private string serverUrl = "";
        private string CartonPre = "XH";     //箱号固定前缀，前缀+年月日+4位流水码
        private string CartonNo = "";   //箱号

        /// <summary>
        /// 默认装箱数量
        /// </summary>
        private int DefaultQty = 8;
        private int CurQty = 0;     //本次当前扫描数量
        private WIPSNTracking WIPSN = new WIPSNTracking();
        private List<WIPSNTracking> ScanList = new List<WIPSNTracking>();
        private BasTemplate basTemplate { get; set; }
        /// <summary>
        /// 是否存在对应模板文件
        /// </summary>
        private bool IsTemp = false;
        private WIP_PackagingBox wIP_PackagingBox = new WIP_PackagingBox();


        public PCBPackingPage()
        {
            InitializeComponent();
            logic = new OrderLogic();
            ruleLogic = new BasRuleSerialLogic();
            snResLogic = new WIPSNResLogic();
            boxLogic = new WIPPackagingBoxLogic();
            wipsnLogic = new WIPSNTrackingLogic();
            labApp = new LabelManager2.ApplicationClass();
            tempLogic = new BasTemplateLogic();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

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
            txtOperCode.Text = "Packing-PCBA包装工站";

            InitForm();
            txtQty.Text = DefaultQty.ToString();
        }

        private void InitForm()
        {
            CurQty = 0;
            txtOrderId.Text = "";
            txtOrderNo.Text = "";
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtCartonNo.Text = "";
            txtQty.Text = "";
            txtInput.Text = "";
            lblMsg.Text = "";
            lblCurQty.Text = "";
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

                ShowScanInfo(SNResInfo);

                //生成包装箱号
                CartonNo = ruleLogic.GetNewCartonNo2(ruleName, CartonPre, ref sMsg);
                if (string.IsNullOrEmpty(CartonNo))
                {
                    sMsg = $"外箱号生成出现异常：{sMsg}";
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    return;
                }
                //并将生成的箱号保存到数据库
                wIP_PackagingBox = Get_PackagingBox(SNResInfo, CartonNo);
                int row = boxLogic.Insert(wIP_PackagingBox);
                if (row <= 0)
                {
                    sMsg = $"外箱号保存到数据库出现异常";
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    return;
                }
                txtCartonNo.Text = CartonNo;

                //扫描的条码增加和显示
                CurQty = CurQty + 1;
                lblCurQty.Text = CurQty.ToString();
                AddScanInfoList(WIPSN); //AddScanInfo(SNResInfo);
                dataGridView.DataSource = null;
                dataGridView.DataSource = ScanList;

                //达到包装数量
                if (CurQty == DefaultQty)
                {
                    //数据保存提交到数据库，然后打印条码
                    row = PackingTransfer();
                    if (row <= 0)
                    {
                        sMsg = $"外箱包装时操作后台数据库报错:{sMsg}";
                        ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    }
                    else
                    {
                        //刷新数量
                        oracle = logic.Get(SNResInfo.OrderId);
                        if (oracle != null)
                        {
                            lblPackQty.Text = oracle.PackQty.ToString();
                            lblUnPackQty.Text = (oracle.TargetQty - oracle.PackQty).ToString();
                        }

                        //打印模板文件
                        sMsg = $"包装成功，正在打印外箱条码，请稍等...";
                        ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                        PlaySound(true);

                        bool bFlag = PrintCartonLabel();
                        if (!bFlag)
                        {
                            ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                            PlaySound(false);
                        }


                        //初始化
                        InitSacn();
                        ScanHelpler.ShowSuccess(lblMsg, "请继续扫描下一箱要包装的产品SN");
                    }
                }
                else
                {
                    //未达到包装数量
                    sMsg = $"条码[{ScanSN}]扫描成功，请接着扫描";
                    ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                    PlaySound(true);
                }
            }
        }
        #endregion

        #region 扫描卡空
        private bool CheckScan(string sInput, ref string msg)
        {
            msg = "";
            bool bFlag = true;

            //必须先输入装箱数量
            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                msg = "请先输入要装箱的数量再扫描";
                txtQty.Select();
                txtQty.Focus();
                return false;
            }
            //必须先输入装箱版本号
            if (string.IsNullOrEmpty(TxtSW.Text.Trim()))
            {
                msg = "请先输入要装箱的SW版本号再扫描";
                txtQty.Select();
                txtQty.Focus();
                return false;
            }

            if (!CommonHelper.IsInt(txtQty.Text.Trim()))
            {
                msg = "装箱数量必须为正整数";
                txtQty.Select();
                txtQty.Focus();
                return false;
            }

            //1.验证条码是否存在
            SNResInfo = snResLogic.GetSNResInfo(sInput);
            if (SNResInfo == null)
            {
                msg = $"条码[{sInput}]在系统中不存在，请重新扫描";
                PlaySound(false);
                return false;
            }

            //add 必须为PCBA的料号
            if(!"PCBA".Contains(SNResInfo.MatType))
            {
                msg = $"条码[{sInput}]对应料号[{SNResInfo.ItemCode}]的物料类型是[{SNResInfo.MatType}],必须是PCBA";
                PlaySound(false);
                return false;
            }

            //2.验证是否已经扫了包装工站，是否打了报废
            WIPSN = wipsnLogic.GetOne(sInput);
            if (WIPSN != null)
            {
                if (WIPSN.OperCode == OperCode || !string.IsNullOrEmpty(WIPSN.CartonNo))
                {
                    msg = $"条码[{sInput}]已经扫描过包装工站了，不能重复扫描";
                    PlaySound(false);
                    return false;
                }
                //if (WIPSN.OperCode != "PACKINGBOX")
                //{
                //    msg = $"条码[{sInput}]未过彩盒包装工站，不能进行包装";
                //    PlaySound(false);
                //    return false;
                //}
                if (WIPSN.SNStatus == "SCRAP")
                {
                    msg = $"条码[{sInput}]已经打了报废，不能包装";
                    PlaySound(false);
                    return false;
                }
            }
            else
            {
                msg = $"条码[{sInput}]没有打印记录，不能包装";
                PlaySound(false);
                return false;
            }


            if (string.IsNullOrEmpty(sItemCode))
            {
                sItemCode = SNResInfo.ItemCode;
            }
            else
            {
                if (sItemCode != SNResInfo.ItemCode)
                {
                    msg = $"条码[{sInput}]料号[{SNResInfo.ItemCode}]和已扫条码料号[{sItemCode}]不一致，不能包装";
                    PlaySound(false);
                    return false;
                }
            }

            if (ScanList != null && ScanList.Count > 0)
            {
                if (ScanList.Exists(t => t.SN == sInput))
                {
                    msg = $"条码[{sInput}]已经在已扫列表中，不能重复扫描";
                    PlaySound(false);
                    return false;
                }
            }

            //检查对应模板文件是否已维护
            if (IsTemp == false)
            {
                basTemplate = tempLogic.GetOnedeleteMark(SNResInfo.ItemCode, "BOX_TYPE", "N");
                if ((basTemplate == null))
                {
                    msg = $"条码[{sInput}]对应料号[{SNResInfo.ItemCode}]没有上传外箱打印模板文件";
                    PlaySound(false);
                    return false;
                }
                else
                    IsTemp = true;
            }

            return bFlag;
        }

        private void ShowScanInfo(WIP_SNRes snRes)
        {
            txtOrderId.Text = snRes.OrderId;
            txtOrderNo.Text = snRes.OrderId;
            txtItemCode.Text = snRes.ItemCode;
            txtItemName.Text = snRes.ItemName;
            txtMatType.Text = snRes.MatType;

            if (string.IsNullOrEmpty(txtQty.Text.Trim()) && snRes.PackQty == 0)
            {
                DefaultQty = 8;
            }

            oracle = logic.Get(snRes.OrderId);
            if (oracle != null)
            {
                lblPackQty.Text = oracle.PackQty.ToString();
                lblUnPackQty.Text = (oracle.TargetQty - oracle.PackQty).ToString();
            }
        }
        #endregion


        #region 表格新增
        private int PackingTransfer()
        {
            int row = 0;

            List<WIPSNTracking> wips = ScanList;
            if(wips != null && wips.Count > 0)
            {
                foreach (WIPSNTracking model in wips)
                    model.CartonNo = CartonNo;
            }
            List<WIPSNTrackingHis> hiss = GetWIPSNTrackingHis(wips);

            List<WIPPrintLog> logs = GetWIPPrintLogs(wips);

            row = wipsnLogic.PackingSave(wips, hiss, logs, ref sMsg);

            return row;
        }

        private WIP_PackagingBox Get_PackagingBox(WIP_SNRes snRes, string cartonNo)
        {
            WIP_PackagingBox box = new WIP_PackagingBox();

            box.BoxNumber = cartonNo;
            box.Status = "CREATED";   //CREATED生成箱号，BIND绑定使用中，UNBIND解绑
            box.Type = "CARTON";
            box.ParentBoxNumber = "";
            box.Quantity = CurQty;
            box.TotalQuantity = DefaultQty;
            box.ProductNumber = snRes.ItemCode;
            box.WorkOrder = snRes.OrderId;
            box.Remarks = "开始包装生成箱号";
            box.IsEnabled = "Y";
            box.CreateUser = GlobalConfig.CurrentUser.Account;
            box.CreatedTime = DateTime.Now;
            box.ModifyUser = box.CreateUser;
            box.ModifyTime = box.CreatedTime;

            return box;
        }

        private List<WIPSNTrackingHis> GetWIPSNTrackingHis(List<WIPSNTracking> wips)
        {
            List<WIPSNTrackingHis> list = new List<WIPSNTrackingHis>();
            if (wips.Count > 0)
            {
                foreach (WIPSNTracking sn in wips)
                {
                    WIPSNTrackingHis model = new WIPSNTrackingHis();

                    model.SN = sn.SN;
                    model.OrderId = sn.OrderId;
                    model.ItemCode = sn.ItemCode;
                    model.MatModel = sn.MatModel;
                    model.CustomerCode = sn.CustomerCode;
                    model.LineCode = sn.LineCode;
                    model.OperCode = OperCode;
                    model.ResCode = OperCode;
                    model.ModuleSN = sn.ModuleSN;
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = GlobalConfig.CurrentUser.Account;
                    model.CartonNo = sn.CartonNo;
                    model.PalletNO = sn.PalletNO;
                    model.SNStatus = "OK";
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    model.IsFinished = sn.IsFinished;
                    model.FinishTime = sn.FinishTime;
                    model.ActionCode = "PACKING";
                    model.OperationMsg = "在线打印外箱标签";

                    list.Add(model);
                }
            }

            return list;
        }


        private List<WIPPrintLog> GetWIPPrintLogs(List<WIPSNTracking> wips)
        {
            List<WIPPrintLog> logs = new List<WIPPrintLog>();

            if (wips.Count > 0)
            {
                foreach (WIPSNTracking snRes in wips)
                {
                    WIPPrintLog model = new WIPPrintLog();

                    model.ItemCode = snRes.ItemCode;
                    model.SN = snRes.SN;
                    model.OrderId = snRes.OrderId;
                    model.OperCode = OperCode;
                    model.LabelType = "CARTON_BOX";
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

        private void AddScanInfoList(WIPSNTracking wip)
        {
            WIPSNTracking model = new WIPSNTracking();
            model.SN = wip.SN;
            model.ItemCode = wip.ItemCode;
            model.OrderId = wip.OrderId;
            model.MatModel = wip.MatModel;
            model.CustomerCode = wip.CustomerCode;
            model.LineCode = wip.LineCode;
            model.OperCode = OperCode;
            model.ResCode = OperCode;
            model.ModuleSN = wip.ModuleSN;
            model.OpeartionTime = DateTime.Now;
            model.InLineTime = wip.InLineTime;
            model.OperationId = GlobalConfig.CurrentUser.Account;
            model.CartonNo = CartonNo;
            model.PalletNO = wip.PalletNO;
            model.SNStatus = wip.SNStatus;
            model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            model.IsFinished = "Y";
            model.FinishTime = DateTime.Now;

            if (ScanList != null && !ScanList.Exists(t => t.SN == wip.SN))
                ScanList.Add(model);
        }

        public bool PrintCartonLabel()
        {
            bool bFlag = false;
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();

            if (basTemplate == null)
            {
                sMsg = $"产品料号[{SNResInfo.ItemCode}]没有上传外箱条码";
                return bFlag;
            }

            DateTime dateTime = (DateTime)basTemplate.ModifyTime;
            int downloadFile = fileUtil.DownloadFile(dateTime, basTemplate.RemoteName, username, password, basTemplate.HostURL);
            if (downloadFile < 0)
            {
                sMsg = "从服务器下载模板失败";
                return bFlag;
            }
            string LabelPath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + basTemplate.RemoteName;

            bFlag = PrintHelper.PrintCartonLabel(labApp, LabelPath, 1, TxtSW.Text.ToString(), ScanList, txtItemName.Text, ref sMsg);

            return bFlag;
        }


        #region 无用的代码
        //private void AddScanInfo(WIP_SNRes snRes)
        //{
        //    WIPSNTracking model = new WIPSNTracking();
        //    model.SN = snRes.SN;
        //    model.ItemCode = snRes.ItemCode;
        //    model.OrderId = snRes.OrderId;
        //    model.MatModel = snRes.MatModel;
        //    model.CustomerCode = "";
        //    model.LineCode = "";
        //    model.OperCode = OperCode;
        //    model.ResCode = "";
        //    model.ModuleSN = "";
        //    model.OpeartionTime = DateTime.Now;
        //    model.InLineTime = DateTime.Now;
        //    model.OperationId = GlobalConfig.CurrentUser.Account;
        //    model.PalletNO = "";
        //    model.SNStatus = "OK";
        //    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
        //    model.IsFinished = "Y";
        //    model.FinishTime = DateTime.Now;

        //    if (ScanList != null && !ScanList.Exists(t => t.SN == snRes.SN))
        //        ScanList.Add(model);
        //}
        //private void RemoveScanInfo(WIP_SNRes snRes)
        //{
        //    WIPSNTracking model = new WIPSNTracking();
        //    model.SN = snRes.SN;
        //    model.ItemCode = snRes.ItemCode;
        //    model.OrderId = snRes.OrderId;
        //    model.MatModel = snRes.MatModel;
        //    model.CustomerCode = "";
        //    model.LineCode = "";
        //    model.OperCode = OperCode;
        //    model.ResCode = "";
        //    model.ModuleSN = "";
        //    model.OpeartionTime = DateTime.Now;
        //    model.OperationId = GlobalConfig.CurrentUser.Account;
        //    model.PalletNO = "";
        //    model.SNStatus = "GOOD";
        //    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
        //    model.IsFinished = "Y";

        //    if (ScanList != null && !ScanList.Exists(t => t.SN == snRes.SN))
        //        ScanList.Remove(model);
        //}
        #endregion

        #endregion


        #region 声音提示
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


        #region 删除其中一个产品
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行删除", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行删除", UIStyle.Blue);
                return;
            }

            string sNResSn = dataGridView.Rows[index].Cells["SN"].Value.ToString();
            if (string.IsNullOrEmpty(sNResSn))
            {
                this.ShowWarningDialog("请选择要删除的产品条码为空", UIStyle.Blue);
                return;
            }

            //删除其中一个
            //WIPSNTracking wip = wipsnLogic.GetOne(sNResSn);
            //ScanList.Remove(wip);
            ScanList = ScanList.Where(x => x.SN != sNResSn).ToList();
            CurQty = CurQty - 1;
            lblCurQty.Text = CurQty.ToString();

            if(ScanList == null || ScanList.Count == 0)
                dataGridView.DataSource = null;
            else
                dataGridView.DataSource = ScanList;
            ScanHelpler.ShowSuccess(lblMsg, $"条码[{sNResSn}]删除成功");


            //SNResInfo = snResLogic.GetSNResInfo(sNResSn);
            //RemoveScanInfo(SNResInfo);
            //dataGridView.DataSource = null;
            //dataGridView.DataSource = ScanList;
        }
        #endregion

        #region 全部清空
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            if (!this.ShowAskDialog("您是否确定要清空本次全部扫描数据？", UIStyle.Blue))
            {
                return;
            }

            //都进行初始化
            InitSacn();
            ScanHelpler.ShowSuccess(lblMsg, $"全部清除成功");
        }

        /// <summary>
        /// 扫描初始化
        /// </summary>
        private void InitSacn()
        {
            SNResInfo = null;
            WIPSN = null;
            if (ScanList != null && ScanList.Count > 0)
                ScanList.Clear();
            CartonNo = "";
            CurQty = 0;
            lblCurQty.Text = CurQty.ToString();
            wIP_PackagingBox = null;
            ScanSN = "";
            sMsg = "";
            sItemCode = "";
            IsTemp = false;
            oracle = null;
            dataGridView.DataSource = null;

            txtInput.Text = "";
            txtInput.Select();
            txtInput.Focus();
        }
        #endregion

        #region 重置扫描
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitSacn();
        }
        #endregion

        #region 解绑箱号

        private void uiButton1_Click(object sender, EventArgs e)
        {
            PackingPageDate form = new PackingPageDate();
            FormHelper.ShowSubForm(form);
        }
        #endregion

        #region 生成id
        private List<string> GetBoxList(BasRuleSerial ruleSerial, int qty)
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
                        ruleSerial.LAST_SERIALNO = CommonHelper.TransformBase(seqNo.ToString(), 10, 36, "Y").PadLeft(3, '0');
                    }
                }
            }

            return list;
        }

        private List<WIP_PackagingBox> GetWIPSNResList(List<string> list)
        {
            List<WIP_PackagingBox> Box = new List<WIP_PackagingBox>();
            if (list != null && list.Count > 0)
            {
                foreach (string number in list)
                {
                    WIP_PackagingBox model = new WIP_PackagingBox();

                    model.BoxNumber = number;
                    model.Status = "INIT";
                    model.WorkOrder = txtOrderNo.Text;
                    model.Type = "BOX";
                    model.ProductNumber = txtItemCode.Text;
                    model.Remarks = "N";
                    model.TotalQuantity = 0;
                    model.IsEnabled = "Y";
                    model.CreatedTime = DateTime.Now;
                    model.CreateUser = GlobalConfig.CurrentUser.Account;
                    model.ModifyTime = DateTime.Now;
                    model.ModifyUser = GlobalConfig.CurrentUser.Account;

                    Box.Add(model);
                }
            }

            return Box;
        }
        #endregion

        #region 保存
        private void uiButton2_Click(object sender, EventArgs e)
        {

            if (wIP_PackagingBox != null)
            {

                WIP_PackagingBox wIP_Packaging = boxLogic.GetOne(wIP_PackagingBox.BoxNumber);

                if (wIP_Packaging != null)
                {
                    wIP_PackagingBox.Quantity = ScanList.Count;
                    wIP_PackagingBox.TotalQuantity = ScanList.Count;

                    int box = boxLogic.SnbindingPacking(wIP_PackagingBox, ScanList);

                    if (box <= 0)
                    {

                        string textToSpeak = "NG!";
                        SpeechSynthesizer synthes = new SpeechSynthesizer();
                        synthes.Speak(textToSpeak);//同步
                        this.ShowWarningDialog("箱号绑定失败！", UIStyle.Blue); return;
                    }
                    else
                    {
                        PrintBoxLabel();
                        this.ShowWarningDialog("箱号绑定成功！", UIStyle.Blue);
                        btnReset_Click(sender, e);
                        return;

                    }

                }
            }


        }
        #endregion


        #region 打印

        public void PrintBoxLabel()
        {
            Utility.Files.FileUtil fileUtil = new Utility.Files.FileUtil();
            List<WIP_SNRes> list = snResLogic.GetSNResInfoByBox(txtCartonNo.Text);

            if (list == null)
            {
                this.ShowWarningDialog("箱子没有包装产品，不能打印", UIStyle.Blue);
                return;
            }
            BasTemplate template = tempLogic.GetOnedeleteMark(list[0].ItemCode, "BOX_TYPE", "N");
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
            bool bFlag = PrintHelper.PrintBoxLabel(labApp, LabelPath, 1, TxtSW.Text.ToString(), list, ref sMsg);
            if (bFlag)
            {
                wIP_PackagingBox.Status = "PRINTED";
                int box = boxLogic.Update(wIP_PackagingBox);
                string textToSpeak = "OK!";
                SpeechSynthesizer synthes = new SpeechSynthesizer();
                synthes.Speak(textToSpeak);//同步

            }
            else
            {
                this.ShowWarningDialog("打印失败打印模板加载异常！", UIStyle.Blue);
            }
        }

        #endregion


        private void txtCartonNo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            //{
            //    string cartonNo = txtCartonNo.Text.Trim();
            //    if (string.IsNullOrEmpty(cartonNo))
            //        return;
            //    wIP_PackagingBox = boxLogic.GetOne(cartonNo);

            //    if (wIP_PackagingBox == null)
            //    {

            //        this.ShowWarningDialog(cartonNo + "箱号不存在！", UIStyle.Blue);
            //    }
            //}
        }


        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            //{
            //    string snNo = txtKeywords.Text.Trim();


            //    if (string.IsNullOrEmpty(snNo))
            //        return;
            //    WIP_SNRes list = snResLogic.GetOne(snNo);
            //    if (string.IsNullOrEmpty(list.BoxNumber))
            //    {
            //        this.ShowWarningDialog(snNo + "SN没有绑定箱号！", UIStyle.Blue);
            //    }

            //    wIP_PackagingBox = boxLogic.GetOne(list.BoxNumber);

            //    if (wIP_PackagingBox == null)
            //    {

            //        this.ShowWarningDialog(list.BoxNumber + "箱号不存在！", UIStyle.Blue);
            //    }
            //    if (string.IsNullOrEmpty(TxtSW.Text.Trim()))
            //    {
            //        this.ShowWarningDialog(snNo + "请先输入要装箱的SW版本号再扫描！", UIStyle.Blue);
            //    }
            //    PrintBoxLabel();
            //}


        }


        public override void Stop()
        {

        }

        /// <summary>
        /// 补打外箱条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReprint_Click(object sender, EventArgs e)
        {
            BoxReprint form = new BoxReprint();
            form.TemplateType = "BOX_TYPE"; //指定模板类型
            //form.ShowDialog();
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 输入本次包装数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    DefaultQty = Convert.ToInt32(txtQty.Text.Trim());
                }
                catch (Exception ex)
                {
                    this.ShowWarningDialog("装箱数量必须为正整数", UIStyle.Blue);
                    return;
                }
                if (DefaultQty == 0)
                {
                    this.ShowWarningDialog("装箱数量必须大于0", UIStyle.Blue);
                    return;
                }

                if (DefaultQty < ScanList.Count)
                {
                    this.ShowWarningDialog("装箱数量不能小于当前已经扫描的产品数量", UIStyle.Blue);
                    return;
                }
                if (DefaultQty == ScanList.Count)
                {
                    //打印尾包标签

                }
            }
        }

        private void TxtSW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (string.IsNullOrEmpty(TxtSW.Text.Trim()))
                    return;
                txtInput.Select();
                txtInput.Focus();
            }
        }
    }
}
