using Elight.Entity;
using Elight.Entity.WanWei;
using Elight.Logic.Base;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.WIP
{
    public class WIPPrintLogic : BaseLogic
    {
        public WIPPrintLog GetOne(string sn)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPPrintLog>().Single(t => t.SN == sn);
            }
        }

        public List<WIPPrintLog> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPPrintLog>().Where(t => t.OrderId == orderId).ToList();
            }
        }


        public List<WIPPrintLog> GetList(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<WIPPrintLog> queryable = db.Queryable<WIPPrintLog>().LeftJoin<BasItem>((it, bi) => it.ItemCode == bi.ItemCode);
                if (dict.ContainsKey("OrderId") && !string.IsNullOrEmpty(dict["OrderId"]))
                {
                    queryable = queryable.Where(it => it.OrderId.Contains(dict["OrderId"]));
                }
                if (dict.ContainsKey("sn") && !string.IsNullOrEmpty(dict["sn"]))
                {
                    queryable = queryable.Where(it => it.SN.Contains(dict["sn"]));
                }
                if (dict.ContainsKey("FromDate") && !string.IsNullOrEmpty(dict["FromDate"]))
                {
                    queryable = queryable.Where(it => SqlFunc.Between(it.PrintTime, dict["FromDate"].ToString(),
                        dict["ToDate"].ToString()));
                }

                return queryable.OrderBy(it => it.PrintTime, OrderByType.Asc).Select("it.* ,bi.ItemName ")
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }

        public WIPPrintLog GetWIPPrintLogInfo(string sn)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.Id, a.SN, a.ItemCode, a.OrderId, a.OperCode, a.LabelType, a.LabelName,  ");
                sql.Append(" a.LabelPath, a.PrintType, a.PrintNum, a.PrintParam, a.PrintTime, a.PrinterId  ");
                sql.Append("from WIPPrintLog a  ");
                sql.Append("where 1=1 ");
                sql.Append($"and a.SN = '{sn}' ");

                List<WIPPrintLog> list = db.Ado.SqlQuery<WIPPrintLog>(sql.ToString());
                if (list == null)
                    return null;
                else
                    return list[0];
            }
        }

        public int Insert(WIPPrintLog model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<WIPPrintLog>(model).ExecuteCommand();
            }
        }

       
    }
}
