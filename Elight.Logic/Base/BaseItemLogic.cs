using Elight.Entity;
using Elight.Logic.Base;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic
{
    public class BaseItemLogic : BaseLogic
    {

        /// <summary>
        /// 获得物料列表分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="keyWord"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<BasItem> GetList(int pageIndex, int pageSize, string keyWord, string matType, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<BasItem> queryable = db.Queryable<BasItem>().Where(it => it.DeleteMark == "N");
                if (!string.IsNullOrEmpty(keyWord))
                {
                    queryable = queryable.Where(it => it.ItemCode.Contains(keyWord) || it.ItemName.Contains(keyWord));
                }
                if(!string.IsNullOrEmpty(matType))
                {
                    queryable = queryable.Where(t => t.MatType == matType);
                }
                return queryable.OrderBy(it => it.ModifyTime, OrderByType.Desc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
                //.Includes(it => it.CreateUser)
                //.Includes(it => it.ModifyUser).ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }

        public BasItem Get(string primaryKey)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<BasItem>().Where(t => t.ItemCode == primaryKey).First();
            }
        }

        public int Insert(BasItem model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<BasItem>(model).ExecuteCommand();
            }
        }

        public int Insert(List<BasItem> list)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<BasItem>(list).ExecuteCommand();
            }
        }

        public int Delete(string keyvalue)
        {
            using (var db = GetInstance())
            {
                return db.Deleteable<BasItem>().Where(t => t.ItemCode == keyvalue).ExecuteCommand();
            }
        }

        public int Update(BasItem model)
        {
            using (var db = GetInstance())
            {
                return db.Updateable<BasItem>(model).UpdateColumns(it => new
                {
                    it.ItemName,
                    it.ItemDesc,
                    it.MatType,
                    it.MatModel,
                    it.PackQty,
                    it.PalletQty,
                    it.OutputDesc,
                    it.SourceDesc,
                    it.ModifyUser,
                    it.ModifyTime
                }).ExecuteCommand();
            }
        }


    }
}
