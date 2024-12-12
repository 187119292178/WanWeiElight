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
    public class WIPLaserLogic : BaseLogic
    {
        public WIPLaserLog GetOne(string sn)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPLaserLog>().Single(t => t.StartSN == sn);
            }
        }

        public List<WIPLaserLog> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPLaserLog>().Where(t => t.OrderId == orderId).ToList();
            }
        }

        public List<WIPLaserLog> GetList(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<WIPLaserLog> queryable = db.Queryable<WIPLaserLog>();
                if (dict.ContainsKey("OrderId") && !string.IsNullOrEmpty(dict["OrderId"]))
                {
                    queryable = queryable.Where(it => it.OrderId.Contains(dict["OrderId"]));
                } 
                if (dict.ContainsKey("sn") && !string.IsNullOrEmpty(dict["sn"]))
                {
                    queryable = queryable.Where(it => it.StartSN.Contains(dict["sn"]));
                }
                if (dict.ContainsKey("FromDate") && !string.IsNullOrEmpty(dict["FromDate"]))
                {
                    queryable = queryable.Where(it => SqlFunc.Between(it.ActionTime, dict["FromDate"].ToString(),
                        dict["ToDate"].ToString()));
                }

                return queryable.OrderBy(it => it.ActionTime, OrderByType.Asc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }


        public WIPLaserLog GetWIPPrintLogInfo(string sn)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.Id, a.OrderId, a.MachineNo, a.CompanyNo, a.Qty,a.StartSN, a.EndSN, a.InParam, a.ReturnData, a.ActionTime, a.ResultStatus  ");
                sql.Append("from WIPPrintLog a  ");
                sql.Append("where 1=1 ");
                sql.Append($"and a.SN = '{sn}' ");

                List<WIPLaserLog> list = db.Ado.SqlQuery<WIPLaserLog>(sql.ToString());
                if (list == null)
                    return null;
                else
                    return list[0];
            }
        }

        public int Insert(WIPLaserLog model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<WIPLaserLog>(model).ExecuteCommand();
            }
        }

    }
}
