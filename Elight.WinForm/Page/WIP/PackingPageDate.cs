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
using Elight.WinForm.Page.OrderManage;
using Org.BouncyCastle.Asn1.Cmp;
using ServiceStack;
using NPOI.SS.Formula.Functions;

namespace Elight.WinForm.Page.WIP
{
    public partial class PackingPageDate : UIForm
    {
        private SysItemsDetailLogic detailLogic;
        private OrderLogic orderLogic;
        private WIPSNResLogic snresLogic;
        private BasRuleSerialLogic ruleLogic;
        private WIPSNTrackingLogic wipsnLogic;
        private WIPPackagingBoxLogic boxLogic;
        private string sMsg = "";
        private string OperCode = "PACKING";
        private List<WIPSNTracking> WIPSNList = new List<WIPSNTracking>();

        public PackingPageDate()
        {
            InitializeComponent();

            detailLogic = new SysItemsDetailLogic();
            orderLogic = new OrderLogic();
            snresLogic = new WIPSNResLogic();
            ruleLogic = new BasRuleSerialLogic();
            wipsnLogic = new WIPSNTrackingLogic();
            boxLogic = new WIPPackagingBoxLogic();
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
            lblQty.Text = "";
            WIPSNList = null;
            txtSN.Text = "";
            txtSN.Select();
            txtSN.Focus();
        }


        /// <summary>
        /// 解绑其中一个产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行操作", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行操作", UIStyle.White); return;
            }

            string sNResSn = dataGridView.Rows[index].Cells["SN"].Value.ToString();

            if (!this.ShowAskDialog($"您是否确定要将产品[{sNResSn}]从包装箱中解绑拿出来？", UIStyle.Blue))
            {
                return;
            }
           
