using Elight.Entity.WanWei;
using Elight.Logic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.WIP
{
    public class WIPSNTrackingLogic : BaseLogic
    {
        public WIPSNTracking GetOne(string sn)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPSNTracking>().Single(t => t.SN == sn);
            }
        }

        public List<WIPSNTracking> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPSNTracking>().Where(t => t.OrderId == orderId).ToList();
            }
        }
        

        public int PackingSave(List<WIPSNTracking> wips, List<WIPSNTrackingHis> hiss, List<WIPPrintLog> logs,  ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;
                try
                {
                    db.BeginTran();

                    //1.修改wip当前表
                    row = db.Updateable<WIPSNTracking>(wips).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装扫描失败：修改当前表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.新增记录到历史履历表
                    row = db.Insertable<WIPSNTrackingHis>(hiss).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装扫描失败：保存历史履历表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.修改包装信息记录表
                    row = db.Updateable<WIP_PackagingBox>()
                        .SetColumns(t => new WIP_PackagingBox()
                        { Status = "BIND", Quantity = wips.Count, IsEnabled = "Y", Remarks = "包装绑定箱号", ModifyTime = DateTime.Now })
                        .Where(t => t.BoxNumber == wips[0].CartonNo)
                        .ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装扫描失败：修改包装信息表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //4.修改工单表包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => new OrderInfo() { PackQty = t.PackQty + wips.Count })
                        .Where(t => t.OrderId == wips[0].OrderId).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装扫描失败：修改工单表包装数量失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //5.新增打印日志
                    row = db.Insertable<WIPPrintLog>(logs).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品包装扫描失败：新增打印日志表失败";
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


        public int ScrapSN(WIPSNTracking wip, WIPSNTrackingHis his, string userId, ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;

                try
                {
                    db.BeginTran();

                    //1.修改wip当前表
                    string swipSql = $"update WIP_SNTracking set SNStatus = 'SCRAP', OpeartionTime = getdate(), OperationId = '{userId}',  "
                                   + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                   + $"where sn = '{wip.SN}' ";
                    row = db.Ado.ExecuteCommand(swipSql);
                    if (row <= 0)
                    {
                        sMsg = "产品打报废失败：修改当前表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.增加历史记录
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品打报废失败：插入历史记录表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.修改工单表报废数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.ScrapQty == t.ScrapQty + 1)
                        .Where(t => t.OrderId == wip.OrderId).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品打报废失败：修改工单表失败";
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

        public List<WIPSNTracking> GetPackings(string sInput)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT SN, OrderId, ItemCode, CartonNo from WIP_SNTracking ");
                sql.Append($" WHERE CartonNo = '{sInput}' ");
                sql.Append(" UNION ALL ");
                sql.Append(" SELECT SN, OrderId, ItemCode, CartonNo from WIP_SNTracking ");
                sql.Append($"WHERE CartonNo IN  (SELECT CartonNo FROM WIP_SNTracking WHERE SN = '{sInput}')");

                return db.Ado.SqlQuery<WIPSNTracking>(sql.ToString());
            }
        }

        public int UnScrapSN(WIPSNTracking wip, WIPSNTrackingHis his, string userId, ref string sMsg)
        {
            using (var db = GetInstance())
            {
                sMsg = "";
                int row = 0;

                try
                {
                    db.BeginTran();

                    //1.修改wip当前表
                    string swipSql = $"update WIP_SNTracking set SNStatus = 'GOOD', OpeartionTime = getdate(), OperationId = '{userId}',  "
                                   + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                   + $"where sn = '{wip.SN}' ";
                    row = db.Ado.ExecuteCommand(swipSql);
                    if (row <= 0)
                    {
                        sMsg = "产品取消报废失败：修改当前表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.增加历史记录
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品取消报废失败：插入历史记录表失败";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.修改工单表报废数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.ScrapQty == t.ScrapQty - 1)
                        .Where(t => t.OrderId == wip.OrderId).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "产品取消报废失败：修改工单表失败";
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

    }
}
