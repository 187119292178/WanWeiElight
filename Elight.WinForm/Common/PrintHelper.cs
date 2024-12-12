using Elight.Entity.WanWei;
using LabelManager2;
using NPOI.OpenXmlFormats.Dml.Chart;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.WinForm.Common
{
    public class PrintHelper
    {
        private static LabelManager2.ApplicationClass labApp = null;
        private static  LabelManager2.ApplicationClass labApp2 = null;
        private static  LabelManager2.Document doc = null;

        /// <summary>
        /// 根据模板做打印预览
        /// </summary>
        /// <param name="sLabFile"></param>
        public static void PrintPreview(string sLabFile, string sn, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp2 = new LabelManager2.ApplicationClass();
                labApp2.Documents.Open(sLabFile, false);
                doc = labApp2.ActiveDocument;
                doc.Variables.FormVariables.Item("BARCODESN").Value = sn;
                doc.Application.Visible = true;
            }
            catch(Exception ex)
            {
                sMsg = $"调用codesoft插件打印预览时出现异常：{ex.Message}";
            }
        }

        public static bool PrintBOXLabel(LabelManager2.ApplicationClass labApp, string sFile, int iCount,
                WIP_SNRes model, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                doc = labApp.ActiveDocument;

                doc.Variables.FormVariables.Item("BARCODESN").Value = model.SN;
                doc.PrintLabel(iCount, 1, 1, 1, 1, "");

                doc.FormFeed();
                return true;
            }
            catch (Exception ex)
            {
                sMsg = $"调用codesoft插件打印时出现异常：{ex.Message}";
                /* System.Diagnostics.Process[] wordProcesses = System.Diagnostics.Process.GetProcessesByName("lppa");
                 foreach (var process in wordProcesses)
                 {
                     process.Kill();
                 }*/
                return false;
            }
            finally
            {
                labApp.Documents.CloseAll(false);
                labApp.Quit();
                labApp = null;
                doc = null;
            }
        }

        public static bool PrintLabel(LabelManager2.ApplicationClass labApp, string sFile, int iCount, 
                List<WIP_SNRes> list, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                doc = labApp.ActiveDocument;

                foreach (WIP_SNRes model in list)
                {
                    doc.Variables.FormVariables.Item("BARCODESN").Value = model.SN;
                    doc.PrintLabel(iCount, 1, 1, 1, 1, "");
                }

                doc.FormFeed();
                return true;
            }
            catch(Exception ex)
            {
                sMsg = $"调用codesoft插件打印时出现异常：{ex.Message}";
               /* System.Diagnostics.Process[] wordProcesses = System.Diagnostics.Process.GetProcessesByName("lppa");
                foreach (var process in wordProcesses)
                {
                    process.Kill();
                }*/
                return false;
            }
            finally
            {
                labApp.Documents.CloseAll(false);
                labApp.Quit();
                labApp = null;
                doc = null;
            }
        }

        public static bool PrintCartonLabel(LabelManager2.ApplicationClass labApp, string sFile, int iCount, string sw,
                List<WIPSNTracking> list, string pn, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                doc = labApp.ActiveDocument;
                int i = 1;

                //没有的SN要赋空值
                string[] snList = new string[8];
                for(int x = 0; x < snList.Length; x++)
                {
                    if (x < list.Count)
                    {
                        snList[x] = list[x].SN;
                    }
                    else
                        snList[x] = "";
                }

                for (int y = 1; y <= snList.Length; y++)
                {
                    string sn = "SN" + y.ToString();
                    doc.Variables.FormVariables.Item(sn).Value = snList[y - 1];
                }

                //foreach (WIPSNTracking model in list)
                //{
                //    string sn = "SN" + i.ToString();
                //    doc.Variables.FormVariables.Item(sn).Value = model.SN;
                //    i = i + 1;
                //}

                doc.Variables.FormVariables.Item("QTY").Value = list.Count.ToString();
                doc.Variables.FormVariables.Item("SW").Value = sw;
                doc.Variables.FormVariables.Item("PN").Value = pn;
                doc.PrintLabel(iCount, 1, 1, 1, 1, "");
                doc.FormFeed();
                return true;
            }
            catch (Exception ex)
            {
                sMsg = $"调用codesoft插件打印时出现异常：{ex.Message}";
                /*System.Diagnostics.Process[] wordProcesses = System.Diagnostics.Process.GetProcessesByName("lppa");
                foreach (var process in wordProcesses)
                {
                    process.Kill();
                }*/
                return false;
            }
            finally
            {
                labApp.Documents.CloseAll(false);
                labApp.Quit();
                labApp = null;
                doc = null;
            }
        }

        public static bool PrintBoxLabel(LabelManager2.ApplicationClass labApp, string sFile, int iCount,string sw,
                List<WIP_SNRes> list, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                doc  = labApp.ActiveDocument;
                int i = 1;
                foreach (WIP_SNRes model in list)
                {
                    string sn = "SN" + i.ToString();
                    doc.Variables.FormVariables.Item(sn).Value = model.SN;
                    i = i + 1;
                }
                doc.Variables.FormVariables.Item("QTY").Value = list.Count.ToString();
                doc.Variables.FormVariables.Item("SW").Value = sw;
                doc.Variables.FormVariables.Item("PN").Value = list[0].PN;
                doc.PrintLabel(iCount, 1, 1, 1, 1, "");
                doc.FormFeed();
                return true;
            }
            catch (Exception ex)
            {
                sMsg = $"调用codesoft插件打印时出现异常：{ex.Message}";
                /*System.Diagnostics.Process[] wordProcesses = System.Diagnostics.Process.GetProcessesByName("lppa");
                foreach (var process in wordProcesses)
                {
                    process.Kill();
                }*/
                return false;
            }
            finally
            {
                labApp.Documents.CloseAll(false);
                labApp.Quit();
                labApp = null;
                doc = null;
            }
        }

        public static bool PrintLabel(string sFile, int iCount,
        List<WIP_SNRes> list, ref string sMsg)
        {
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                doc = labApp.ActiveDocument;

                foreach (WIP_SNRes model in list)
                {
                    doc.Variables.FormVariables.Item("BARCODESN").Value = model.SN;
                    doc.PrintLabel(iCount, 1, 1, 1, 1, "");
                }

                doc.FormFeed();
                labApp.Quit();
                return true;
            }
            catch (Exception ex)
            {
                sMsg = $"调用codesoft插件打印时出现异常：{ex.Message}";
                return false;
            }
            finally
            {
                labApp = null;
                doc = null;
            }
        }


        /// <summary>
        /// 根据模板做打印预览
        /// </summary>
        /// <param name="sFile"></param>
        /// <param name="sn"></param>
        /// <param name="sImageFile"></param>
        /// <param name="sMsg"></param>
        public static void PrintPreview(LabelManager2.ApplicationClass labApp, string sFile, string sn, ref string sImageFile, ref string sMsg)
        {
            string sImagePath =AppDomain.CurrentDomain.BaseDirectory + @"Res\PreviewLabel\";
            sMsg = "";
            try
            {
                labApp = new LabelManager2.ApplicationClass();
                labApp.Documents.Open(sFile, false);
                sImagePath += System.DateTime.Now.ToString("yyyyMMddHHmissfffff") + ".bmp";
                doc = labApp.ActiveDocument;
                doc.Variables.FormVariables.Item("BARCODESN").Value = sn;
                string st = doc.CopyImageToFile(8, "BMP", 0, 100, sImagePath);
                sImageFile = sImagePath;
            }
            catch(Exception ex)
            {
                sMsg = $"调用codesoft插件打印预览时出现异常：{ex.Message}";
            }
            finally
            {
                if (labApp != null)
                {
                    labApp.Documents.CloseAll(true);
                    labApp.Quit();
                    doc = null;
                }
            }
        }


        public static List<string> GetLabVarName(string LabPathName, ref string sMsg)
        {
            sMsg = "";
            try
            {
                List<string> varList = new List<string>();
                if (!File.Exists(LabPathName))
                {
                    throw new Exception("Lab文件不存在,请确认");
                }
                FileInfo fileInfo = new FileInfo(LabPathName);

                LabelManager2.ApplicationClass lbl = new LabelManager2.ApplicationClass();
                lbl.Documents.Open(fileInfo.FullName, false);       //调用设计好的Label文件
                LabelManager2.Document doc = lbl.ActiveDocument;    //获取变量文本 为dos
                for (int i = 1; i <= doc.Variables.Count; i++)
                {
                    varList.Add(doc.Variables.Item(i).Name.ToString());
                }
                return varList;
            }
            catch (Exception ex)
            {
                sMsg = $"获取模板变量信息时出现异常：{ex.Message}";
                return null;
            }
        }



    }
}
