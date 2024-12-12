using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.Reflection;
using System.Diagnostics;

namespace Elight.WinForm.Common
{
    public static class ExcelHelperForCS
    {
        #region 私有方法

        /// <summary>
        /// 获取要保存的文件名称（含完整路径）
        /// </summary>
        /// <returns></returns>
        private static string GetSaveFilePath()
        {
            SaveFileDialog saveFileDig = new SaveFileDialog();
            saveFileDig.Filter = "Excel Office97-2003(*.xls)|*.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            saveFileDig.FilterIndex = 0;
            saveFileDig.Title = "导出到";
            saveFileDig.OverwritePrompt = true;
            saveFileDig.InitialDirectory = Application.StartupPath;
            string filePath = null;
            if (saveFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDig.FileName;
            }

            return filePath;
        }

        /// <summary>
        /// 获取要打开要导入的文件名称（含完整路径）
        /// </summary>
        /// <returns></returns>
        private static string GetOpenFilePath()
        {
            OpenFileDialog openFileDig = new OpenFileDialog();
            openFileDig.Filter = "Excel Office97-2003(*.xls)|*.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            openFileDig.FilterIndex = 0;
            openFileDig.Title = "打开";
            openFileDig.CheckFileExists = true;
            openFileDig.CheckPathExists = true;
            openFileDig.InitialDirectory = Application.StartupPath;
            string filePath = null;
            if (openFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDig.FileName;
            }

            return filePath;
        }

        /// <summary>
        /// 判断是否为兼容模式
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static bool GetIsCompatible(string filePath)
        {
            return filePath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 创建工作薄
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <returns></returns>
        private static IWorkbook CreateWorkbook(bool isCompatible)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook();
            }
            else
            {
                return new XSSFWorkbook();
            }
        }

