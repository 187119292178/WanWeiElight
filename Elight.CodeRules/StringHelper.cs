using System.Drawing;
using System.Text.RegularExpressions;

namespace Elight.CodeRules
{
    public class StringHelper
    {
        /// <summary>
        /// 将字符串转换为Color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color ToColor(string color)
        {
            int red, green, blue = 0;
            char[] rgb;
            color = color.TrimStart('#');
            color = Regex.Replace(color.ToLower(), "[g-zG-Z]", "");
            switch (color.Length)
            {
                case 3:
                    rgb = color.ToCharArray();
                    red = Convert.ToInt32(rgb[0].ToString() + rgb[0].ToString(), 16);
                    green = Convert.ToInt32(rgb[1].ToString() + rgb[1].ToString(), 16);
                    blue = Convert.ToInt32(rgb[2].ToString() + rgb[2].ToString(), 16);
                    return Color.FromArgb(red, green, blue);
                case 6:
                    rgb = color.ToCharArray();
                    red = Convert.ToInt32(rgb[0].ToString() + rgb[1].ToString(), 16);
                    green = Convert.ToInt32(rgb[2].ToString() + rgb[3].ToString(), 16);
                    blue = Convert.ToInt32(rgb[4].ToString() + rgb[5].ToString(), 16);
                    return Color.FromArgb(red, green, blue);
                default:
                    return Color.FromName(color);

            }
        }

        /// <summary>
        /// 格式化字节数字符串（用于显示文件大小）
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string FormatBytesStr(int bytes)
        {
            if (bytes > 1073741824)
            {
                return ((double)(bytes / 1073741824)).ToString("0") + "G";
            }
            if (bytes > 1048576)
            {
                return ((double)(bytes / 1048576)).ToString("0") + "M";
            }
            if (bytes > 1024)
            {
                return ((double)(bytes / 1024)).ToString("0") + "K";
            }
            return bytes.ToString() + "Bytes";
        }

        /// <summary>
        /// 转换进制
        /// </summary>
        /// <param name="InputNumber">要转换的字符串</param>
        /// <param name="InputBase">转换前的进制</param>
        /// <param name="OutputBase">转换后的进制</param>
        /// <returns></returns>
        public static string TransformBase(string InputNumber, int InputBase, int OutputBase)
        {
            string result = string.Empty;
            UInt64 DecimalValue, X, MaxBase, InputNumberLength;
            string NumericBaseData, OutputValue;
            NumericBaseData = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
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
                return "0";
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
    }
}
