using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Extension;
using Elight.Utility.Files;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Logs
{
    [PageCode("log-operate")]
    public partial class OperationLogPage : MyPage
    {
        private int buttonId = 1;
        private string Type = "Operate";

        public OperationLogPage()
        {
            InitializeComponent();
            logDataGridView.AutoGenerateColumns = false;
            pagination.PageSize = GlobalConfig.Config.EveryPageDataCount;
        }

        private void OperationLogPage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询日志  
            int totalCount = 0;
            List<SysLog> list = new SysLogLogic().GetList(pagination.ActivePage, pagination.PageSize, Type, Convert.ToString(buttonId), txtKeywords.Text, ref totalCount);
            pagination.TotalCount = totalCount;
            logDataGridView.DataSource = list;
        }


        /// <summary>
        /// 当天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            buttonId = 1;
            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 近7天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSevenDay_Click(object sender, EventArgs e)
        {
            buttonId = 2;
            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 近1个月
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOneMonth_Click(object sender, EventArgs e)
        {
            buttonId = 3;
            btnQuery_Click(sender, e);
        }

        /// <summary>
        /// 近3个月
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThreeMonth_Click(object sender, EventArgs e)
        {
            buttonId = 4;
            btnQuery_Click(sender, e);
        }


        /// <summary>
        /// 删除日志按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteLogsForm form = new DeleteLogsForm();
            form.ParentPage = this;
            form.Type = Type;
            FormHelper.ShowSubForm(form);
        }

        /// <summary>
        /// 页码发生改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }
        /// <summary>
        /// 关键字Enter键处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(null, null);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "zip文件(*.zip)|*.zip";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = dialog.FileName;
            string filePath = MyEnvironment.RootPath(UUID.StrSnowId + ".zip");
            string baseDirPath = MyEnvironment.RootPath("\\Log\\Operate\\");
            if (!Directory.Exists(baseDirPath))
            {
                this.ShowErrorDialog("导出失败", UIStyle.White);
                return;
            }
            try
            {
                //压缩
                ZipHelper.PackFiles(filePath, baseDirPath);
                byte[] bytes = FileUtil.FileToBytes(filePath);
                FileUtil.Delete(filePath);
                FileStream pFileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                pFileStream.Write(bytes, 0, bytes.Length);
                pFileStream.Close();
                this.ShowSuccessDialog("导出完成", UIStyle.White);
            }
            catch
            {
                this.ShowErrorDialog("导出失败", UIStyle.White);
            }
        }

        public override void Stop()
        {

        }
    }
}
