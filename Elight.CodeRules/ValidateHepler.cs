using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Elight.CodeRules
{
    public class ValidateHepler
    {
        /// <summary>
        /// 判断对象是否为Int32类型的数字
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool IsNumeric(object Expression)
        {
            if (Expression != null)
            {
                string str = Expression.ToString();
                if (str.Length > 0 && str.Length <= 11 && Regex.IsMatch(str, @"^[-]?[0-9]*[.]?[0-9]*$"))
                {
                    if ((str.Length < 10) || (str.Length == 10 && str[0] == '1') || (str.Length == 11 && str[0] == '-' && str[1] == '1'))
                    {
                        return true;
                    }
                }
            }
            return false;

        }


        public static bool IsDouble(object Expression)
        {
            if (Expression != null)
            {
                return Regex.IsMatch(Expression.ToString(), @"^([0-9])[0-9]*(\.\w*)?$");
            }
            return false;
        }

        /// <summary>
        /// 验证是否为正整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInt(string str)
        {

            return Regex.IsMatch(str, @"^[0-9]*$");
        }

        public static bool IsTime(string timeval)
        {
            return Regex.IsMatch(timeval, @"^((([0-1]?[0-9])|(2[0-3])):([0-5]?[0-9])(:[0-5]?[0-9])?)$");
        }

        /// <summary>
        /// 检查是否为空（null 或是""）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNull(object obj)
        {
            if (obj == null)
            {
                return true;
            }

            string typeName = obj.GetType().Name;
            switch (typeName)
            {
                case "String[]":
                    string[] list = (string[])obj;
                    if (list.Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    string str = obj.ToString();
                    if (str == null || str == "")
                        return true;
                    else
                        return false;
            }
        }
        /// <summary>
        /// 检查是否为空（null 或是""）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNotNull(object obj)
        {
            return (!IsNull(obj));
        }


        /// <summary>
        /// 判断传入的数字是否为0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNullZero(object obj)
        {
            return !IsNotNullZero(obj);
        }
        /// <summary>
        /// 判断传入的数字是否不为0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNotNullZero(object obj)
        {
            if (IsNull(obj))
            {
                return false;
            }
            else
            {
                try
                {
                    double d = Convert.ToDouble(obj);
                    if (d == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 判断是否为日期型变量
        /// </summary>
        /// <param name="str">日期变量</param>
        /// <returns>是否为日期</returns>
        public static bool IsDateTime(string str)
        {
            try
            {
                Convert.ToDateTime(str);

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判断是否为日期型变量
        /// </summary>
        /// <param name="obj">日期变量</param>
        /// <returns>是否为日期</returns>
        public static bool IsDateTime(object obj)
        {
            try
            {
                Convert.ToDateTime(obj.ToString());

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 判断是否为base64字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsBase64String(string str)
        {
            //A-Z, a-z, 0-9, +, /, =
            return Regex.IsMatch(str, @"[A-Za-z0-9\+\/\=]");
        }

        #region  验证输入字符串为数字
        /// <summary>
        /// 验证输入字符串为数字
        /// </summary>
        /// <param name="strln">输入字符</param>
        /// <returns>返回一个bool类型的值</returns>
        public static bool IsNumber(string strln)
        {
            return Regex.IsMatch(strln, @"^\d*[.]?\d*$");
        }
        #endregion

        #region 验证手机号
        /// <summary>
        /// 验证输入字符串为18位的手机号码
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsMobile(string strln)
        {
            return Regex.IsMatch(strln, @"^1[0123456789]\d{9}$", RegexOptions.IgnoreCase);
        }

        #endregion


        /// <summary>
        /// 验证身份证是否有效
        /// </summary>
        /// <param name="strln"></param>
        /// <returns></returns>
        public static bool IsIDCard(string strln)
        {
            if (strln.Length == 18)
            {
                bool check = IsIDCard18(strln);
                return check;
            }
            else if (strln.Length == 15)
            {
                bool check = IsIDCard15(strln);
                return check;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 验证输入字符串为18位的身份证号码
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsIDCard18(string strln)
        {
            long n = 0;
            if (long.TryParse(strln.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(strln.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(strln.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = strln.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = strln.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != strln.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }
        /// <summary>
        /// 验证输入字符串为15位的身份证号码
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsIDCard15(string strln)
        {
            long n = 0;
            if (long.TryParse(strln, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(strln.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = strln.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            return true;//符合15位身份证标准
        }


        /// <summary>
        /// 验证输入字符串为电话号码
        /// </summary>
        /// <param name="P_str_phone">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public static bool IsPhone(string strln)
        {
            return Regex.IsMatch(strln, @"(^(\d{2,4}[-_－—]?)?\d{3,8}([-_－—]?\d{3,8})?([-_－—]?\d{1,7})?$)|(^0?1[35]\d{9}$)");
            //弱一点的验证：  @"\d{3,4}-\d{7,8}"         
        }


        /// <summary>
        /// 验证是否是有效邮箱地址
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsEmail(string strln)
        {
            return Regex.IsMatch(strln, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// 验证是否是有效传真号码
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsFax(string strln)
        {
            return Regex.IsMatch(strln, @"^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$");
        }
        /// <summary>
        /// 验证是否只含有汉字
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsOnllyChinese(string strln)
        {
            return Regex.IsMatch(strln, @"^[\u4e00-\u9fa5]+$");
        }


    }
}
