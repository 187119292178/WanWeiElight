using Elight.Entity;
using Elight.Entity.Sys;
using Elight.Entity.WanWei;
using Elight.Logic;
using Elight.Logic.Base;
using Elight.Logic.Sys;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Elight.WinForm.Page.Base
{
    [PageCode("base-item")]
    public partial class BaseItemPage : MyPage
    {
        private BaseItemLogic baseItemLogic;
        private SysItemsDetailLogic detailLogic;
        private OrderLogic orderLogic;
        private string sMsg = "";
        private List<BasItem> ImportList;
        public BaseItemPage()
        {
            InitializeComponent();
            baseItemLogic = new BaseItemLogic();
            detailLogic = new SysItemsDetailLogic();
            orderLogic = new OrderLogic();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
        }


        private void BindProductType()
        {
            //string productTypeId = ConfigurationManager.AppSettings["MaterialTypeId"];
            //List<SysItemDetail> list = detailLogic.GetListByItemId(productTypeId);
            List<SysItemDetail> lists = detailLogic.GetItemDetailList("MaterialType");
            cmbMAType.ValueMember = "EnCode";
            cmbMAType.DisplayMember = "Name";
            cmbMAType.DataSource = lists;

        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseItemPage_Initialize(object sender, EventArgs e)
        {

            btnQuery_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBaseItemForm form = new AddBaseItemForm();
            form.ParentPage = this;
            form.Code = string.Empty;
            FormHelper.ShowSubForm(form);
        }

        private void BaseItemPage_Load(object sender, EventArgs e)
        {
            BindProductType();
            btnSave.Enabled = false;
            btnQuery_Click(sender, e);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int totalCount = 0;
            string matType = "";
            if (cmbMAType.SelectedValue!=null) {
                matType = cmbMAType.SelectedValue.ToString();
            }
            if (matType.Equals("ALL")) {
                matType = null;
            }
            string txtKeyword = "";

            if (txtKeywords.Text.Length>0) {
                txtKeyword = txtKeywords.Text.Trim();
            }
            List<BasItem> list = baseItemLogic.GetList(pagination.ActivePage, pagination.PageSize, txtKeyword, matType, ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据进行修改", UIStyle.White); return;
            }

            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            AddBaseItemForm form = new AddBaseItemForm();
            form.ParentPage = this;
            form.Code = itemCode;
            FormHelper.ShowSubForm(form);
        }


        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            sMsg = "";
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    string _filePath = openFileDialog1.FileName;
                    if (_filePath != "")
                    {
                        DataTable dt = ExcelHelperForCS.ImportFromExcel(_filePath, "物料信息", 0);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            ImportList = ExcelHelperForCS.ToDataList<BasItem>(dt);
                            dataGridView.DataSource = dt;
                            sMsg = $"共{dt.Rows.Count}笔数据，要导入到系统请点击 批量保存提交 按钮";
                            btnSave.Enabled = true;
                        }
                        else
                        {
                            sMsg = "选择的文件没有内容，请确认清楚";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sMsg = ex.Message;
            }
            finally
            {
                if (!string.IsNullOrEmpty(sMsg))
                {
                    MessageBox.Show(sMsg, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ImportList == null || ImportList.Count == 0)
            {
                MessageBox.Show("请先选择有数据的文件导入", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (BasItem model in ImportList)
            {
                model.DeleteMark = "N";
                model.IsEnabled = "Y";
                model.CreateTime = DateTime.Now;
                model.CreateUser = GlobalConfig.CurrentUser.Account;
                model.ModifyTime = model.CreateTime;
                model.ModifyUser = model.CreateUser;

                BasItem entity = baseItemLogic.Get(model.ItemCode);
                if (entity != null)
                {
                    sMsg = $"物料料号[{model.ItemCode}]数据已经存在，不能重复导入";
                    MessageBox.Show(sMsg, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (model.MatType != "PCBA" && model.MatType != "物料" && model.MatType != "辅料"
                    && model.MatType != "成品")
                {
                    sMsg = $"物料料号[{model.ItemCode}]的物料类型为[{model.MatType}]，不符合数据要求，物料类型必须为PCBA/成品/物料/辅料 这4种";
                    MessageBox.Show(sMsg, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            int row = baseItemLogic.Insert(ImportList);
            if (row > 0)
            {
                btnSave.Enabled = false;
                btnQuery_Click(sender, e);
                MessageBox.Show($"共[{ImportList.Count}]笔数据导入成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show($"数据导入失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void pagination_Click(object sender, EventArgs e)
        {

        }

        private void cmbMAType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            sMsg = "请选择一行数据进行删除";
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog(sMsg, UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog(sMsg, UIStyle.Blue); 
                return;
            }
            string id = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            if (!this.ShowAskDialog("您是否确定要删除该物料编码？", UIStyle.Blue))
            {
                return;
            }
            try
            {               
                if(string.IsNullOrEmpty(id))
                {
                    sMsg = "选择的物料编码为空";
                    this.ShowWarningDialog(sMsg, UIStyle.Blue);
                    return;
                }

                //如果该物料已经存在工单则不能删除
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict["ItemCode"] = id;
                List<OrderInfo> orders = orderLogic.GetOrders(dict);
                if(orders != null && orders.Count > 0)
                {
                    this.ShowWarningDialog($"选择的物料编码[{id}]已经有工单在使用不能删除", UIStyle.Blue);
                    return;
                }

                int row = baseItemLogic.Delete(id);
                Logger.OperateInfo($"用户{GlobalConfig.CurrentUser.Account}删除了物料编码[{id}]");
                if (row > 0)
                {
                    sMsg = $"物料编码[{id}]删除成功";
                }
                else
                {
                    sMsg = $"物料编码[{id}]删除失败";
                }

                //重新刷新
                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                this.ShowWarningDialog("操作出现异常：" + ex.Message, UIStyle.Blue);
            }
        }

        public override void Stop()
        {

        }

    }
}
