using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Entity.DTO.Parms
{
    /// <summary>
    /// 物料信息查询参数
    /// </summary>
    public class BasItemParams
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public string itemCode { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string itemDesc{ get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        public string MatType { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        public string MatModel { get; set; }

        /// <summary>
        /// 包装数量
        /// </summary>
        public string PackQty { get; set; }
    }
}
