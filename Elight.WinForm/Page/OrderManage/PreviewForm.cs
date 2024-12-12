using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.OrderManage
{
    public partial class PreviewForm : Form
    {

        LabelManager2.ApplicationClass labApp;
        private static LabelManager2.Document doc = null;
        public string SN { get; set; }
        public string ItemCode { get; set; }
        public string FilePath { get; set; }

        public string sImageFile { get; set; }
        public PreviewForm(string sFile, string sn, string sItemCode, string filepath)
        {
            InitializeComponent();
            sImageFile= sFile;
            SN = sn;
            ItemCode = sItemCode;
            FilePath = filepath;
            labApp = new LabelManager2.ApplicationClass();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(sImageFile))
            //    pictureBox1.Load(sImageFile);

            ShowPrintImage();
        }

        private void ShowPrintImage()
        {
            try
            {
                labApp.Documents.Open(FilePath, false);
                //设置图片名称和路径
                sImageFile = AppDomain.CurrentDomain.BaseDirectory + @"PreviewImg\" + CommonHelper.Generate() + ".bmp";//保存图片的路径
                doc = labApp.ActiveDocument;
                doc.Variables.FormVariables.Item("BARCODESN").Value = SN;   //向Label档传入变量
                doc.Application.Visible = true;
                string st = doc.CopyImageToFile(8, "BMP", 0, 100, sImageFile);
                pictureBox1.Load(sImageFile);
            }
            catch(Exception ex)
            {
                MessageBox.Show("预览失败：" + ex.Message);
            }
            finally
            {
                labApp.Documents.CloseAll(true);
                labApp.Quit();
                labApp = null;
                doc = null;
            }
        }

        private void inFrom() {


            OpenFileDialog ofd = new OpenFileDialog(); //选择要打印的Label档
            ofd.ShowDialog();

            if (sImageFile.Length >0 )
            {
                string labFile = sImageFile;
                try
                {
                    labApp = new LabelManager2.ApplicationClass();
                    labApp.Documents.Open(labFile, false);
                    doc = labApp.ActiveDocument;
                    doc.Variables.FormVariables.Item("BARCODESN").Value = "234567890345678";//向Label档传入变量
                    string st = doc.CopyImageToFile(8, "BMP", 0, 100, labFile);
                    pictureBox1.Load(labFile);  //以图片的形式浏览打印的Label
                    doc.PrintDocument(1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出錯了，原因" + ex.Message);
                }
                finally
                {
                    labApp.Documents.CloseAll(true);
                    labApp.Quit();
                    labApp = null;
                    doc = null;
                }
            }
        }
    }
}
