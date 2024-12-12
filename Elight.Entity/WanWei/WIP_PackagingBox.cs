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
    ///     
    [SugarTable("WIP_PackagingBox")]
    public class WIP_PackagingBox
    {
        /// <summary>
        /// 
        /// </summary>
        public WIP_PackagingBox()
        {
        }


        private System.String _BoxNumber;
        /// <summary>
        /// 箱号，用于唯一标识包装箱
        /// </summary>
        ///         
        [SugarColumn(IsPrimaryKey = true)]
        public System.String BoxNumber
        {
            get { return this._BoxNumber; }
            set { this._BoxNumber = value; }
        }

        private System.String _Status;
        /// <summary>
        /// 包装箱的当前状态，例如“空闲”、“已使用”、“在途”等
        /// </summary>
        public System.String Status
        {
            get { return this._Status; }
            set { this._Status = value; }
        }

        private System.String _Type;
        /// <summary>
        /// 包装箱的类型，如“纸箱”、“塑料箱”等
        /// </summary>
        public System.String Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }

        private System.String _ParentBoxNumber;
        /// <summary>
        /// 父包装箱的编号，用于记录包装箱之间的层级关系
        /// </summary>
        public System.String ParentBoxNumber
        {
            get { return this._ParentBoxNumber; }
            set { this._ParentBoxNumber = value; }
        }

        private System.Int32 _Quantity;
        /// <summary>
        /// 包装箱中当前包含的物品数量
        /// </summary>
        public System.Int32 Quantity
        {
            get { return this._Quantity; }
            set { this._Quantity = value; }
        }

        private System.Int32 _TotalQuantity;
        /// <summary>
        /// 包装箱的最大容量或计划装载的数量
        /// </summary>
        public System.Int32 TotalQuantity
        {
            get { return this._TotalQuantity; }
            set { this._TotalQuantity = value; }
        }

        private System.String _CreateUser;
        /// <summary>
        /// 记录创建此包装箱信息的用户或系统
        /// </summary>
        public System.String CreateUser
        {
            get { return this._CreateUser; }
            set { this._CreateUser = value; }
        }

        private System.DateTime _CreatedTime;
        /// <summary>
        /// 记录包装箱信息的创建时间
        /// </summary>
        public System.DateTime CreatedTime
        {
            get { return this._CreatedTime; }
            set { this._CreatedTime = value; }
        }
        
        private System.String _ModifyUser;
        /// <summary>
        /// 记录创建此包装箱信息的用户或系统
        /// </summary>
        public System.String ModifyUser
        {
            get { return this._ModifyUser; }
            set { this._ModifyUser = value; }
        }

        private System.DateTime _ModifyTime;
        /// <summary>
        /// 记录包装箱信息的创建时间
        /// </summary>
        public System.DateTime ModifyTime
        {
            get { return this._ModifyTime; }
            set { this._ModifyTime = value; }
        }

        private System.String _ProductNumber;
        /// <summary>
        /// 包装箱中装载的产品编号
        /// </summary>
        public System.String ProductNumber
        {
            get { return this._ProductNumber; }
            set { this._ProductNumber = value; }
        }

        private System.String _WorkOrder;
        /// <summary>
        /// 包装箱关联的工单号
        /// </summary>
        public System.String WorkOrder
        {
            get { return this._WorkOrder; }
            set { this._WorkOrder = value; }
        }

        private System.String _Remarks;
        /// <summary>
        /// 可选的备注信息，记录包装箱的附加说明或其他注释
        /// </summary>
        public System.String Remarks
        {
            get { return this._Remarks; }
            set { this._Remarks = value; }
        }
        
        private System.String _IsEnabled;
        /// <summary>
        /// 是否启动Y/N
        /// </summary>
        public System.String IsEnabled
        {
            get { return this._IsEnabled; }
            set { this._IsEnabled = value; }
        }

    }
}
