using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    [SugarTable("WIP_SNTracking")]
    public class WIPSNTracking
    {
        public WIPSNTracking() 
        { }

        private System.String _SN;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
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

        private System.String _ModuleSN;
        /// <summary>
        /// 
        /// </summary>
        public System.String ModuleSN { get { return this._ModuleSN; } set { this._ModuleSN = value; } }

        private System.DateTime? _InLineTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? InLineTime { get { return this._InLineTime; } set { this._InLineTime = value; } }

        private System.DateTime? _OpeartionTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? OpeartionTime { get { return this._OpeartionTime; } set { this._OpeartionTime = value; } }

        private System.String _OperationId;
        /// <summary>
        /// 
        /// </summary>
        public System.String OperationId { get { return this._OperationId; } set { this._OperationId = value; } }

        private System.String _CartonNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String CartonNo { get { return this._CartonNo; } set { this._CartonNo = value; } }

        private System.String _PalletNO;
        /// <summary>
        /// 
        /// </summary>
        public System.String PalletNO { get { return this._PalletNO; } set { this._PalletNO = value; } }

        private System.String _SNStatus;
        /// <summary>
        /// 
        /// </summary>
        public System.String SNStatus { get { return this._SNStatus; } set { this._SNStatus = value; } }

        private System.Decimal? _ShiftDay;
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal? ShiftDay { get { return this._ShiftDay; } set { this._ShiftDay = value; } }

        private System.String _IsFinished;
        /// <summary>
        /// 
        /// </summary>
        public System.String IsFinished { get { return this._IsFinished; } set { this._IsFinished = value; } }

        private System.DateTime? _FinishTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? FinishTime { get { return this._FinishTime; } set { this._FinishTime = value; } }
                


    }
}
