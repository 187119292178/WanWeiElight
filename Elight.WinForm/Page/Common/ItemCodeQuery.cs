using Elight.Entity;
using Elight.Entity.DTO.Parms;
using Elight.Logic;
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

namespace Elight.WinForm.Page.Common
{
    //1、先在子窗体中定义一个委托，根据实际需求定义委托；这个SendValue委托中需要传递的参数
    public delegate void SendValue(BasItemParams param);

    public partial class ItemCodeQuery : UIForm
    {
        private BaseItemLogic baseItemLogic;
        private BasItemParams param;


        //2、在子窗体中声明一个委托类型的事件，将委托与事件相关联
        public event SendValue sendVauleEvent;

        public ItemCodeQuery()
        {
            InitializeComponent();
            baseItemLogic = new BaseItemLogic();
            dataGridView.AutoGenerateColumns = false;
        }

        private void ItemCodeQuery_Load(object sender, EventArgs e)
        {
            txtkey.Focus();
            btnQuery_Click(sender, e);
        }



        /// <summary>
        /// 选择数据传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                this.ShowWarningDialog("请选择一行数据", UIStyle.Blue);
                return;
            }
            int index = dataGridView.SelectedIndex;
            if (index < 0)
            {
                this.ShowWarningDialog("请选择一行数据", UIStyle.Blue);
                return;
            }
            string itemCode = dataGridView.Rows[index].Cells["ItemCode"].Value.ToString();
            if (string.IsNullOrEmpty(itemCode))
            {
                this.ShowWarningDialog("选择的物料编码不能为空", UIStyle.Blue);
                return;
            }
            string itemName = dataGridView.Rows[index].Cells["ItemName"].Value.ToString();
            string itemDesc = dataGridView.Rows[index].Cells["ItemDesc"].Value.ToString();
            string matType = dataGridView.Rows[index].Cells["MatType"].Value == null ? ""
                : dataGridView.Rows[index].Cells["MatType"].Value.ToString();
            string matModel = dataGridView.Rows[index].Cells["MatModel"].Value == null ? ""
                : dataGridView.Rows[index].Cells["MatModel"].Value.ToString();
            string packQty = dataGridView.Rows[index].Cells["PackQty"].Value == null ? "0"
                : dataGridView.Rows[index].Cells["PackQty"].Value.ToString();
            if (param == null)
                param = new BasItemParams();
            param.itemCode = itemCode;
            param.itemName = itemName;
            param.itemDesc = itemDesc;
            param.MatModel = matModel;
            param.MatType = matType;
            param.PackQty = packQty;

            //3、调用(实现)委托类型事件，并传递相关参数
            if (sendVauleEvent != null)
            {
                sendVauleEvent(param);
                this.Close();
                return;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int totalCount = 0;
            List<BasItem> list = baseItemLogic.GetList(pagination.ActivePage, pagination.PageSize, txtkey.Text.Trim(), "", ref totalCount);
            pagination.TotalCount = totalCount;
            dataGridView.DataSource = list;
        }

        private void txtkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnQuery_Click(sender, null);
        }

        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            btnQuery_Click(null, null);
        }
    }
}
