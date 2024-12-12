using Elight.Entity.Sys;
using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Logic.Sys;
using Elight.Logic.WIP;
using Elight.WinForm.Common;
using Mysqlx.Crud;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.WIP
{
    [PageCode("wip-scrap")]
    public partial class ScrapPage : MyPage
    {
        private string sMsg = "";
        private SysItemsDetailLogic detailLogic;
        private WIPScrapLogic scrapLogic;
        private OrderLogic orderLogic;
        private WIPSNTrackingLogic trackingLogic;
        private WIPSNTracking SNTracking;
        private WIPSNResLogic wipsnResLogic;
        private string ScanSN = "";
        private string sItemCode = "";
        private string sOrderId = "";
        private bool bUnScrap = false;
        private List<WIPScrap> list = new List<WIPScrap>();


        public ScrapPage()
        {
            InitializeComponent();
            wipsnResLogic = new WIPSNResLogic();
            scrapLogic = new WIPScrapLogic();
            detailLogic = new SysItemsDetailLogic();
            orderLogic = new OrderLogic();
            trackingLogic = new WIPSNTrackingLogic();
            SNTracking = null;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ScrapPage_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = "";

            InitForm();
            lblMsg.Text = "请选择报废代码后扫描产品条码打报废";
        }

        private void InitForm()
        {
            bUnScrap = false;
            btnCancel.Text = "报废使用";
            txtUserId.Text = GlobalConfig.CurrentUser.Account + "-" + GlobalConfig.CurrentUser.RealName;
            txtUserId.ReadOnly = true;
            txtOperCode.Text = "Scrap-报废工站";
            txtOperCode.ReadOnly = true;

            txtOrderId.Text = "";
            txtOrderId.ReadOnly = true;
            txtInput.Text = "";
            txtInput.Enabled = true;
            txtInput.Visible = true;
            txtInput.ReadOnly = false;
            lblStatus.Visible = false;
            txtDesc.Text = "";
            txtDesc.ReadOnly = false;

            //报废原因绑定
            cmbItem.ReadOnly = false;
            BindProductType();
            cmbItem.Focus();
        }

        private void BindProductType()
        {
            string scrapCodeId = ConfigurationManager.AppSettings["ScrapCodeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("scrap-code");
            cmbItem.ValueMember = "EnCode";
            cmbItem.DisplayMember = "Name";
            cmbItem.DataSource = list;
        }

        /// <summary>
        /// 扫描产品条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ScanSN = txtInput.Text.Trim();
                if (string.IsNullOrEmpty(ScanSN))
                    return;

                SNTracking = trackingLogic.GetOne(ScanSN);
                // WIP_SNRes SNRes = wipsnResLogic.GetOne(ScanSN);

                if (SNTracking == null)
                {
                    sMsg = $"条码[{ScanSN}]在系统中不存在";
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    return;
                }

                if (!CheckScan(ScanSN))
                {
                    ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                    return;
                }
                SNTracking.OpeartionTime = DateTime.Now;
                SNTracking.OperationId = GlobalConfig.CurrentUser.Id;
                SNScrapandCancel(SNTracking);
            }
        }

        private WIPScrap GetWIPScrap(WIPSNTracking wip)
        {
            WIPScrap his = new WIPScrap();

            his.SN = wip.SN;
            his.OrderId = wip.OrderId;
            his.ItemCode = wip.ItemCode;
            his.MatModel = wip.MatModel;
            his.CustomerCode = wip.CustomerCode;
            his.LineCode = wip.LineCode;
            his.OperCode = wip.OperCode;
            his.ResCode = wip.ResCode;
            his.ScrapCode = cmbItem.SelectedValue.ToString();
            his.ScrapDesc = txtDesc.Text;
            his.CreateTime = DateTime.Now;
            his.UserId = GlobalConfig.CurrentUser.Id;
            his.IsScrap = "Y";
            return his;
        }
        private WIPSNTrackingHis GetWIPSNTrackingHis(WIPSNTracking wip)
        {
            WIPSNTrackingHis his = new WIPSNTrackingHis();

            his.SN = wip.SN;
            his.OrderId = wip.OrderId;
            his.ItemCode = wip.ItemCode;
            his.MatModel = wip.MatModel;
            his.CustomerCode = wip.CustomerCode;
            his.LineCode = wip.LineCode;
            his.OperCode = wip.OperCode;
            his.ResCode = wip.ResCode;
            his.ModuleSN = wip.ModuleSN;
            his.InLineTime = wip.InLineTime;
            his.OpeartionTime = wip.OpeartionTime;
            his.OperationId = wip.OperationId;
            his.CartonNo = wip.CartonNo;
            his.PalletNO = wip.PalletNO;
            his.SNStatus = wip.SNStatus;
            his.ShiftDay = wip.ShiftDay;
            his.IsFinished = wip.IsFinished;
            his.FinishTime = wip.FinishTime;
            his.ActionCode = "SCRAP";
            his.OperationMsg = "产品报废";

            return his;
        }

        /// <summary>
        /// 报废和取消报废的校验条件
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        private bool CheckScan(string sn)
        {
            bool bFlag = true;
            if (SNTracking == null)
            {
                sMsg = $"条码[{sn}]在系统中不存在";
                return false;
            }
            if (bUnScrap)
            {
                //取消报废
                //当前表的状态要是报废状态才能取消报废
                if (SNTracking.SNStatus != "SCRAP")
                {
                    sMsg = $"条码[{sn}]不是报废状态，不能取消报废";
                    return false;
                }
            }
            else
            {
                //打报废
                //当前表的状态不能是已报废状态，不能是已经装箱，如果已经装箱要打报废，需要先解除装箱再打报废
                if (SNTracking.SNStatus == "SCRAP")
                {
                    sMsg = $"条码[{sn}]已经打了报废，不能重复报废";
                    return false;
                }
                if (!string.IsNullOrEmpty(SNTracking.CartonNo) || SNTracking.OperCode == "Packing")
                {
                    sMsg = $"条码[{sn}]已经装箱了，不能报废";
                    return false;
                }
            }

            return bFlag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "报废使用")
            {
                //取消报废
                btnCancel.Text = "取消报废";
                //btnCancel.BackColor = Color.Orange;
                btnCancel.Style = Sunny.UI.UIStyle.Orange;
                lblMsg.Text = "扫码使用取消报废功能";
                bUnScrap = true;
            }
            else
            {
                //打报废
                btnCancel.Text = "报废使用";
                //btnCancel.BackColor = Color.DodgerBlue;
                btnCancel.Style = Sunny.UI.UIStyle.Blue;
                lblMsg.Text = "扫码使用打报废功能";
                bUnScrap = false;
            }
        }


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

        /// <summary>
        /// SN报废和取消
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        private void SNScrapandCancel(WIPSNTracking SNTracking)
        {

            if (!bUnScrap)
            {
                //报废功能--当前表改成报废状态，增加历史记录，修改工单表报废数量
                WIPSNTrackingHis wIPSNTrackingHis = GetWIPSNTrackingHis(SNTracking);
                int a = trackingLogic.ScrapSN(SNTracking, wIPSNTrackingHis, "", ref sMsg);
                if (a > 0)
                {

                    OrderInfo orderInfo = orderLogic.Get(SNTracking.OrderId);
                    orderInfo.ModifyTime = DateTime.Now;
                    orderInfo.ModifyUser = GlobalConfig.CurrentUser.Id;
                    if (orderInfo == null)
                    {
                        sMsg = $"条码工单[{SNTracking.OrderId}]在系统中不存在";
                        ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                        return;
                    }
                    else
                    {

                        int scrapQty = orderLogic.UpdateScrapQty(orderInfo, "Y", 1);
                        if (scrapQty <= 0)
                        {
                            sMsg = $"条码工单[{SNTracking.OrderId}报废数量修改失败";
                            ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                            return;
                        }
                        else
                        {

                        }
                    }

                    WIPScrap Scrapdeta = GetWIPScrap(SNTracking);

                    WIPScrap ScrapInfo = scrapLogic.GetOne(SNTracking.SN);
                    if (ScrapInfo == null)
                    {
                        int deta = scrapLogic.Insert(Scrapdeta);
                    }
                    else
                    {
                        ScrapInfo.ScrapCode = cmbItem.SelectedValue.ToString();
                        ScrapInfo.ScrapDesc = txtDesc.Text;
                        ScrapInfo.CreateTime = DateTime.Now;
                        ScrapInfo.UserId = GlobalConfig.CurrentUser.Id;
                        int deta = scrapLogic.Update(ScrapInfo);
                    }

                    AddDataGridViewRow(Scrapdeta);

                    sMsg = $"条码[{ScanSN}]报废成功！";
                    ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                    return;


                }



            }
            else
            {


                //取消报废功能
                WIPSNTrackingHis wIPSNTrackingHis = GetWIPSNTrackingHis(SNTracking);
                int a = trackingLogic.UnScrapSN(SNTracking, wIPSNTrackingHis, "", ref sMsg);

                if (a > 0)
                {
                    OrderInfo orderInfo = orderLogic.Get(SNTracking.OrderId);
                    orderInfo.ModifyTime = DateTime.Now;
                    orderInfo.ModifyUser = GlobalConfig.CurrentUser.Id;
                    if (orderInfo == null)
                    {
                        sMsg = $"条码工单[{SNTracking.OrderId}]在系统中不存在";
                        ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                        return;
                    }
                    else
                    {
                        int scrapQty = orderLogic.UpdateScrapQty(orderInfo, "N", 1);
                        if (scrapQty <= 0)
                        {
                            sMsg = $"条码工单[{SNTracking.OrderId}]报废数量修改失败";
                            ScanHelpler.ScanFail(txtInput, lblStatus, lblMsg, sMsg);
                            return;
                        }
                    }

                    WIPScrap Scrapdeta = GetWIPScrap(SNTracking);

                    WIPScrap ScrapInfo = scrapLogic.GetOne(SNTracking.SN);

                    if (ScrapInfo == null)
                    {
                        int deta = scrapLogic.Insert(Scrapdeta);
                    }
                    else
                    {
                        ScrapInfo.ScrapCode = cmbItem.SelectedValue.ToString();
                        ScrapInfo.ScrapDesc = txtDesc.Text;
                        ScrapInfo.CreateTime = DateTime.Now;
                        ScrapInfo.UserId = GlobalConfig.CurrentUser.Id;
                        ScrapInfo.IsScrap = "N";
                        int deta = scrapLogic.Update(ScrapInfo);

                    }
                    AddDataGridViewRow(Scrapdeta);

                    sMsg = $"条码[{ScanSN}]取消报废成功！";
                    ScanHelpler.ScanSuccess(txtInput, lblStatus, lblMsg, sMsg);
                    return;

                }

            }
        }

        public void AddDataGridViewRow(WIPScrap ScrapInfo)
        {
            //GetPartCount(mPubBasReelInfo.PartNo);
            DataTable dt = new DataTable();
            if (dataGridView.DataSource != null)
            {
                dt = dataGridView.DataSource as DataTable;
            }
            else
            {
                dt.Columns.Add("SN");
                dt.Columns.Add("ScrapCode");
                dt.Columns.Add("ScrapDesc");
                dt.Columns.Add("UserId");
                dt.Columns.Add("CreateTime");
                dt.Columns.Add("OrderId");
                dt.Columns.Add("ItemCode");
            }

            DataRow dr = dt.NewRow();
            dr["SN"] = ScrapInfo.SN;
            dr["ScrapCode"] = ScrapInfo.ScrapCode;
            dr["ScrapDesc"] = ScrapInfo.ScrapDesc;
            dr["UserId"] = ScrapInfo.UserId;
            dr["CreateTime"] = ScrapInfo.CreateTime;
            dr["OrderId"] = ScrapInfo.OrderId;
            dr["ItemCode"] = ScrapInfo.ItemCode;
            dt.Rows.InsertAt(dr, 0);
            if (dt.Rows.Count > 50)
            {
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
            }
            dt.AcceptChanges();
            dataGridView.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (!this.ShowAskDialog("您是否确定要重置扫描吗？", UIStyle.White))
            {
                return;
            }

            InitForm();
            dataGridView.DataSource = null;
        }

        public override void Stop()
        {

        }
    }
}
