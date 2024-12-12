using Elight.Logic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using Elight.Entity.WanWei;
using NPOI.SS.Formula.Functions;

namespace Elight.Logic.WIP
{
    public class WIPSNResLogic : BaseLogic
    {

        public List<WIP_SNRes> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIP_SNRes>().Where(t => t.OrderId == orderId).ToList();
            }
        }
        
        public List<WIP_SNRes> GetBoxList(string box)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIP_SNRes>().Where(t => t.BoxNumber == box).ToList();
            }
        }

        public List<WIP_SNRes> GetSnBoxList(string box)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.SN, a.BoxNumber ,a.ItemCode ,a.OrderId , b.ParentBoxNumber ");
                sql.Append("from WIP_SNRes a left join  WIP_PackagingBox b on a.BoxNumber = b.BoxNumber ");
                sql.Append($"where b.BoxNumber = '{box}' ");

                List<WIP_SNRes> list = db.Ado.SqlQuery<WIP_SNRes>(sql.ToString());
                if (list == null)
                    return null;
                else
                    return list;
            }
        }





        public WIP_SNRes GetSNResInfo(string sn)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.*, b.ItemName, b.ItemDesc, b.MatType, isnull(b.PackQty, 0) as PackQty ");
                sql.Append("from WIP_SNRes a, Bas_Item b ");
                sql.Append("where a.ItemCode = b.ItemCode ");
                sql.Append($"and a.SN = '{sn}' ");
                
                List<WIP_SNRes> list = db.Ado.SqlQuery<WIP_SNRes>(sql.ToString());
                if (list == null || list.Count == 0)
                    return null;
                else
                    return list[0];
            }
        }
        public List<WIP_SNRes> GetSNResInfoByBox(string box)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.*, b.ItemName, b.ItemDesc as PN ");
                sql.Append("from WIP_SNRes a, Bas_Item b ");
                sql.Append("where a.ItemCode = b.ItemCode ");
                sql.Append($"and a.BoxNumber = '{box}' ");
                
                List<WIP_SNRes> list = db.Ado.SqlQuery<WIP_SNRes>(sql.ToString());
                if (list == null || list.Count == 0)
                    return null;
                else
                    return list;
            }
        }

        public WIP_SNRes GetOne(string sn)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIP_SNRes>().Single(t => t.SN == sn);
            }
        }

        public List<WIP_SNRes> GetList(int pageIndex, int pageSize, string keyWord, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<WIP_SNRes> queryable = db.Queryable<WIP_SNRes>().Where(it => it.OrderId == keyWord);

                return queryable.OrderBy(it => it.SN , OrderByType.Asc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }
        
        public List<WIP_SNRes> GetList(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {


                ISugarQueryable<WIP_SNRes> queryable = db.Queryable<WIP_SNRes>().Where(it => it.DeleteMark == "N");
                if (dict.ContainsKey("OrderId") && !string.IsNullOrEmpty(dict["OrderId"]))
                {
                    queryable = queryable.Where(it => it.OrderId.Contains(dict["OrderId"]));
                }
                
                if (dict.ContainsKey("SN") && !string.IsNullOrEmpty(dict["SN"]))
                {
                    queryable = queryable.Where(it => it.SN.Contains(dict["SN"]));
                }
                if ((dict.ContainsKey("dpFromDate") && !string.IsNullOrEmpty(dict["dpFromDate"])) && (dict.ContainsKey("dpEndDate") && !string.IsNullOrEmpty(dict["dpEndDate"])))
                {
                    DateTime startTime = DateTime.ParseExact(dict["dpFromDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                    DateTime endTime = DateTime.ParseExact(dict["dpEndDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);

                    queryable = queryable.Where(it => it.CreateTime >= startTime && it.CreateTime <= endTime);
                }

                return queryable.OrderBy(it => it.SN , OrderByType.Asc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }


        public List<WIP_SNRes> GetList(string orderId, string fromSN, string EndSN ,int Qty)
        {
            using (var db = GetInstance())
            {
                string sql = $"select top {Qty} * from WIP_SNRes where OrderID = '{orderId}' and SN >= '{fromSN}' and SN <= '{EndSN}' ORDER BY SN asc ";
                return db.Ado.SqlQuery<WIP_SNRes>(sql);
            }
        }

         public int PrintSave(string orderId, int qty, List<WIPPrintLog> logs, string startSN, string endSN, 
               List<WIPSNTracking> wips, List<WIPSNTrackingHis> his, ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;
                try
                {
                    db.BeginTran();
                    //1.修改工单表已打印数量,；2.修改条码资源表状态；3.打印记录保存到打印日志表；4.打印的SN保存到wip当前表
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.PrintedQty == t.PrintedQty + qty)
                        .Where(t => t.OrderId == orderId).ExecuteCommand();
                    if(row <= 0)
                    {
                        sMsg = "修改工单表失败";
                        db.RollbackTran();
                        return 0;
                    }
                    //2.修改条码资源表状态
                    StringBuilder sUpdate = new StringBuilder();
                    sUpdate.Append("update WIP_SNRes set SNStatus = 'PRINTED', PrintStatus = 'Y', PrintNum = PrintNum + 1 ");
                    sUpdate.Append($"where OrderID = '{orderId}' and SN >= '{startSN}' and SN <= '{endSN}' ");
                    
                    row = db.Ado.ExecuteCommand(sUpdate.ToString());

                    //row = db.Updateable<WIP_SNRes>()
                    //        .SetColumns(t => t.SNStatus == "PRINTED")
                    //        .SetColumns(t => t.PrintStatus == "Y")
                    //        .SetColumns(t => t.PrintNum == t.PrintNum + 1)
                    //        .Where(t => t.OrderId == orderId && t.SN >= startSN && t.SN <= endSN).ExecuteCommand();
                    
                    if (row <= 0)
                    {
                        sMsg = "修改条码资源表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.打印记录保存到打印日志表
                    row = db.Insertable<WIPPrintLog>(logs).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "保存到打印日志表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //4.打印的SN保存到wip当前表
                    row = db.Insertable<WIPSNTracking>(wips).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "保存到当前WIP表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //5.保存到WIP历史记录表
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "保存到当前WIP历史履历表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    db.CommitTran();
                    return row;
                }
                catch(Exception ex)
                {
                    sMsg = ex.Message;
                    db.RollbackTran();
                    return -1;
                }
            }
        }

        public int ScanBOXSave(List<WIPPrintLog> logs, WIPSNTrackingHis his, ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;
                try
                {
                    db.BeginTran();

                    //1.打印记录保存到打印日志表
                    row = db.Insertable<WIPPrintLog>(logs).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品彩盒包装工站：保存到打印日志表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.修改当前表
                    row = db.Updateable<WIPSNTracking>()
                        .SetColumns(t => new WIPSNTracking() { OperCode = his.OperCode, ResCode = his.ResCode,
                            OpeartionTime = his.OpeartionTime, OperationId = his.OperationId, SNStatus = his.SNStatus })
                        .Where(t => t.SN == his.SN).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品彩盒包装工站：修改当前WIP表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.增加历史记录
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品彩盒包装工站：插入历史记录表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //4.修改工单对应彩盒包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.BoxQty == t.BoxQty + 1)
                        .Where(t => t.OrderId == his.OrderId).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品彩盒包装工站：修改工单表BoxQty数量失败";
                        db.RollbackTran();
                        return 0;
                    }

                    db.CommitTran();
                    return row;
                }
                catch (Exception ex)
                {
                    sMsg = ex.Message;
                    db.RollbackTran();
                    return -1;
                }
            }
        }

        public int RePrintSave(string orderId, int qty, List<WIPPrintLog> logs, string startSN, string endSN,
              List<WIPSNTracking> wips, ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;
                try
                {
                    db.BeginTran();
                   
                    //1.打印记录保存到打印日志表
                    row = db.Insertable<WIPPrintLog>(logs).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "保存到打印日志表失败";
                        db.RollbackTran();
                        return 0;
                    }
                   List<WIPSNTrackingHis>his = GetWIPSNTrackingHis(wips);
                    //2.增加历史记录
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装：插入历史记录表失败";
                        db.RollbackTran();
                        return 0;
                    }
                    db.CommitTran();
                    return row;
                }
                catch (Exception ex)
                {
                    sMsg = ex.Message;
                    db.RollbackTran();
                    return -1;
                }
            }
        }


        public string GetStartSNByOrder(string orderId)
        {
            using (var db = GetInstance())
            {
                string sql = $"select min(sn) from WIP_SNRes where OrderId = '{orderId}' and PrintStatus = 'N' ";
                return db.Ado.GetString(sql);
            }
        }

        public List<WIP_SNRes> GetWIPSNRes(string orderId, int qty)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($"select top {qty} * from WIP_SNRes ");
                sql.Append($" where DeleteMark = 'N' and OrderId = '{orderId}' and PrintStatus = 'N' order by sn ");

                return db.Ado.SqlQuery<WIP_SNRes>(sql.ToString());
            }
        }

        private List<WIPSNTrackingHis> GetWIPSNTrackingHis( List<WIPSNTracking> wiplist)
        {
            List<WIPSNTrackingHis> hislist = new List<WIPSNTrackingHis>();
            foreach (WIPSNTracking wip in wiplist)
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
                his.ActionCode = "RePrint";
                his.OperationMsg = "补打";
                hislist.Add(his);
            }
           
            return hislist;
        }



    }
}
