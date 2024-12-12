using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    /// <summary>
    /// 镭雕机接口实体类
    /// </summary>
    [SugarTable("WIP_LaserLog")]
    public class WIPLaserLog
    {
        /// <summary>
        /// 
        /// </summary>
        public WIPLaserLog()
        {
        }

        private System.Int64 _Id;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int64 Id { get { return this._Id; } set { this._Id = value; } }

        private System.String _OrderId;
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderId { get { return this._OrderId; } set { this._OrderId = value; } }

        private System.String _MachineNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String MachineNo { get { return this._MachineNo; } set { this._MachineNo = value; } }

        private System.String _CompanyNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String CompanyNo { get { return this._CompanyNo; } set { this._CompanyNo = value; } }

        private System.Int32? _Qty;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Qty { get { return this._Qty; } set { this._Qty = value; } }

        private System.String _StartSN;
        /// <summary>
        /// 
        /// </summary>
        public System.String StartSN { get { return this._StartSN; } set { this._StartSN = value; } }

        private System.String _EndSN;
        /// <summary>
        /// 
        /// </summary>
        public System.String EndSN { get { return this._EndSN; } set { this._EndSN = value; } }

        private System.String _InParam;
        /// <summary>
        /// 
        /// </summary>
        public System.String InParam { get { return this._InParam; } set { this._InParam = value; } }

        private System.String _ReturnData;
        /// <summary>
        /// 
        /// </summary>
        public System.String ReturnData { get { return this._ReturnData; } set { this._ReturnData = value; } }

        private System.DateTime? _ActionTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? ActionTime { get { return this._ActionTime; } set { this._ActionTime = value; } }

        private System.Int32? _ResultStatus;
        /// <summary>
        /// 返回结果(0成功/1失败)
        /// </summary>
        public System.Int32? ResultStatus { get { return this._ResultStatus; } set { this._ResultStatus = value; } }

        /// <summary>
        /// 接口返回结果
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string ResultName { get; set; }
    }
}
