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
    public class WIP_SNRes
    {
        /// <summary>
        /// 
        /// </summary>
        public WIP_SNRes()
        {
        }

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

        private System.String _SNStatus;
        /// <summary>
        /// 
        /// </summary>
        public System.String SNStatus { get { return this._SNStatus; } set { this._SNStatus = value; } }

        private System.String _PrintStatus;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrintStatus { get { return this._PrintStatus; } set { this._PrintStatus = value; } }

        private System.String _SNType;
        /// <summary>
        /// 
        /// </summary>
        public System.String SNType { get { return this._SNType; } set { this._SNType = value; } }

        private System.Int32? _PrintNum;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PrintNum { get { return this._PrintNum; } set { this._PrintNum = value; } }

        private System.String _IsEnabled;
        /// <summary>
        /// 是否启用(Y启用/N不启用)
        /// </summary>
        public System.String IsEnabled { get { return this._IsEnabled; } set { this._IsEnabled = value; } }

        private System.String _DeleteMark;
        /// <summary>
        /// 删除标记
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
        /// <summary>
        /// 物料名称
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string ItemName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string MatType { get; set; }

        /// <summary>
        /// 包装数量
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public int PackQty { get; set; }
        
        /// <summary>
        /// 外包
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string ParentBoxNumber { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string MatModel { get; set; }

        private System.String _BoxNumber;
        /// <summary>
        /// 
        /// </summary>
        public System.String BoxNumber { get { return this._BoxNumber; } set { this._BoxNumber = value; } }
        
        private System.String _BoxCreateUser;        
        /// <summary>
        /// 机型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string BoxCreateUser { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string BoxCreatedTime { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string BoxParentBoxNumber { get; set; }

        /// <summary>
        /// 系统版本号
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string SW { get; set; }
        
        /// <summary>
        /// 物料型号
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string PN { get; set; }


        /// <summary>
        /// 物料型号
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string BoxStatus { get; set; }
    }
}
