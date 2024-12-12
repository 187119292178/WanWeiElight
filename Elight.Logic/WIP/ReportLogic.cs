using Elight.Entity.WanWei;
using Elight.Logic.Base;
using ServiceStack.Text;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Elight.Logic.WIP
{
    public class ReportLogic : BaseLogic
    {

        public List<WIPLaserLog> GetWIPLaserLogList(string fromdate, string todate, string orderId, string sn)
        {
            using (var db = GetInstance())
            {
                string sql = $"select *, case when ResultStatus = 0 then '成功' else '失败' end ResultName "
                           + "from WIP_LaserLog "
                           + "where 1 = 1 ";
                if (!string.IsNullOrEmpty(orderId))
                    sql += $"and OrderId = '{orderId}' ";
                if (!string.IsNullOrEmpty(sn))
                {
                    sql += $"and StartSN > = '{sn}' "
                         + $"and EndSN <= '{sn}' ";
                }
                if (!string.IsNullOrEmpty(fromdate) && !string.IsNullOrEmpty(todate))
                {
                    sql += $"and ActionTime >= '{fromdate} 00:00:01' "
                        +  $"and ActionTime <= '{todate} 23:59:59' ";
                }

                return db.Ado.SqlQuery<WIPLaserLog>(sql);
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
                if (dict.ContainsKey("FromDate") && !string.IsNullOrEmpty(dict["FromDate"]))
                {
                    queryable = queryable.Where(it => SqlFunc.Between(it.ActionTime, dict["FromDate"].ToString(),
                        dict["ToDate"].ToString()));
                }

                return queryable.OrderBy(it => it.ActionTime, OrderByType.Asc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }


    }
}
