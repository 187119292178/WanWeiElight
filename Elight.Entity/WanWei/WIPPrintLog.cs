using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    /// <summary>
    /// 打印日志类
    /// </summary>
    [SugarTable("WIP_PrintLog")]
    public class WIPPrintLog
    {
        /// <summary>
        /// 
        /// </summary>
        public WIPPrintLog()
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

        private System.String _ItemCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemCode { get { return this._ItemCode; } set { this._ItemCode = value; } }

        private System.String _OrderId;
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderId { get { return this._OrderId; } set { this._OrderId = value; } }

        private System.String _OperCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String OperCode { get { return this._OperCode; } set { this._OperCode = value; } }

        private System.String _LabelType;
        /// <summary>
        /// 
        /// </summary>
        public System.String LabelType { get { return this._LabelType; } set { this._LabelType = value; } }

        private System.String _LabelName;
        /// <summary>
        /// 
        /// </summary>
        public System.String LabelName { get { return this._LabelName; } set { this._LabelName = value; } }

        private System.String _LabelPath;
        /// <summary>
        /// 
        /// </summary>
        public System.String LabelPath { get { return this._LabelPath; } set { this._LabelPath = value; } }

        private System.Int32? _PrintType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PrintType { get { return this._PrintType; } set { this._PrintType = value; } }

        private System.Int32? _PrintNum;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PrintNum { get { return this._PrintNum; } set { this._PrintNum = value; } }

        private System.String _PrintParam;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrintParam { get { return this._PrintParam; } set { this._PrintParam = value; } }

        private System.DateTime? _PrintTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? PrintTime { get { return this._PrintTime; } set { this._PrintTime = value; } }

        private System.String _PrinterId;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrinterId { get { return this._PrinterId; } set { this._PrinterId = value; } }


        [SugarColumn(IsIgnore = true)]
        public string ItemName { get; set; }
    }
}