            WIPSNTracking snInfo = wipsnLogic.GetOne(sNResSn);
            if (snInfo != null)
            {              
                snInfo.OperCode = "PACKINGBOX";
                snInfo.ResCode = OperCode;
                snInfo.OpeartionTime = DateTime.Now;
                snInfo.OperationId = GlobalConfig.CurrentUser.Account;
                snInfo.IsFinished = "N";
                snInfo.FinishTime = null;

                WIP_PackagingBox boxInfo = boxLogic.GetOne(snInfo.CartonNo);
                if(boxInfo == null)
                {
                    this.ShowWarningDialog($"箱号[{snInfo.CartonNo}]在包装箱表中不存在", UIStyle.Blue);
                    return;
                }

                boxInfo.Quantity = boxInfo.Quantity - 1;
                boxInfo.ModifyTime = DateTime.Now;
                boxInfo.ModifyUser = snInfo.OperationId;
                snInfo.CartonNo = "";

                int row = boxLogic.UnPacking(snInfo, boxInfo, ref sMsg);
                if(row > 0)
                {
                    this.ShowWarningDialog("单独解绑操作成功", UIStyle.Blue);
                    if(WIPSNList != null && WIPSNList.Count > 0)
                    {
                        WIPSNList = WIPSNList.Where(x => x.SN != sNResSn).ToList();
                        dataGridView.DataSource = WIPSNList;
                        lblQty.Text = WIPSNList.Count.ToString();
                    }
                }
                else
                {
                    this.ShowWarningDialog($"单独解绑操作失败：{sMsg}", UIStyle.Blue);
                }

            }

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
                    model.OperCode = "UNBINDING";
                    model.InLineTime = DateTime.Now;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = sn.CreateUser;
                    model.SNStatus = sn.SNStatus;
                    model.ItemCode = sn.ItemCode;
                    model.OrderId = sn.OrderId;
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    wips.Add(model);
                }
            }

            return wips;
        }


        /// <summary>
        /// 全部解绑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!this.ShowAskDialog("您是否确定要对该箱做全部解绑操作？", UIStyle.Blue))
            {
                return;
            }

            if (WIPSNList == null || WIPSNList.Count == 0)
            {
                this.ShowWarningDialog("请先扫描箱号或者已包装的产品SN条码", UIStyle.Blue);
                return;
            }

            string sCartonNo = WIPSNList[0].CartonNo;
            if(string.IsNullOrEmpty(sCartonNo))
            {
                this.ShowWarningDialog("解绑的箱号为空，请确认需要解绑的数据是否正确", UIStyle.Blue);
                return;
            }

            WIP_PackagingBox boxInfo = boxLogic.GetOne(sCartonNo);
            if (boxInfo == null) 
            {
                this.ShowWarningDialog($"解绑的箱号[{sCartonNo}]在后台包装表中不存在", UIStyle.Blue);
                return;
            }
            boxInfo.Status = "UNBIND";  //解绑拆箱
            boxInfo.Remarks = "包装解绑拆箱";       //
            boxInfo.IsEnabled = "N";
            boxInfo.ModifyTime = DateTime.Now;
            boxInfo.ModifyUser = GlobalConfig.CurrentUser.Account;

            List<WIPSNTrackingHis> his_list = GetWIPSNTrackingHis(WIPSNList);
            List<WIPSNTracking> wip_list = new List<WIPSNTracking>();
            foreach(WIPSNTracking snInfo in WIPSNList)
            {
                //snInfo.InLineTime = 
                snInfo.CartonNo = "";
                //snInfo.OperCode = "";
                snInfo.OperCode = "PACKINGBOX";
                snInfo.ResCode = snInfo.OperCode;
                snInfo.OpeartionTime = DateTime.Now;
                snInfo.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                snInfo.OperationId = GlobalConfig.CurrentUser.Account;
                snInfo.IsFinished = "N";
                snInfo.FinishTime = null;

                wip_list.Add(snInfo);
            }

            int row = boxLogic.UnPackingAll(boxInfo, wip_list, his_list, ref sMsg);

            if (row > 0)
            {
                this.ShowWarningDialog("全部解绑操作成功", UIStyle.Blue);
                if (WIPSNList != null && WIPSNList.Count > 0)
                {
                    WIPSNList.Clear();
                    dataGridView.DataSource = null;
                    lblQty.Text = "";
                }
            }
            else
            {
                this.ShowWarningDialog($"全部解绑操作失败：{sMsg}", UIStyle.Blue);
            }

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
                    model.OperCode = sn.OperCode;
                    model.ResCode = sn.ResCode;
                    model.ModuleSN = sn.ModuleSN;
                    model.InLineTime = sn.InLineTime;
                    model.OpeartionTime = DateTime.Now;
                    model.OperationId = GlobalConfig.CurrentUser.Account;
                    model.CartonNo = "";
                    model.PalletNO = sn.PalletNO;
                    model.SNStatus = "OK";
                    model.ShiftDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                    model.IsFinished = sn.IsFinished;
                    model.FinishTime = sn.FinishTime;
                    model.ActionCode = "UNPACKING";
                    model.OperationMsg = "拆箱包装解绑";

                    list.Add(model);
                }
            }

            return list;
        }


        /// <summary>
        /// 查询装修信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                string ScanSN = txtSN.Text.Trim();
                if (string.IsNullOrEmpty(ScanSN))
                    return;

                WIPSNList = wipsnLogic.GetPackings(ScanSN);
                if(WIPSNList != null &&  WIPSNList.Count > 0)
                {
                    lblQty.Text = WIPSNList.Count.ToString();
                    dataGridView.DataSource=WIPSNList;
                    txtSN.Text = "";
                    txtSN.Focus();
                }
            }
        }



        #region  无效代码
        //private bool CheckScan(string sInput, ref string msg)
        //{
        //    msg = "";
        //    bool bFlag = true;

        //    //1.验证条码是否存在
        //    WIP_SNRes SNResInfo = snresLogic.GetSNResInfo(sInput);
        //    if (SNResInfo == null)
        //    {
        //        msg = $"条码[{sInput}]在系统中不存在，请重新扫描";
        //        return false;
        //    }

        //    if (SNResInfo.BoxNumber.Length <= 0)
        //    {
        //        msg = $"条码[{sInput}]没有绑定箱号！";
        //        return false;
        //    }

        //    //2.验证是否已经扫了包装工站，是否打了报废
        //    WIPSNTracking wipsn = wipsnLogic.GetOne(sInput);
        //    if (wipsn != null)
        //    {
        //        if (wipsn.OperCode != OperCode)
        //        {
        //            msg = $"条码[{sInput}]不在包装工站，不能解绑";
        //            return false;
        //        }
        //    }
        //    List<WIP_SNRes> SNResInfolist = snresLogic.GetSnBoxList(SNResInfo.BoxNumber);
        //    dataGridView.DataSource = SNResInfolist;


        //    return bFlag;
        //}

        //private bool CheckBox(string sInput, ref string msg)
        //{
        //    msg = "";
        //    bool bFlag = true;

        //    //1.验证箱号是否存在
        //    WIP_PackagingBox Boxifon = boxLogic.GetOne(sInput);
        //    if (Boxifon == null)
        //    {
        //        msg = $"箱号[{sInput}]在系统中不存在，请重新扫描";
        //        return false;

        //    }
        //    else
        //    {

        //        List<WIP_SNRes> SNResInfolist = snresLogic.GetSnBoxList(sInput);
        //        dataGridView.DataSource = SNResInfolist;


        //    }
        //    return bFlag;
        //}
        #endregion

      
    }
}
