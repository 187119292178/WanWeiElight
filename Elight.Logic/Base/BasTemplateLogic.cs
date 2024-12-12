using Elight.Entity.WanWei;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.Base
{
    public class BasTemplateLogic : BaseLogic
    {
        public BasTemplate GetOne(string itemCode, string tempType)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<BasTemplate>().Where(t => t.ItemCode == itemCode && t.TemplateType == tempType).First();
            }
        }
        public BasTemplate GetOnedeleteMark(string itemCode, string tempType,string deleteMark)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<BasTemplate>().Where(t => t.ItemCode == itemCode && t.TemplateType == tempType && t.DeleteMark == deleteMark).First();
            }
        }

        public int Insert(BasTemplate model)
        {
            using (var db = GetInstance())
            {
                return db.Insertable<BasTemplate>(model).ExecuteCommand();
            }
        }

        public int Update(BasTemplate model)
        {
            using (var db = GetInstance())
            {
                return db.Updateable<BasTemplate>(model).UpdateColumns(it => new
                {
                    it.ItemCode,
                    it.TemplateType,
                    it.HostURL,
                    it.TemplateURL,
                    it.TemplateName,
                    it.PrintCount,
                    it.Remark,
                    it.RemoteName,
                    it.IsEnabled,
                    it.DeleteMark,
                    it.ModifyUser,
                    it.ModifyTime
                }).ExecuteCommand();
            }
        }


        public int Delete(string itemCode, string type)
        {
            using (var db = GetInstance())
            {
                BasTemplate queryable = db.Queryable<BasTemplate>().Where(it => it.ItemCode == itemCode&& it.TemplateType == type).First();
                if (queryable == null)
                    return 0;
                queryable.DeleteMark = "Y";
                return db.Updateable<BasTemplate>(queryable).ExecuteCommand();
            }
        }

        /// <summary>
        /// 获得用户列表分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="keyWord"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<BasTemplate> GetList(int pageIndex, int pageSize, string keyWord, ref int totalCount)
        {
            using (var db = GetInstance())
            {
                ISugarQueryable<BasTemplate> queryable = db.Queryable<BasTemplate>().Where(it => it.DeleteMark == "N");
                if (!string.IsNullOrEmpty(keyWord))
                {
                    queryable = queryable.Where(it => it.ItemCode.Contains(keyWord) );
                }
                return queryable.OrderBy(it => it.ModifyTime, OrderByType.Desc)
                    .ToPageList(pageIndex, pageSize, ref totalCount);
                //.Includes(it => it.CreateUser)
                //.Includes(it => it.ModifyUser).ToPageList(pageIndex, pageSize, ref totalCount);
            }
        }

        public bool PrintRecord(string itemCode, string type)
        {
            using (var db = GetInstance())
            {
                int iCount = 0;
                if(type == "SN")
                {
                    //查看是否有打印产品模板
                    string sql = $"select count(*) from WIP_SNRes where ItemCode = '{itemCode}'";
                    iCount = db.Ado.GetInt(sql);
                }
                else
                {
                    string sql = $"select count(*) from WIP_SNTracking where ItemCode = '{itemCode}' and OperCode = 'Packing'";
                    iCount = db.Ado.GetInt(sql);
                }

                if (iCount == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


    }
}
