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
    [SugarTable("Bas_Template")]
    public class BasTemplate
    {
        /// <summary>
        /// 打印模板配置实体
        /// </summary>
        public BasTemplate()
        {
        }

        private System.Int32 _Id;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 Id { get { return this._Id; } set { this._Id = value; } }

        private System.String _ItemCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String ItemCode { get { return this._ItemCode; } set { this._ItemCode = value; } }

        private System.String _TemplateType;
        /// <summary>
        /// 
        /// </summary>
        public System.String TemplateType { get { return this._TemplateType; } set { this._TemplateType = value; } }

        private System.String _HostURL;
        /// <summary>
        /// 
        /// </summary>
        public System.String HostURL { get { return this._HostURL; } set { this._HostURL = value; } }

        private System.String _TemplateURL;
        /// <summary>
        /// 
        /// </summary>
        public System.String TemplateURL { get { return this._TemplateURL; } set { this._TemplateURL = value; } }

        private System.String _TemplateName;
        /// <summary>
        /// 
        /// </summary>
        public System.String TemplateName { get { return this._TemplateName; } set { this._TemplateName = value; } }

        private System.Int32? _PrintCount;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PrintCount { get { return this._PrintCount; } set { this._PrintCount = value; } }

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

        private System.String _ItemType;
        /// <summary>
        /// 模板管控维度(COMMOM通用/ITEM料号/ORDER工单/MODEL机型)
        /// </summary>
        public System.String ItemType { get { return this._ItemType; } set { this._ItemType = value; } }

        private System.String _RemoteName;
        public System.String RemoteName { get { return this._RemoteName; } set { this._RemoteName = value; } }
    }
}
