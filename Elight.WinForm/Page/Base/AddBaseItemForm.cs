using Elight.Entity;
using Elight.Entity.Sys;
using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Core;
using Elight.Utility.Other;
using Elight.WinForm.Common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Elight.WinForm.Page.Base
{
    public partial class AddBaseItemForm : UIForm
    {
        public BaseItemPage ParentPage { get; set; }
        public string Code { get; set; }
        private BaseItemLogic baseItemLogic;
        private SysItemsDetailLogic detailLogic;

        public AddBaseItemForm()
        {
            InitializeComponent();
            baseItemLogic = new BaseItemLogic();
            detailLogic = new SysItemsDetailLogic();
        }

        private void AddBaseItemForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(Code))
            {
                this.Text = "新增物料";
                txtItemCode.Enabled = true;
            }
            else
            {
                this.Text = "修改物料";
                txtItemCode.Enabled = false;
            }

            BindItemType();

            BindModel();
        }

        private void BindModel()
        {
            if (!string.IsNullOrEmpty(Code))
            {
                BasItem entity = baseItemLogic.Get(Code);
                if (entity != null)
                {
                    txtItemCode.Text = entity.ItemCode;
                    txtItemName.Text = entity.ItemName;
                    txtDesc.Text = entity.ItemDesc;
                    cmbType.SelectedValue = entity.MatType;
                    txtMatModel.Text = entity.MatModel;
                    txtPackQty.Value = entity.PackQty.Value;
                    txtPalletQty.Value = entity.PalletQty.Value;
                    txtOutput.Text = entity.OutputDesc;
                    txtSource.Text = entity.SourceDesc;
                    //cmbType.SelectedValue = entity.MatType;
                }
            }
        }

        #region 绑定物料类型
        public void BindItemType()
        {
            //List<ItemObject> list = new List<ItemObject>();
            //ItemObject item1 = new ItemObject() { RealValue = "PCB", TextName = "PCB" };
            //ItemObject item2 = new ItemObject() { RealValue = "FG", TextName = "整机" };
            //list.Add(item1);
            //list.Add(item2);

            //cmbType.DataSource = list;
            //cmbType.DisplayMember = "TextName";
            //cmbType.ValueMember = "RealValue";

            string productTypeId = ConfigurationManager.AppSettings["MaterialTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("MaterialType");
            cmbType.ValueMember = "EnCode";
            cmbType.DisplayMember = "Name";
            cmbType.DataSource = list;
        }

        public class ItemObject
        {
            // public ItemObject() { }
            public string RealValue { get; set; }
            public string TextName { get; set; }
        }
        #endregion

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty()
        {
            bool bFlag = true;
            if (StringHelper.IsNullOrEmpty(txtItemCode.Text))
            {
                this.ShowWarningDialog("物料编码不能为空", UIStyle.White);
                return false;
            }
            if (StringHelper.IsNullOrEmpty(txtItemName.Text))
            {
                this.ShowWarningDialog("物料名称不能为空", UIStyle.White);
                return false;
            }

            //if (StringHelper.IsNullOrEmpty(txtMatModel.Text))
            //{
            //    this.ShowWarningDialog("机型代码不能为空", UIStyle.White);
            //    return false;
            //}
            //if (txtMatModel.Text.Trim().Length != 9)
            //{
            //    this.ShowWarningDialog("机型代码长度必须为9", UIStyle.Blue);
            //    return false;
            //}

            if (StringHelper.IsNullOrEmpty(txtDesc.Text))
            {
                this.ShowWarningDialog("规格型号不能为空", UIStyle.White);
                return false;
            }

            return bFlag;
        }

        private void DoAddUpdate(string action)
        {
            bool flag = ChechEmpty();
            if (!flag)
            {
                return;
            }

            BasItem model = new BasItem();
            model.ItemCode = txtItemCode.Text.Trim();
            model.ItemName = txtItemName.Text.Trim();
            model.ItemDesc = txtDesc.Text.Trim();
            model.MatType = cmbType.SelectedValue.ToString();
            model.MatModel = txtMatModel.Text.Trim();
            model.PackQty = txtPackQty.Value;
            model.PalletQty = txtPalletQty.Value;
            model.OutputDesc = txtOutput.Text.Trim();
            model.SourceDesc = txtSource.Text.Trim();

            if (action == "ADD")
            {
                model.CreateTime = DateTime.Now;
                model.ModifyTime = DateTime.Now;
                model.CreateUser = GlobalConfig.CurrentUser.Id; ;
                model.ModifyUser = GlobalConfig.CurrentUser.Id;
                model.DeleteMark = "N";
                model.IsEnabled = "Y";
            }
            else
            {
                model.ModifyUser = GlobalConfig.CurrentUser.Id;
                model.ModifyTime = DateTime.Now;
            }
            int row = 0;
            if (action == "ADD")
                row = baseItemLogic.Insert(model);
            else
                row = baseItemLogic.Update(model);

            if (row == 0)
            {
                this.ShowWarningDialog("对不起，操作失败", UIStyle.Blue);
                return;
            }

            ParentPage.Init();
            FormHelper.subForm = null;
            this.Close();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Code))
            {
                BasItem entity = baseItemLogic.Get(txtItemCode.Text.Trim());
                if (entity != null) {

                    this.ShowWarningDialog(Code + "该物料编码已经有数据不行重复新增！", UIStyle.Blue);
                    return;
                }
                DoAddUpdate("ADD");
            }
            else
            {
                DoAddUpdate("UPDATE");
            }
        }

        private void txtItemCode_MouseLeave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtItemCode.Text.Trim()))
            {
                string sMsg = "";
                string itemCode = txtItemCode.Text.Trim();
                txtMatModel.Text = RuleCodeHelper.GetMatModel(itemCode, ref sMsg);
                if (sMsg.Length>0) {
                    this.ShowWarningDialog(sMsg, UIStyle.Blue);
                }
            }
        }
    }


}
