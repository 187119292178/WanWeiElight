using Elight.Entity.WanWei;
using Elight.Logic.Base;
using Elight.Utility.Other;
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

namespace Elight.WinForm.Page.Base
{
    [PageCode("base-template")]
    public partial class TemplateManagePage : MyPage
    {
        private string sMsg = "";
        private BasTemplateLogic logic;
        public TemplateManagePage()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
            logic = new BasTemplateLogic();
        }

        private void TemplateManagePage_Load(object sender, EventArgs e)
        {
            txtKeywords.Text = "";
            txtKeywords.Select();
            txtKeywords.Focus();
            btnQuery_Click(sender, e);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string itemCode = txtKeywords.Text.Trim();
            int totalCount = 0;
            List<BasTemplate> list = logic.GetList(pagination.ActivePage, pagination.PageSize, itemCode, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTemplateForm form = new AddTemplateForm();
            form.ParentPage = this;
            form.ItemCode = string.Empty;
            FormHelper.ShowSubForm(form);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }

            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            AddTemplateForm form = new AddTemplateForm();
            form.ParentPage = this;
            form.ItemCode = itemCode;
            form.MType = dataGridView.Rows[index].Cells["TemplateType"].Value.ToString();
            if (string.IsNullOrEmpty(itemCode))
            {
                this.ShowWarningDialog("选择的记录物料编码不能为空", UIStyle.Blue);
                return;
            }
            FormHelper.ShowSubForm(form);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.Blue);
                return;
            }
            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            string type = dataGridView.Rows[index].Cells["TemplateType"].Value.ToString();
            string id = dataGridView.Rows[index].Cells["Id"].Value.ToString();

            if (!this.ShowAskDialog("您是否确定要删除该打印模板？", UIStyle.Blue))
            {
                return;
            }
            //判断是否已经有打印过，有的话不允许删除
            bool bFlag = logic.PrintRecord(itemCode, type);
            if (bFlag)
            {
                this.ShowWarningDialog("产品打印模板，已有打印数据不能删除！", UIStyle.Blue);
                return;
            }
            else
            {

                int temp = logic.Delete(itemCode, type);

                if (temp > 0)
                {
                    this.ShowWarningDialog("删除成功！", UIStyle.Blue);
                    btnQuery_Click(sender, e);
                    return;

                }
                else
                {
                    this.ShowWarningDialog("删除失败！", UIStyle.Blue);
                    return;
                }
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            DataTable dt = FormHelper.GetDgvToTable(dataGridView);
            if (dt == null)
            {
                MessageBox.Show("请查询出数据后再导出", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ExcelHelperForCS.ExportDataToExcel(dt);
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }

        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemplateManagePage_Initialize(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }
    }
}