        /// <summary>
        /// 创建工作薄(依据文件流)
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static IWorkbook CreateWorkbook(bool isCompatible, dynamic stream)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook(stream);
            }
            else
            {
                return new XSSFWorkbook(stream);
            }
        }

        /// <summary>
        /// 创建表格头单元格
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private static ICellStyle GetCellStyle(IWorkbook workbook)
        {
            ICellStyle style = workbook.CreateCellStyle();
            style.FillPattern = FillPattern.SolidForeground;
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;

            return style;
        }

        /// <summary>
        /// 从工作表中生成DataTable
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="headerRowIndex"></param>
        /// <returns></returns>
        private static DataTable GetDataTableFromSheet(ISheet sheet, int headerRowIndex)
        {
            DataTable table = new DataTable();

            IRow headerRow = sheet.GetRow(headerRowIndex);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                if (headerRow.GetCell(i) == null || headerRow.GetCell(i).StringCellValue.Trim() == "")
                {
                    // 如果遇到第一个空列，则不再继续向后读取
                    cellCount = i;
                    break;
                }
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            for (int i = (headerRowIndex + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                //如果遇到某行的第一个单元格的值为空，则不再继续向下读取
                if (row != null && !string.IsNullOrEmpty(row.GetCell(0).ToString()))
                {
                    DataRow dataRow = table.NewRow();

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        dataRow[j] = row.GetCell(j).ToString();
                    }

                    table.Rows.Add(dataRow);
                }
            }

            return table;
        }

        #endregion

        #region 公共导出方法

        /// <summary>
        /// 由DataSet导出Excel
        /// </summary>
        /// <param name="sourceTable">要导出数据的DataTable</param>
        /// <returns>Excel工作表</returns>
        public static string ExportToExcel(DataSet sourceDs, string filePath = null)
        {

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = GetIsCompatible(filePath);

            IWorkbook workbook = CreateWorkbook(isCompatible);
            ICellStyle cellStyle = GetCellStyle(workbook);

            for (int i = 0; i < sourceDs.Tables.Count; i++)
            {
                DataTable table = sourceDs.Tables[i];
                string sheetName = "result" + i.ToString();
                ISheet sheet = workbook.CreateSheet(sheetName);
                IRow headerRow = sheet.CreateRow(0);
                // handling header.
                foreach (DataColumn column in table.Columns)
                {
                    ICell cell = headerRow.CreateCell(column.Ordinal);
                    cell.SetCellValue(column.ColumnName);
                    cell.CellStyle = cellStyle;
                }

                // handling value.
                int rowIndex = 1;

                foreach (DataRow row in table.Rows)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);

                    foreach (DataColumn column in table.Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue((row[column] ?? "").ToString());
                    }

                    rowIndex++;
                }
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();
            workbook = null;

            return filePath;

        }

        /// <summary>
        /// 由DataTable导出Excel
        /// </summary>
        /// <param name="sourceTable">要导出数据的DataTable</param>
        /// <returns>Excel工作表</returns>
        public static string ExportToExcel(DataTable sourceTable, string sheetName = "result", string filePath = null)
        {
            if (sourceTable.Rows.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = GetIsCompatible(filePath);

            IWorkbook workbook = CreateWorkbook(isCompatible);
            ICellStyle cellStyle = GetCellStyle(workbook);

            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow headerRow = sheet.CreateRow(0);
            // handling header.
            foreach (DataColumn column in sourceTable.Columns)
            {
                ICell headerCell = headerRow.CreateCell(column.Ordinal);
                headerCell.SetCellValue(column.ColumnName);
                headerCell.CellStyle = cellStyle;
            }

            // handling value.
            int rowIndex = 1;

            foreach (DataRow row in sourceTable.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);

                foreach (DataColumn column in sourceTable.Columns)
                {
                    dataRow.CreateCell(column.Ordinal).SetCellValue((row[column] ?? "").ToString());
                }

                rowIndex++;
            }
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();

            sheet = null;
            headerRow = null;
            workbook = null;

            return filePath;
        }

        /// <summary>
        /// 由List导出Excel
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="data">在导出的List</param>
        /// <param name="sheetName">sheet名称</param>
        /// <returns></returns>
        public static string ExportToExcel<T>(List<T> data, IList<KeyValuePair<string, string>> headerNameList, string sheetName = "result", string filePath = null) where T : class
        {
            if (data.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = GetIsCompatible(filePath);

            IWorkbook workbook = CreateWorkbook(isCompatible);
            ICellStyle cellStyle = GetCellStyle(workbook);
            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow headerRow = sheet.CreateRow(0);

            for (int i = 0; i < headerNameList.Count; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(headerNameList[i].Value);
                cell.CellStyle = cellStyle;
            }

            Type t = typeof(T);
            int rowIndex = 1;
            foreach (T item in data)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);
                for (int n = 0; n < headerNameList.Count; n++)
                {
                    object pValue = t.GetProperty(headerNameList[n].Key).GetValue(item, null);
                    dataRow.CreateCell(n).SetCellValue((pValue ?? "").ToString());
                }
                rowIndex++;
            }
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();

            sheet = null;
            headerRow = null;
            workbook = null;

            return filePath;
        }

        /// <summary>
        /// 由DataGridView导出
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="sheetName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ExportToExcel(DataGridView grid, string sheetName = "result", string filePath = null)
        {
            if (grid.Rows.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = GetIsCompatible(filePath);

            IWorkbook workbook = CreateWorkbook(isCompatible);
            ICellStyle cellStyle = GetCellStyle(workbook);
            ISheet sheet = workbook.CreateSheet(sheetName);

            IRow headerRow = sheet.CreateRow(0);

            for (int i = 0; i < grid.Columns.Count; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(grid.Columns[i].HeaderText);
                cell.CellStyle = cellStyle;
            }

            int rowIndex = 1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);
                for (int n = 0; n < grid.Columns.Count; n++)
                {
                    dataRow.CreateCell(n).SetCellValue((row.Cells[n].Value ?? "").ToString());
                }
                rowIndex++;
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();

            sheet = null;
            headerRow = null;
            workbook = null;

            return filePath;
        }

        #endregion

        #region 公共导入方法

        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataTable</returns>
        public static DataTable ImportFromExcel(Stream excelFileStream, string sheetName, int headerRowIndex, bool isCompatible)
        {
            IWorkbook workbook = CreateWorkbook(isCompatible, excelFileStream);
            ISheet sheet = null;
            int sheetIndex = -1;
            if (int.TryParse(sheetName, out sheetIndex))
            {
                sheet = workbook.GetSheetAt(sheetIndex);
            }
            else
            {
                sheet = workbook.GetSheet(sheetName);
            }

            DataTable table = GetDataTableFromSheet(sheet, headerRowIndex);

            excelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }

        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径。</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataTable</returns>
        public static DataTable ImportFromExcel(string excelFilePath, string sheetName, int headerRowIndex)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                excelFilePath = GetOpenFilePath();
            }

            if (string.IsNullOrEmpty(excelFilePath))
            {
                return null;
            }

            using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
            {
                bool isCompatible = GetIsCompatible(excelFilePath);
                return ImportFromExcel(stream, sheetName, headerRowIndex, isCompatible);
            }
        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataSet</returns>
        public static DataSet ImportFromExcel(Stream excelFileStream, int headerRowIndex, bool isCompatible)
        {
            DataSet ds = new DataSet();
            IWorkbook workbook = CreateWorkbook(isCompatible, excelFileStream);
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);
                DataTable table = GetDataTableFromSheet(sheet, headerRowIndex);
                ds.Tables.Add(table);
            }

            excelFileStream.Close();
            workbook = null;

            return ds;
        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径。</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataSet</returns>
        public static DataSet ImportFromExcel(string excelFilePath, int headerRowIndex)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                excelFilePath = GetOpenFilePath();
            }

            if (string.IsNullOrEmpty(excelFilePath))
            {
                return null;
            }

            using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
            {
                bool isCompatible = GetIsCompatible(excelFilePath);
                return ImportFromExcel(stream, headerRowIndex, isCompatible);
            }
        }

        #endregion

        #region 公共转换方法

        /// <summary>
        /// 将Excel的列索引转换为列名，列索引从0开始，列名从A开始。如第0列为A，第1列为B...
        /// </summary>
        /// <param name="index">列索引</param>
        /// <returns>列名，如第0列为A，第1列为B...</returns>
        public static string ConvertColumnIndexToColumnName(int index)
        {
            index = index + 1;
            int system = 26;
            char[] digArray = new char[100];
            int i = 0;
            while (index > 0)
            {
                int mod = index % system;
                if (mod == 0) mod = system;
                digArray[i++] = (char)(mod - 1 + 'A');
                index = (index - 1) / 26;
            }
            StringBuilder sb = new StringBuilder(i);
            for (int j = i - 1; j >= 0; j--)
            {
                sb.Append(digArray[j]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 转化日期
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns></returns>
        public static DateTime ConvertToDate(object date)
        {
            string dtStr = (date ?? "").ToString();

            DateTime dt = new DateTime();

            if (DateTime.TryParse(dtStr, out dt))
            {
                return dt;
            }

            try
            {
                string spStr = "";
                if (dtStr.Contains("-"))
                {
                    spStr = "-";
                }
                else if (dtStr.Contains("/"))
                {
                    spStr = "/";
                }
                string[] time = dtStr.Split(spStr.ToCharArray());
                int year = Convert.ToInt32(time[2]);
                int month = Convert.ToInt32(time[0]);
                int day = Convert.ToInt32(time[1]);
                string years = Convert.ToString(year);
                string months = Convert.ToString(month);
                string days = Convert.ToString(day);
                if (months.Length == 4)
                {
                    dt = Convert.ToDateTime(date);
                }
                else
                {
                    string rq = "";
                    if (years.Length == 1)
                    {
                        years = "0" + years;
                    }
                    if (months.Length == 1)
                    {
                        months = "0" + months;
                    }
                    if (days.Length == 1)
                    {
                        days = "0" + days;
                    }
                    rq = "20" + years + "-" + months + "-" + days;
                    dt = Convert.ToDateTime(rq);
                }
            }
            catch
            {
                throw new Exception("日期格式不正确，转换日期类型失败！");
            }
            return dt;
        }

        /// <summary>
        /// 转化数字
        /// </summary>
        /// <param name="d">数字字符串</param>
        /// <returns></returns>
        public static decimal ConvertToDecimal(object d)
        {
            string dStr = (d ?? "").ToString();
            decimal result = 0;
            if (decimal.TryParse(dStr, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("数字格式不正确，转换数字类型失败！");
            }

        }

        /// <summary>
        /// 转化布尔
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool ConvertToBoolen(object b)
        {
            string bStr = (b ?? "").ToString().Trim();
            bool result = false;
            if (bool.TryParse(bStr, out result))
            {
                return result;
            }
            else if (bStr == "0" || bStr == "1")
            {
                return (bStr == "0");
            }
            else
            {
                throw new Exception("布尔格式不正确，转换布尔类型失败！");
            }
        }
        #endregion

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="TableName"></param>
        public static void ExportDataToExcel(DataTable TableName)
        {
            string FileName = DateTime.Now.GetHashCode().ToString();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //设置文件标题
                Title = "导出Excel文件",
                //设置文件类型
                Filter = "Excel 工作簿(*.xlsx)|*.xlsx|Excel 97-2003 工作簿(*.xls)|*.xls",
                //设置默认文件类型显示顺序
                FilterIndex = 1,
                //是否自动在文件名中添加扩展名
                AddExtension = true,
                //是否记忆上次打开的目录
                RestoreDirectory = true,
                //设置默认文件名
                FileName = FileName
            };
            //按下确定选择的按钮
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径
                string localFilePath = saveFileDialog.FileName.ToString();

                //数据初始化
                int TotalCount;     //总行数
                int RowRead = 0;    //已读行数

                TotalCount = TableName.Rows.Count;

                //NPOI
                IWorkbook workbook;
                string FileExt = Path.GetExtension(localFilePath).ToLower();
                if (FileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook();
                }
                else if (FileExt == ".xls")
                {
                    workbook = new HSSFWorkbook();
                }
                else
                {
                    workbook = null;
                }
                if (workbook == null)
                {
                    return;
                }
                ISheet sheet = string.IsNullOrEmpty(FileName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(FileName);

                //秒钟
                Stopwatch timer = new Stopwatch();
                timer.Start();

                try
                {
                    //读取标题
                    IRow rowHeader = sheet.CreateRow(0);
                    for (int i = 0; i < TableName.Columns.Count; i++)
                    {
                        ICell cell = rowHeader.CreateCell(i);
                        cell.SetCellValue(TableName.Columns[i].ColumnName);
                    }

                    //读取数据
                    for (int i = 0; i < TableName.Rows.Count; i++)
                    {
                        IRow rowData = sheet.CreateRow(i + 1);
                        for (int j = 0; j < TableName.Columns.Count; j++)
                        {
                            ICell cell = rowData.CreateCell(j);
                            cell.SetCellValue(TableName.Rows[i][j].ToString());
                        }
                        //状态栏显示
                        RowRead++;
                        int Percent = (int)(100 * RowRead / TotalCount);
                        System.Windows.Forms.Application.DoEvents();
                    }

                    System.Windows.Forms.Application.DoEvents();

                    //转为字节数组
                    MemoryStream stream = new MemoryStream();
                    workbook.Write(stream);
                    var buf = stream.ToArray();

                    //保存为Excel文件
                    using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(buf, 0, buf.Length);
                        fs.Flush();
                        fs.Close();
                    }
                    System.Windows.Forms.Application.DoEvents();

                    //关闭秒钟
                    timer.Reset();
                    timer.Stop();

                    //成功提示
                    if (MessageBox.Show("导出成功，是否立即打开？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(localFilePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    //关闭秒钟
                    timer.Reset();
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// DataTable转成List
        /// </summary>
        public static List<T> ToDataList<T>(this DataTable dt)
        {
            var list = new List<T>();
            var plist = new List<PropertyInfo>(typeof(T).GetProperties());

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow item in dt.Rows)
            {
                T s = Activator.CreateInstance<T>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    PropertyInfo info = plist.Find(p => p.Name == dt.Columns[i].ColumnName);
                    if (info != null)
                    {
                        try
                        {
                            if (!Convert.IsDBNull(item[i]))
                            {
                                object v = null;
                                if (info.PropertyType.ToString().Contains("System.Nullable"))
                                {
                                    v = Convert.ChangeType(item[i], Nullable.GetUnderlyingType(info.PropertyType));
                                }
                                else
                                {
                                    v = Convert.ChangeType(item[i], info.PropertyType);
                                }
                                info.SetValue(s, v, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("字段[" + info.Name + "]转换出错," + ex.Message);
                        }
                    }
                }
                list.Add(s);
            }
            return list;
        }



    }
}
