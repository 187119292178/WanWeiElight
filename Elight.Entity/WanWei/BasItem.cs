using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Elight.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("Bas_Item")]
    public class BasItem
    {
        /// <summary>
        /// 
        /// </summary>
        public BasItem()
        {
        }

        private System.String _ItemCode;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public System.String ItemCode { get { return this._ItemCode; } set { this._ItemCode = value; } }

        private System.String _ItemName;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemName { get { return this._ItemName; } set { this._ItemName = value; } }

        private System.String _ItemDesc;
        /// <summary>
        /// 规格型号
        /// </summary>
        public System.String ItemDesc { get { return this._ItemDesc; } set { this._ItemDesc = value; } }

        private System.String _MatType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public System.String MatType { get { return this._MatType; } set { this._MatType = value; } }

        private System.String _MatModel;
        /// <summary>
        /// 机型
        /// </summary>
        public System.String MatModel { get { return this._MatModel; } set { this._MatModel = value; } }

        private System.Int32? _PackQty;
        /// <summary>
        /// 最小包装单位
        /// </summary>
        public System.Int32? PackQty { get { return this._PackQty; } set { this._PackQty = value; } }

        private System.Int32? _PalletQty;
        /// <summary>
        /// 堆栈标准数量
        /// </summary>
        public System.Int32? PalletQty { get { return this._PalletQty; } set { this._PalletQty = value; } }

        private System.String _ItemVer;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemVer { get { return this._ItemVer; } set { this._ItemVer = value; } }

        private System.String _ItemWeight;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemWeight { get { return this._ItemWeight; } set { this._ItemWeight = value; } }

        private System.String _ItemVolume;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemVolume { get { return this._ItemVolume; } set { this._ItemVolume = value; } }

        private System.String _ColorEn;
        /// <summary>
        /// 
        /// </summary>
        public System.String ColorEn { get { return this._ColorEn; } set { this._ColorEn = value; } }

        private System.String _ColorCn;
        /// <summary>
        /// 
        /// </summary>
        public System.String ColorCn { get { return this._ColorCn; } set { this._ColorCn = value; } }

        private System.String _BrandName;
        /// <summary>
        /// 
        /// </summary>
        public System.String BrandName { get { return this._BrandName; } set { this._BrandName = value; } }

        private System.String _UnitCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String UnitCode { get { return this._UnitCode; } set { this._UnitCode = value; } }

        private System.String _OutputDesc;
        /// <summary>
        /// 
        /// </summary>
        public System.String OutputDesc { get { return this._OutputDesc; } set { this._OutputDesc = value; } }

        private System.String _SourceDesc;
        /// <summary>
        /// 
        /// </summary>
        public System.String SourceDesc { get { return this._SourceDesc; } set { this._SourceDesc = value; } }

        private System.String _Remark;
        /// <summary>
        /// 
        /// </summary>
        public System.String Remark { get { return this._Remark; } set { this._Remark = value; } }

        private System.String _IsEnabled;
        /// <summary>
        /// 是否启用(Y启用/N不启用)
        /// </summary>
        public System.String IsEnabled { get { return this._IsEnabled; } set { this._IsEnabled = value; } }

        private System.String _DeleteMark;
        /// <summary>
        /// 删除标记(Y已删除/N不删除)
        /// </summary>
        public System.String DeleteMark { get { return this._DeleteMark; } set { this._DeleteMark = value; } }

        private System.String _CreateUser;
        /// <summary>
        /// 创建人
        /// </summary>
        public System.String CreateUser { get { return this._CreateUser; } set { this._CreateUser = value; } }

        private System.DateTime? _CreateTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CreateTime { get { return this._CreateTime; } set { this._CreateTime = value; } }

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
    }
}