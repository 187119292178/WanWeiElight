using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.CodeRules
{
    /// <summary>
    /// 编码规则辅助类
    /// </summary>
    public class RuleHelper
    {
        /// <summary>
        /// 根据料号返回9位机型代码
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string GetMatModel(string itemCode, ref string msg)
        {
            string code = "";
            string itemNum = itemCode.Trim();
            if (itemNum.Length < 13)
            {
                msg = $"物料编码[{itemNum}]不满足要求，位数必须大于等于13位";
                return code ;
            }

            //1.料号前3位转36进制，不足2位，左边补0
            string sn1 = "";
            sn1 = itemNum.Substring(0, 3);
            sn1 = StringHelper.TransformBase(sn1, 10, 36).PadLeft(2, '0');

            //2.取料号第4位，如果为横杠(-)，则为空字符串
            string sn2 = "";
            sn2 = itemNum.Substring(3, 1);
            if (sn2 == "-")
            {
                sn2 = " ";
            }

            //3.料号第5位到13位共9位转36进制，不足6位，左边补0
            string sn3 = "";
            sn3 = itemNum.Substring(4, 9);
            sn3 = StringHelper.TransformBase(sn3, 10, 36).PadLeft(6, '0');

            code = sn1 + sn2 + sn3;
            return code;
        }

    }
}
