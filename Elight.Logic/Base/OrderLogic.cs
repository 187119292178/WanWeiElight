using Elight.Entity;
using Elight.Entity.WanWei;
using Mysqlx.Crud;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.Base
{
    public class OrderLogic : BaseLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="param"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<OrderInfo> GetList(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<OrderInfo> queryable = db.Queryable<OrderInfo, BasItem>((OrderInfo it, BasItem bi) => new object[] {
                      JoinType.Left,it.ItemCode  ==  bi.ItemCode,}).Where((it, bi) => it.DeleteMark == "N");

                if (dict.ContainsKey("OrderId") && !string.IsNullOrEmpty(dict["OrderId"]))
                {
                    queryable = queryable.Where(it => it.OrderId.Contains(dict["OrderId"]));
                }
                if (dict.ContainsKey("ItemCode") && !string.IsNullOrEmpty(dict["ItemCode"]))
                {
                    queryable = queryable.Where(it => it.ItemCode.Contains(dict["ItemCode"]));
                }
                if (dict.ContainsKey("State") && !string.IsNullOrEmpty(dict["State"]))
                {
                    queryable = queryable.Where(it => it.OrderStatus == dict["State"]);
                }
                if (dict.ContainsKey("MatType") && !string.IsNullOrEmpty(dict["MatType"])
                    && dict["MatType"].ToUpper() != "ALL" )
                {
                    queryable = queryable.Where(it => it.MatType == dict["MatType"] );
                }

                if ((dict.ContainsKey("dpFromDate") && !string.IsNullOrEmpty(dict["dpFromDate"]))&& (dict.ContainsKey("dpEndDate") && !string.IsNullOrEmpty(dict["dpEndDate"])))
                {
                    DateTime startTime = DateTime.ParseExact(dict["dpFromDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                    DateTime endTime = DateTime.ParseExact(dict["dpEndDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture).AddDays(1);

                    queryable = queryable.Where(it => it.CreateTime  >= startTime && it.CreateTime <= endTime);
                }

                 queryable.OrderBy(it => it.ModifyTime, OrderByType.Desc)
                    .Select("it.* ,bi.ItemName as BasItemName ,bi.ItemDesc as BasItemDesc ")
                    .ToPageList(pageIndex, pageSize, ref totalCount);
                string aa = queryable.ToSql().ToString();
                return queryable.ToList();
            }
        }

        public List<OrderInfo> GetPrintOrderllist(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                string sql = "select a.OrderId, a.ItemCode, b.ItemName, b.ItemDesc, a.MatModel,a.MatType, a.TargetQty, a.InputQty,  a.CreatedQty, a.PrintedQty, "
                       + "a.PackQty, a.CreateTime, a.ReleaseDate, a.PlanStartDate, a.PlanEndDate, a.OrderStatus, a.OrderType "
                       + "from OrderInfo a, Bas_Item b "
                       + "where a.ItemCode = b.ItemCode "
                       //+ "and a.TargetQty > a.PrintedQty "
                       + "and a.IsEnabled = 'Y' ";
                /*if (!string.IsNullOrEmpty(orderId))
                    sql += $"and a.OrderId like '%{orderId}%' ";*/

                sql += "order by a.ModifyTime desc ";

                return db.Ado.SqlQuery<OrderInfo>(sql);
            }
        }

        public List<OrderInfo> GetPrintOrder(string orderId)
        {
            using (var db = GetInstance())
            {
                string sql = "select a.OrderId, a.ItemCode, b.ItemName as BasItemName, b.ItemDesc  as BasItemDesc, a.MatModel,a.MatType, a.ProductType, a.TargetQty, a.InputQty,  a.CreatedQty, a.PrintedQty, "
                       + "a.PackQty, a.CreateTime, a.ReleaseDate, a.PlanStartDate, a.PlanEndDate, a.OrderStatus, a.OrderType "
                       + "from OrderInfo a, Bas_Item b "
                       + "where a.ItemCode = b.ItemCode "
                       //+ "and a.TargetQty > a.PrintedQty "
                       + "and a.IsEnabled = 'Y' ";
                if (!string.IsNullOrEmpty(orderId))
                    sql += $"and a.OrderId like '%{orderId}%' ";

                sql += "order by a.ModifyTime desc ";

                return db.Ado.SqlQuery<OrderInfo>(sql);
            }
        }


        public List<WIP_SNRes> GetSNResbyOrderId(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {

                ISugarQueryable<WIP_SNRes> queryable = db.Queryable<WIP_SNRes>().RightJoin<WIP_PackagingBox>((it, bi) => it.BoxNumber == bi.BoxNumber).
                    Where((it, bi) => it.DeleteMark == "N")
                    .WhereIF((dict.ContainsKey("BoxNumber") && !string.IsNullOrEmpty(dict["BoxNumber"])), (it, bi) => bi.BoxNumber.Contains(dict["BoxNumber"]))
                    .WhereIF((dict.ContainsKey("SN") && !string.IsNullOrEmpty(dict["SN"])), (it, bi) => it.SN.Contains(dict["SN"]))
                    .WhereIF((dict.ContainsKey("OrderId") && !string.IsNullOrEmpty(dict["OrderId"])), (it, bi) => bi.WorkOrder.Contains(dict["OrderId"]))
                    .WhereIF(((dict.ContainsKey("dpFromDate") && !string.IsNullOrEmpty(dict["dpFromDate"])) && (dict.ContainsKey("dpEndDate") && !string.IsNullOrEmpty(dict["dpEndDate"]))),
                    (it, bi) => bi.CreatedTime >= DateTime.ParseExact(dict["dpFromDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture) &&
                    bi.CreatedTime <= DateTime.ParseExact(dict["dpEndDate"].Trim().ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture)); 
               
                return queryable.OrderBy(it => it.ModifyTime, OrderByType.Asc)
                    .Select("it.* ,bi.CreatedTime as BoxCreatedTime ,bi.CreateUser as BoxCreateUser , bi.BoxNumber as BoxParentBoxNumber ,bi.Status as BoxStatus").
                    ToPageList(pageIndex, pageSize, ref totalCount).ToList();
            }
        }

        public List<WIP_SNRes> GetSNResbyOrderId(int pageIndex, int pageSize, string orderId, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<WIP_SNRes> queryable = db.Queryable<WIP_SNRes>().Where(it => it.DeleteMark == "N");
                queryable = queryable.Where(it => it.OrderId == orderId);

                return queryable.OrderBy(it => it.ModifyTime, OrderByType.Asc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }

       

        public OrderInfo Get(string primaryKey)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<OrderInfo>().Where(t => t.OrderId == primaryKey).First();
            }
        }

        public int Insert(OrderInfo model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<OrderInfo>(model).ExecuteCommand();
            }
        }

        public int Insert(List<OrderInfo> list)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<OrderInfo>(list).ExecuteCommand();
            }
        }

        public int Update(OrderInfo model)
        {
            using (var db = GetInstance())
            {
                return db.Updateable<OrderInfo>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.TargetQty,
                    it.MatType,
                    it.MatModel,
                    it.ProductType,
                    it.ReleaseDate,
                    it.PlanEndDate,
                    it.Remark,
                    it.ModifyUser,
                    it.ModifyTime
                }).ExecuteCommand();
            }
        }
        
        public int UpdateSNRule(OrderInfo model)
        {
            using (var db = GetInstance())
            {
                int row = 0;
                try
                {
                    db.Ado.BeginTran();
                    //3.修改工单表的生码数量
                    row = db.Updateable<OrderInfo>().SetColumns(t => t.SNRule == model.SNRule)
                        .Where(t => t.OrderId == model.OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }

                    db.Ado.CommitTran();
                    return row;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public int UpdateScrapQty(OrderInfo model,string Y ,int qty)
        {
            using (var db = GetInstance())
            {
                if (Y.Equals("Y"))
                {
                    model.ScrapQty += qty;
                }
                else {
                    model.ScrapQty -= qty;
                }
                 
                return db.Updateable<OrderInfo>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.TargetQty,
                    it.MatType,
                    it.MatModel,
                    it.ProductType,
                    it.ReleaseDate,
                    it.PlanEndDate,
                    it.Remark,
                    it.ModifyUser,
                    it.ModifyTime,
                    it.ScrapQty
                }).ExecuteCommand();
            }
        }

        public int UpdateBoxQty(OrderInfo model, string Y, int qty)
        {
            using (var db = GetInstance())
            {
                if (Y.Equals("Y"))
                {
                    model.BoxQty += qty;
                }
                else
                {
                    model.BoxQty -= qty;
                }

                return db.Updateable<OrderInfo>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.TargetQty,
                    it.MatType,
                    it.MatModel,
                    it.ProductType,
                    it.ReleaseDate,
                    it.BoxQty,
                    it.PlanEndDate,
                    it.Remark,
                    it.ModifyUser,
                    it.ModifyTime,
                    it.ScrapQty
                }).ExecuteCommand();
            }
        }

        public int UpdatePackQty(OrderInfo model, string Y, int qty)
        {
            using (var db = GetInstance())
            {
                if (Y.Equals("Y"))
                {
                    model.BoxQty += qty;
                }
                else
                {
                    model.BoxQty -= qty;
                }

                return db.Updateable<OrderInfo>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.TargetQty,
                    it.MatType,
                    it.MatModel,
                    it.ProductType,
                    it.ReleaseDate,
                    it.BoxQty,
                    it.PlanEndDate,
                    it.Remark,
                    it.ModifyUser,
                    it.ModifyTime,
                    it.ScrapQty
                }).ExecuteCommand();
            }
        }

        public int Delete(string OrderId)
        {
            using (var db = GetInstance())
            {
                OrderInfo queryable = db.Queryable<OrderInfo>().Where(it => it.OrderId == OrderId).First();
                if (queryable == null)
                    return 0;
                queryable.DeleteMark = "Y";
                return db.Updateable<OrderInfo>(queryable).ExecuteCommand();
            }
        }

        public List<OrderInfo> GetOrders(Dictionary<string, string> dict)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<OrderInfo> queryable = db.Queryable<OrderInfo>().Where(it => it.DeleteMark == "N");
                if(dict.ContainsKey("ItemCode") && !string.IsNullOrEmpty(dict["ItemCode"]))
                {
                    queryable = queryable.Where(t => t.ItemCode == dict["ItemCode"]);
                }

                return queryable.ToList();
            }
        }

    }
}
