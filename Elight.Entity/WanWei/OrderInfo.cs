using Org.BouncyCastle.Crypto;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.WanWei
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// 工单实体类
        /// </summary>
        public OrderInfo()
        {
        }

        private System.String _OrderId;
        /// <summary>
        /// 工单号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public System.String OrderId { get { return this._OrderId; } set { this._OrderId = value; } }

        private System.String _OrderType;
        /// <summary>
        /// 工单类型(Normal正常/Rework)
        /// </summary>
        public System.String OrderType { get { return this._OrderType; } set { this._OrderType = value; } }

        private System.String _ItemCode;
        /// <summary>
        /// 产品料号
        /// </summary>
        public System.String ItemCode { get { return this._ItemCode; } set { this._ItemCode = value; } }

        private System.String _MatModel;
        /// <summary>
        /// 机型
        /// </summary>
        public System.String MatModel { get { return this._MatModel; } set { this._MatModel = value; } }

        private System.String _OrderStatus;
        /// <summary>
        /// 工单状态(INIT初始化/Released已下发/Producting生产中/Finished已完工)
        /// </summary>
        public System.String OrderStatus { get { return this._OrderStatus; } set { this._OrderStatus = value; } }

        private System.Int32? _TargetQty;
        /// <summary>
        /// 工单计划数量
        /// </summary>
        public System.Int32? TargetQty { get { return this._TargetQty; } set { this._TargetQty = value; } }

        private System.Int32? _BoxQty;
        /// <summary>
        /// 工单彩盒数量
        /// </summary>
        public System.Int32? BoxQty { get { return this._BoxQty; } set { this._BoxQty = value; } }

        private System.DateTime? _PlanStartDate;
        /// <summary>
        /// 计划开工时间
        /// </summary>
        public System.DateTime? PlanStartDate { get { return this._PlanStartDate; } set { this._PlanStartDate = value; } }

        private System.DateTime? _PlanEndDate;
        /// <summary>
        /// 计划结束时间
        /// </summary>
        public System.DateTime? PlanEndDate { get { return this._PlanEndDate; } set { this._PlanEndDate = value; } }

        private System.DateTime? _ActStartDate;
        /// <summary>
        /// 实际开工时间
        /// </summary>
        public System.DateTime? ActStartDate { get { return this._ActStartDate; } set { this._ActStartDate = value; } }

        private System.DateTime? _ActEndDate;
        /// <summary>
        /// 实际完工时间
        /// </summary>
        public System.DateTime? ActEndDate { get { return this._ActEndDate; } set { this._ActEndDate = value; } }

        private System.Int32? _CreatedQty;
        /// <summary>
        /// 生码数量
        /// </summary>
        public System.Int32? CreatedQty { get { return this._CreatedQty; } set { this._CreatedQty = value; } }

        private System.Int32? _InputQty;
        /// <summary>
        /// 已投入数量
        /// </summary>
        public System.Int32? InputQty { get { return this._InputQty; } set { this._InputQty = value; } }

        private System.Int32? _OutPutQty;
        /// <summary>
        /// 已产出数量
        /// </summary>
        public System.Int32? OutPutQty { get { return this._OutPutQty; } set { this._OutPutQty = value; } }

        private System.Int32? _PackQty;
        /// <summary>
        /// 已包装数量
        /// </summary>
        public System.Int32? PackQty { get { return this._PackQty; } set { this._PackQty = value; } }

        private System.Int32? _ScrapQty;
        /// <summary>
        /// 报废数量
        /// </summary>
        public System.Int32? ScrapQty { get { return this._ScrapQty; } set { this._ScrapQty = value; } }

        private System.String _CustomerCode;
        /// <summary>
        /// 客户代码
        /// </summary>
        public System.String CustomerCode { get { return this._CustomerCode; } set { this._CustomerCode = value; } }

        private System.DateTime? _CreateTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CreateTime { get { return this._CreateTime; } set { this._CreateTime = value; } }

        private System.String _CreateUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreateUser { get { return this._CreateUser; } set { this._CreateUser = value; } }

        private System.String _MatType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public System.String MatType { get { return this._MatType; } set { this._MatType = value; } }

        private System.Int32? _PrintedQty;
        /// <summary>
        /// 已打印数量
        /// </summary>
        public System.Int32? PrintedQty { get { return this._PrintedQty; } set { this._PrintedQty = value; } }

        private System.String _LineCode;
        /// <summary>
        /// 数量
        /// </summary>
        public System.String LineCode { get { return this._LineCode; } set { this._LineCode = value; } }

        private System.String _BOMNo;
        /// <summary>
        /// bom编号
        /// </summary>
        public System.String BOMNo { get { return this._BOMNo; } set { this._BOMNo = value; } }

        private System.String _RouteCode;
        /// <summary>
        /// 工艺代码
        /// </summary>
        public System.String RouteCode { get { return this._RouteCode; } set { this._RouteCode = value; } }

        private System.DateTime? _FinshedTime;
        /// <summary>
        /// 完工时间
        /// </summary>
        public System.DateTime? FinshedTime { get { return this._FinshedTime; } set { this._FinshedTime = value; } }

        private System.String _Remark;
        /// <summary>
        /// 备注
        /// </summary>
        public System.String Remark { get { return this._Remark; } set { this._Remark = value; } }

        private System.String _IsEnabled;
        /// <summary>
        /// 是否启用(Y启用/N不启用)
        /// </summary>
        public System.String IsEnabled { get { return this._IsEnabled; } set { this._IsEnabled = value; } }

        private System.String _DeleteMark;
        /// <summary>
        /// 删除标记(Y删除/N不删除)
        /// </summary>
        public System.String DeleteMark { get { return this._DeleteMark; } set { this._DeleteMark = value; } }

        private System.String _ModifyUser;
        /// <summary>
        /// 修改人
        /// </summary>
        public System.String ModifyUser { get { return this._ModifyUser; } set { this._ModifyUser = value; } }

        private System.DateTime? _ModifyTime;
        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? ModifyTime { get { return this._ModifyTime; } set { this._ModifyTime = value; } }

        private System.DateTime? _ReleaseDate;
        /// <summary>
        /// 下达日期
        /// </summary>
        public System.DateTime? ReleaseDate { get { return this._ReleaseDate; } set { this._ReleaseDate = value; } }

        private string _ProductType;
        /// <summary>
        /// 生产类型(新机/翻新机)
        /// </summary>
        public string ProductType { get { return this._ProductType; } set { this._ProductType = value; } }

        private string _SNRule;
        /// <summary>
        /// 工单条码生码规则
        /// </summary>
        public string SNRule { get { return this._SNRule; } set { this._SNRule = value; } }

        /// <summary>
        /// 物料名称
        /// </summary>
        [SugarColumn(IsIgnore=true)]
        public string BasItemName { get; set; }

        /// <summary>
        /// 型号规格
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string BasItemDesc { get; set; }

    }
}
