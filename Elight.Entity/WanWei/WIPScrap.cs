using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    [SugarTable("WIP_Scrap")]
    public class WIPScrap
    {
        public WIPScrap()
        {
        }

        private System.Int64 _Id;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int64 Id { get { return this._Id; } set { this._Id = value; } }

        private System.String _SN;
        /// <summary>
        /// 
        /// </summary>
        public System.String SN { get { return this._SN; } set { this._SN = value; } }

        private System.String _OrderId;
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderId { get { return this._OrderId; } set { this._OrderId = value; } }

        private System.String _ItemCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemCode { get { return this._ItemCode; } set { this._ItemCode = value; } }

        private System.String _MatModel;
        /// <summary>
        /// 
        /// </summary>
        public System.String MatModel { get { return this._MatModel; } set { this._MatModel = value; } }

        private System.String _CustomerCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String CustomerCode { get { return this._CustomerCode; } set { this._CustomerCode = value; } }

        private System.String _LineCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String LineCode { get { return this._LineCode; } set { this._LineCode = value; } }

        private System.String _OperCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String OperCode { get { return this._OperCode; } set { this._OperCode = value; } }

        private System.String _ResCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String ResCode { get { return this._ResCode; } set { this._ResCode = value; } }

        /// <summary>
        /// 报废代码
        /// </summary>
        public string ScrapCode { get; set; }

        /// <summary>
        /// 报废描述
        /// </summary>
        public string ScrapDesc { get; set; }

        /// <summary>
        /// 报废人员
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 报废时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 是否报废(Y报废/N取消报废)
        /// </summary>
        public string IsScrap { get; set; }

    }
}
