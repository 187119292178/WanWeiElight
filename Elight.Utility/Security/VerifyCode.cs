using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Elight.Utility.Security
{
    /// <summary>
    /// 验证码生成类。 
    /// </summary>
    public class VerifyCode
    {
        private string _text;
        private byte[] _image;

        #region 公有属性
        /// <summary>
        /// 验证码
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        /// <summary>
        /// 验证码图片(字节数组)
        /// </summary>
        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        public VerifyCode()
        {
            GetVerifyCode();
        }
        private void GetVerifyCode()
        {
            int codeW = 80; //画布宽
            int codeH = 30; //画布高
            int fontSize = 16;
            string chkCode = string.Empty;
            //颜色列表，用于验证码、噪线、噪点 
            SKColor[] color = { SKColors.Black, SKColors.Red, SKColors.Blue, SKColors.Green, SKColors.Orange, SKColors.Brown, SKColors.DarkBlue };
            //验证码的字符集，去掉了一些容易混淆的字符 
            char[] character = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'd', 'e', 'f', 'h', 'k', 'm', 'n', 'r', 'x', 'y', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };
            Random rnd = new Random();
            //生成验证码字符串 
            for (int i = 0; i < 4; i++)
            {
                chkCode += character[rnd.Next(character.Length)];
            }
            this._text = chkCode;
            //创建画布 
            var info = new SKImageInfo(codeW, codeH);
            using (var surface = SKSurface.Create(info))
            {
                var canvas = surface.Canvas;
                canvas.Clear(SKColors.White);
                //画干扰线 
                for (int i = 0; i < 3; i++)
                {
                    float x1 = 1.0f * rnd.Next(codeW);
                    float y1 = 1.0f * rnd.Next(codeH);
                    float x2 = 1.0f * rnd.Next(codeW);
                    float y2 = 1.0f * rnd.Next(codeH);
                    SKColor clr = color[rnd.Next(color.Length)];
                    canvas.DrawLine(x1, y1, x2, y2, new SKPaint { Color = clr });
                }
                SKPaint paint = new SKPaint
                {
                    TextSize = fontSize,//字体大小
                    IsAntialias = true,//开启抗锯齿
                    Typeface = SKTypeface.FromFamilyName("Times New Roman", SKFontStyle.Bold), //字体
                };
                //画验证码字符串 
                for (int i = 0; i < chkCode.Length; i++)
                {
                    paint.Color = color[rnd.Next(color.Length)]; //字体颜色
                    canvas.DrawText(chkCode[i].ToString(), i * 18f, 18f, paint);//画文字 
                }
                using (var data = surface.Snapshot().Encode(SKEncodedImageFormat.Png, 100))
                {
                    this._image = data.ToArray();
                }
            }
        }
    }
}
