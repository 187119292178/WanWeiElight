using Elight.Entity.Sys;
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
    public class WIPScrapLogic : BaseLogic
    {
        public WIPScrap GetOne(string sn)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPScrap>().Single(t => t.SN == sn);
            }
        }

        public List<WIPScrap> GetList(string orderId)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<WIPScrap>().Where(t => t.OrderId == orderId).ToList();
            }
        }

        public List<WIPScrap> GetList(int pageIndex, int pageSize, Dictionary<string, string> dict, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<WIPScrap> queryable = db.Queryable<WIPScrap>().LeftJoin<SysItemDetail>((it, bi) => it.ScrapCode == bi.EnCode && bi.ItemId == "629569980052148224");
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
                    queryable = queryable.Where(it => SqlFunc.Between(it.CreateTime, dict["FromDate"].ToString(),
                        dict["ToDate"].ToString()));
                }

                return queryable.OrderBy(it => it.CreateTime, OrderByType.Asc).Select("it.* ,bi.Name ")
                    .ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }

        public WIPScrap GetWIPScrapInfo(string sn)
        {
            using (var db = GetInstance())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select a.SN,a.ScrapCode,a.ScrapDesc ,a.UserId ,a.CreateTime ,a.OrderId ,a.ItemCode  ");
                sql.Append("from WIP_Scrap a  ");
                sql.Append("where 1=1 ");
                sql.Append($"and a.SN = '{sn}' ");

                List<WIPScrap> list = db.Ado.SqlQuery<WIPScrap>(sql.ToString());
                if (list == null)
                    return null;
                else
                    return list[0];
            }
        }

        public int Insert(WIPScrap model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<WIPScrap>(model).ExecuteCommand();
            }
        }

 


        public int Update(WIPScrap model)
        {
            using (var db = GetInstance())
            {


                return db.Updateable<WIPScrap>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.MatModel,
                    it.CustomerCode,
                    it.OperCode,
                    it.ResCode,
                    it.ScrapCode,
                    it.ScrapDesc,
                    it.UserId,
                    it.CreateTime,
                    it.IsScrap
                }).ExecuteCommand();
            }
        }

    }
}
