using Elight.Logic.Base;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Common
{
    /// <summary>
    /// 部分通用方法
    /// </summary>
    public class CommonHelper
    {
        private BasRuleSerialLogic ruleLogic;

        /// <summary>
        /// 转换进制
        /// </summary>
        /// <param name="InputNumber">要转换的字符串</param>
        /// <param name="InputBase">转换前的进制</param>
        /// <param name="OutputBase">转换后的进制</param>
        /// <returns></returns>
        public static string TransformBase(string InputNumber, int InputBase, int OutputBase ,string type)
        {
            string result = string.Empty;
            UInt64 DecimalValue, X, MaxBase, InputNumberLength;
            string NumericBaseData, OutputValue;
            NumericBaseData = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (type.Equals("M")) {
                NumericBaseData = "01234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            MaxBase = (UInt64)NumericBaseData.Length;
            if ((UInt64)InputBase > (UInt64)MaxBase || (UInt64)OutputBase > (UInt64)MaxBase)
            {
                result = "N/A";
            }
            InputNumberLength = (UInt64)InputNumber.Length;
            DecimalValue = 0;
            for (int j = 1; j <= (Int64)InputNumberLength; j++)
            {
                for (int k = 1; k <= InputBase; k++)
                {
                    string s1 = InputNumber.Substring(j - 1, 1);
                    string s2 = NumericBaseData.Substring(k - 1, 1);
                    if (s1 == s2)
                    {
                        DecimalValue = DecimalValue + (UInt64)Math.Abs((k - 1) * (Math.Pow(InputBase, ((Int64)InputNumberLength - j))) + 0.5);  //
                    }
                }
            }
            OutputValue = "";
            if (DecimalValue == 0)
            {
                if (type.Equals("Y"))
                {
                    return "0";
                }
                else {
                    return "1";
                }
            }
            while (DecimalValue > 0)
            {
                X = (UInt64)((((double)DecimalValue / (double)OutputBase) - Math.Floor((double)DecimalValue / (double)OutputBase)) * OutputBase + 1.5);
                OutputValue = NumericBaseData.Substring((int)(X) - 1, 1) + OutputValue;
                DecimalValue = (UInt64)((double)DecimalValue / (double)OutputBase);
            }
            result = OutputValue;
            return result;
        }
        public static string TransformBase1(string InputNumber, int InputBase, int OutputBase ,string type)
        {
            string NumericBaseData;
            UInt64 DecimalValue = 0;
            string OutputValue = "";

            // 选择字符集
            if (type.Equals("Y"))
            {
                NumericBaseData = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (type.Equals("M"))
            {
                NumericBaseData = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (type.Equals("D"))
            {
                NumericBaseData = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else
            {
                return "Invalid Type";
            }

            int MaxBase = NumericBaseData.Length;

            // 检查输入和输出进制是否合法
            if (InputBase > MaxBase || OutputBase > MaxBase)
            {
                return "N/A";
            }

            // 将输入数字转换为十进制
            foreach (char c in InputNumber)
            {
                int value = NumericBaseData.IndexOf(c);
                if (value == -1 || value >= InputBase)
                {
                    return "Invalid Input Number";
                }
                DecimalValue = DecimalValue * (UInt64)InputBase + (UInt64)value;
            }

            // 如果十进制值为 0，返回 "0"
            if (DecimalValue == 0)
            {
                return "0";
            }

            // 将十进制值转换为目标进制
            while (DecimalValue > 0)
            {
                UInt64 remainder = DecimalValue % (UInt64)OutputBase;
                OutputValue = NumericBaseData[(int)remainder] + OutputValue;
                DecimalValue /= (UInt64)OutputBase;
            }

            return OutputValue;
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

        public static void InitDataGridView(UIDataGridView dgvName, DataGridViewAutoSizeColumnsMode SizeColumnsMode)
        {
            dgvName.AutoGenerateColumns = false;
            dgvName.ColumnHeadersVisible = true;
            dgvName.AllowUserToAddRows = false;
            dgvName.AllowUserToDeleteRows = false;

            dgvName.ReadOnly = true;
            dgvName.RowHeadersVisible = false;
            dgvName.AutoSizeColumnsMode = SizeColumnsMode;
        }

        /// <summary>
        /// 生成当前时间的唯一时间戳字符串
        /// </summary>
        /// <returns></returns>
        public static string Generate()
        {
            DateTime now = DateTime.Now;
            Random random = new Random();
            return now.ToString("yyyyMMddHHmmssffff") + random.Next(0, 101);
        }

        /// <summary>
        /// 生成新的箱号
        /// </summary>
        /// <param name="ruleName"></param>
        /// <returns></returns>
        public static string GetNewCartonNO(string ruleName)
        {
            string cartonNo = "";

            //获取服务器的当前日期：yyyyMMdd


            return cartonNo;
        }

    }
}
