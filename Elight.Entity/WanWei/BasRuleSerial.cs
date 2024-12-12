using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    [SugarTable("Bas_RuleSerial")]
    public class BasRuleSerial
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string RULE_NAME { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string PREFIX { get; set; }

        public string LAST_SERIALNO { get; set; }

        public int LAST_SEQNO { get; set; }

        /// <summary>
        /// 机型代码
        /// </summary>
        public string MatModel { get; set; }

        /// <summary>
        /// 机型代码后缀
        /// </summary>
        public string ModelSuffix { get; set; }

        /// <summary>
        /// 年份代码
        /// </summary>
        public string YearCode { get; set; }

        /// <summary>
        /// 月份代码
        /// </summary>
        public string MonthCode { get; set; }

        /// <summary>
        /// 日期代码
        /// </summary>
        public string DayCode { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductDate { get; set; }
    }
}
