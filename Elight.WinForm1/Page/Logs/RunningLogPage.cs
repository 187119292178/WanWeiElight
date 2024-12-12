using Elight.Entity.Sys;
using Elight.Utility.Network;
using Elight.Utility.Other;
using Elight.Utility.ResponseModels;
using Elight.WinForm.Common;
using Elight.WinForm.Page;  
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

namespace MES.WinForm.Page.Logs
{
    [PageCode("log-running")]
    public partial class RunningLogPage : MyPage
    {
        private int buttonId = 1;
        private string Type = "Running";

        public RunningLogPage()
        {
            InitializeComponent();
            logDataGridView.AutoGenerateColumns = false;
            pagination.PageSize = 29;
        }



        private void OperationLogPage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/log/index";
            var data = new
            {
                pageIndex = pagination.ActivePage,
                pageSize = pagination.PageSize,
                type = Type,
                index = Convert.ToString(buttonId),
                keyWord = txtKeywords.Text
            };
            RetMessage<LayPadding<SysLog>> result =WebApiRequest.DoPostJson<LayPadding<SysLog>>(url, data);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            pagination.TotalCount = (int)result.data.count;
            logDataGridView.DataSource = result.data.list;
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
            string url = $"{GlobalConfig.Config.ServerUrl}app/system/log/export";
            var data = new { type = Type };
            RetMessage<byte[]> result =WebApiRequest.DoPostJson<byte[]>(url, data);
            if (result == null)
            {
                this.ShowWarningDialog("网络或服务器异常，请稍后重试", UIStyle.White);
                return;
            }
            if (result.code != RetCode.success)
            {
                this.ShowWarningDialog(result.message, UIStyle.White);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "zip文件(*.zip)|*.zip";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = dialog.FileName;
            try
            {
                byte[] bytes = result.data;
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
