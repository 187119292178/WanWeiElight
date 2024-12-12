using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Mysqlx.Crud;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.WIP
{
    public class WIPPackagingBoxLogic : BaseLogic
    {
        public WIP_PackagingBox GetOne(string boxNumber)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIP_PackagingBox>().Where(t => t.BoxNumber == boxNumber).First();
            }
        }

        public List<WIP_PackagingBox> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIP_PackagingBox>().Where(t => t.WorkOrder == orderId).ToList();
            }
        }

        public int Insert(WIP_PackagingBox model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<WIP_PackagingBox>(model).ExecuteCommand();
            }
        }
        
        public int SnbindingPacking(WIP_PackagingBox model,List<WIPSNTracking> wIPSNTrackings)
        {
            int row = 1;
            string sMsg = "";

            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();
                    // 新增箱号
                    int box =  db.Updateable<WIP_PackagingBox>(model).ExecuteCommand();
                    if (box <= 0)
                    {
                        sMsg = "产品包装：新增箱号失败！";
                        db.RollbackTran();
                        return 0;
                    }
                    string sns = "";
                    // SN 记录过站信息
                    foreach (var tracking in wIPSNTrackings)
                    {
                        //1.修改wip当前表
                        string swipSql = $"update WIP_SNTracking set OperCode = 'PACKING', CartonNo ='{model.BoxNumber}', OpeartionTime = getdate(), OperationId = '{model.CreateUser}',  "
                                       + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                       + $"where sn = '{tracking.SN}' ";
                        row = db.Ado.ExecuteCommand(swipSql);
                        if (row <= 0)
                        {
                            sMsg = "产品包装：保存失败";
                            db.RollbackTran();
                            return 0;
                        }

                        WIPSNTrackingHis his = GetWIPSNTrackingHis(tracking);

                        //2.增加历史记录
                        row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                        if (row <= 0)
                        {
                            sMsg = "产品包装：插入历史记录表失败";
                            db.RollbackTran();
                            return 0;
                        }
                        sns+="'"+ tracking.SN + "',";
                    }
                    //SN 绑定箱号 
                    if (sns.Length > 0)
                    {
                        string sn = sns.Substring(0, sns.Length - 1);

                        //2.修改条码资源表状态
                        StringBuilder sUpdate = new StringBuilder();
                        sUpdate.Append($"update WIP_SNRes set BoxNumber = '{model.BoxNumber}',  ModifyTime = getdate() ,ModifyUser ='{model.CreateUser}' ");
                        sUpdate.Append($"where SN IN ({sn}) ");
                        row = db.Ado.ExecuteCommand(sUpdate.ToString());
                        if (row <= 0)
                        {
                            sMsg = "彩箱包装：工单包装数量修改失败";
                            db.RollbackTran();
                            return 0;

                        }
                    }
                    //3.修改工单表的包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.PackQty == t.PackQty + wIPSNTrackings.Count)
                        .Where(t => t.OrderId == wIPSNTrackings[0].OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        sMsg = "产品包装：产品工单彩箱数量修改失败";

                        db.Ado.RollbackTran();
                        return row;
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

        public int UnPackingAll(WIP_PackagingBox box, List<WIPSNTracking> wips, List<WIPSNTrackingHis> hiss, ref string sMsg)
        {
            int row = 0;
            sMsg = "";
            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();

                    //1.修改包装表状态
                    row = db.Updateable<WIP_PackagingBox>(box).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装全部解绑：修改包装箱号信息表失败！";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.修改当前表
                    row = db.Updateable<WIPSNTracking>(wips).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装全部解绑：修改产品当前信息表失败！";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.修改工单表
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.PackQty == t.PackQty - wips.Count())
                       .Where(t => t.OrderId == box.WorkOrder)
                       .ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装全部解绑：修改工单信息表失败！";
                        db.Ado.RollbackTran();
                        return row;
                    }

                    //4.新增履历记录
                    row = db.Insertable<WIPSNTrackingHis>(hiss).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装全部解绑：新增历史履历信息表失败！";
                        db.Ado.RollbackTran();
                        return row;
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

        /// <summary>
        /// 解绑箱号--单独解绑一个
        /// </summary>
        /// <param name="wip"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public int UnPacking(WIPSNTracking wip, WIP_PackagingBox box, ref string sMsg)
        {
            int row = 0;
            sMsg = "";
            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();

                    //1.修改WIP当前表
                    row = db.Updateable<WIPSNTracking>(wip).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装单独解绑：修改产品当前信息表失败！";
                        db.RollbackTran();
                        return 0;
                    }

                    //2.修改包装信息表
                    row = db.Updateable<WIP_PackagingBox>(box).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装单独解绑：修改包装箱号信息表失败！";
                        db.RollbackTran();
                        return 0;
                    }

                    //3.修改工单表包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.PackQty == t.PackQty - 1)
                       .Where(t => t.OrderId == wip.OrderId)
                       .ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装单独解绑：修改工单信息表失败！";
                        db.Ado.RollbackTran();
                        return row;
                    }

                    //4.插入历史记录表
                    WIPSNTrackingHis his = GetWIPSNTrackingHis(wip);
                    his.ActionCode = "UNBINDING";
                    his.OperationMsg = "解绑箱号";
                    his.CartonNo = "";
                    row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                    if (row <= 0)
                    {
                        sMsg = "包装单独解绑：插入历史记录表失败";
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

        public int SnUnbindingPacking(WIP_PackagingBox model,List<WIPSNTracking> wIPSNTrackings)
        {
            int row = 0;
            string sMsg = "";

            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();
                    // 新增箱号
                    int box =  db.Updateable<WIP_PackagingBox>(model).ExecuteCommand();
                    if (box <= 0)
                    {
                        sMsg = "产品包装：新增箱号失败！";
                        db.RollbackTran();
                        return 0;
                    }
                    string sns = "";
                    // SN 记录过站信息
                    foreach (var tracking in wIPSNTrackings)
                    {
                        //1.修改wip当前表
                        string swipSql = $"update WIP_SNTracking set OperCode = 'UNBINDING',CartonNo = '' ,OpeartionTime = getdate(), OperationId = '{model.CreateUser}',  "
                                       + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                       + $"where sn = '{tracking.SN}' ";
                        row = db.Ado.ExecuteCommand(swipSql);
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：保存失败";
                            db.RollbackTran();
                            return 0;
                        }

                        WIPSNTrackingHis his = GetWIPSNTrackingHis(tracking);
                        his.ActionCode = "UNBINDING";
                        his.OperationMsg = "解绑箱号";
                        his.CartonNo = "";
                        //2.增加历史记录
                        row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：插入历史记录表失败";
                            db.RollbackTran();
                            return 0;
                        }
                        sns+="'"+ tracking.SN + "',";
                    }
                    //SN 解绑箱号 
                    if (sns.Length > 0)
                    {
                        string sn = sns.Substring(0, sns.Length - 1);
                        //2.修改条码资源表状态
                        StringBuilder sUpdate = new StringBuilder();
                        sUpdate.Append($"update WIP_SNRes set BoxNumber = '' ,ModifyTime = getdate() ,ModifyUser ='{model.CreateUser}' ");
                        sUpdate.Append($"where SN IN ({sn}) ");
                        row = db.Ado.ExecuteCommand(sUpdate.ToString());
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：产品解绑箱号失败";
                            db.RollbackTran();
                            return 0;

                        }
                    }

                    //3.修改工单表的包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.PackQty == t.PackQty - wIPSNTrackings.Count)
                        .Where(t => t.OrderId == wIPSNTrackings[0].OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        sMsg = "产品包装：工单彩箱数量修改失败";
                        db.Ado.RollbackTran();
                        return row;
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

        //记录彩箱
        public int SnbindingBox( List<WIPSNTracking> wIPSNTrackings)
        {
            int row = 1;
            string sMsg = "";

            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();
                    // SN 记录过站信息
                    foreach (var tracking in wIPSNTrackings)
                    {
                        //1.修改wip当前表
                        string swipSql = $"update WIP_SNTracking set OperCode = 'PACKINGBOX', OpeartionTime = getdate(), OperationId = '{tracking.OperationId}',  "
                                       + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                       + $"where sn = '{tracking.SN}' ";
                        row = db.Ado.ExecuteCommand(swipSql);
                        if (row <= 0)
                        {
                            sMsg = "彩箱包装：保存失败";
                            db.RollbackTran();
                            return 0;
                        }
                        WIPSNTrackingHis his = GetWIPSNTrackingHis(tracking);
                        his.ActionCode = "PACKINGBOX";
                        his.OperationMsg = "彩箱包装";
                        //2.增加历史记录
                        row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                        if (row <= 0)
                        {
                            sMsg = "彩箱包装：插入历史记录表失败";
                            db.RollbackTran();
                            return 0;
                        }
                    }
                    //2.修改工单表的包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.BoxQty == t.BoxQty + wIPSNTrackings.Count)
                        .Where(t => t.OrderId == wIPSNTrackings[0].OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
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
        public int SnUnbindingBox(WIP_PackagingBox model, List<WIPSNTracking> wIPSNTrackings)
        {
            int row = 0;
            string sMsg = "";

            using (var db = GetInstance())
            {
                try
                {
                    db.BeginTran();
                    // 新增箱号
                    int box = db.Updateable<WIP_PackagingBox>(model).ExecuteCommand();
                    if (box <= 0)
                    {
                        sMsg = "产品包装：新增箱号失败！";
                        db.RollbackTran();
                        return 0;
                    }
                    string sns = "";
                    // SN 记录过站信息
                    foreach (var tracking in wIPSNTrackings)
                    {
                        //1.修改wip当前表
                        string swipSql = $"update WIP_SNTracking set OperCode = 'UNBINDINGBOX', CartonNo ='', OpeartionTime = getdate(), OperationId = '{model.CreateUser}',  "
                                       + $"ShiftDay = convert(varchar(8), getdate(), 112) "
                                       + $"where sn = '{tracking.SN}' ";
                        row = db.Ado.ExecuteCommand(swipSql);
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：保存失败";
                            db.RollbackTran();
                            return 0;
                        }
                        tracking.CartonNo = "";
                        WIPSNTrackingHis his = GetWIPSNTrackingHis(tracking);
                        his.ActionCode = "UNBINDINGBOX";
                        his.OperationMsg = "解绑彩箱";

                        //2.增加历史记录
                        row = db.Insertable<WIPSNTrackingHis>(his).ExecuteCommand();
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：插入历史记录表失败";
                            db.RollbackTran();
                            return 0;
                        }
                        sns += "'" + tracking.SN + "',";
                    }
                    //SN 绑定箱号 
                    if (sns.Length > 0)
                    {
                        string sn = sns.Substring(0, sns.Length - 1);

                        //2.修改条码资源表状态
                        StringBuilder sUpdate = new StringBuilder();
                        sUpdate.Append($"update WIP_SNRes set BoxNumber = '' ,ModifyTime = getdate() ,ModifyUser ='{model.CreateUser}' ");
                        sUpdate.Append($"where SN IN ({sn}) ");
                        row = db.Ado.ExecuteCommand(sUpdate.ToString());
                        if (row <= 0)
                        {
                            sMsg = "包装解绑：产品解绑箱号失败";
                            db.RollbackTran();
                            return 0;

                        }
                    }

                    //3.修改工单表的包装数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.BoxQty == t.BoxQty - wIPSNTrackings.Count)
                        .Where(t => t.OrderId == wIPSNTrackings[0].OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        sMsg = "包装解绑：产品工单包装数量修改失败";
                        db.Ado.RollbackTran();
                        return row;
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

        public int Insert(List<WIP_PackagingBox> list)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<WIP_PackagingBox>(list).ExecuteCommand();
            }
        }


        public int Update(WIP_PackagingBox model)
        {
            using (var db = GetInstance())
            {


                return db.Updateable<WIP_PackagingBox>(model).UpdateColumns(it => new
                {
                    it.BoxNumber ,
                    it.Status ,
                    it.WorkOrder,
                    it.Type,
                    it.ProductNumber,
                    it.ParentBoxNumber ,
                    it.Remarks ,
                    it.TotalQuantity ,
                    it.IsEnabled ,
                    it.CreatedTime,
                    it.CreateUser,
            }).ExecuteCommand();
            }
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
            his.ActionCode = "PACKING";
            his.OperationMsg = "包装";

            return his;
        }



    }
}
