using Elight.Entity.DTO.Parms;
using Elight.Logic.Base;
using Elight.Utility.Core;
using Elight.WinForm.Page.Common;
using Mysqlx.Crud;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;
using Elight.Entity.Sys;
using Elight.Logic.Sys;
using Elight.Entity.WanWei;
using Elight.WinForm.Common;
using Sunny.UI.Win32;
using Elight.Logic;
using Elight.Entity;
using Elight.Utility.Other;

namespace Elight.WinForm.Page.Base
{
    public partial class AddTemplateForm : UIForm
    {
        public TemplateManagePage ParentPage { get; set; }
        private BasTemplateLogic templateLogic;
        private SysItemsDetailLogic detailLogic;
        private BaseItemLogic baseItemLogic;
        private string sMsg = "";

        public string ItemCode { get; set; }
        public string MType { get; set; }
        private string MatType = "";
        private string filePath = "";
        private string username = "ftpuser";
        private string password = "Test123456";
        private string serverUrl = "ftp://47.107.77.75"; // 替换为你的服务器地址


        private BasTemplate model = new BasTemplate();

        /// <summary>
        /// 物料查询窗体
        /// </summary>
        private ItemCodeQuery itemQuery;

        public AddTemplateForm()
        {
            InitializeComponent();
            detailLogic = new SysItemsDetailLogic();
            templateLogic = new BasTemplateLogic();
            baseItemLogic = new BaseItemLogic();
            BindProductType();

            MyConfig config = File.ReadAllText(Utility.Extension.MyEnvironment.RootPath("Configs/config.json")).ToObject<MyConfig>();
            username = config.FtpUserName.ToString();
            password = config.FtpPassword.ToString();
            serverUrl = config.FtpHost.ToString();
        }

        private void BindProductType()
        {
            string productTypeId = ConfigurationManager.AppSettings["ProductTypeId"];
            List<SysItemDetail> list = detailLogic.GetItemDetailList("Template_type");
            cmbType.ValueMember = "EnCode";
            cmbType.DisplayMember = "Name";
            cmbType.DataSource = list;


        }

        private void BindModel()
        {
            if (!string.IsNullOrEmpty(ItemCode))
            {
                model = templateLogic.GetOne(ItemCode, MType);
                if (model != null)
                {
                    txtItemCode.Text = model.ItemCode;
                    cmbType.SelectedValue = model.TemplateType;
                    txtSNFile.Text = model.RemoteName;      //model.TemplateName;
                    txtSNQty.Value = (int)model.PrintCount;
                    if (!string.IsNullOrEmpty(txtItemCode.Text))
                    {
                        BasItem list = baseItemLogic.Get(txtItemCode.Text);

                        txtItemName.Text = list.ItemName;
                        txtDesc.Text = list.ItemDesc;
                    }

                }
            }
        }

        private void AddTemplateForm_Load(object sender, EventArgs e)
        {
            if (StringHelper.IsNullOrEmpty(ItemCode))
            {
                this.Text = "新增模板";
                txtItemCode.Enabled = true;
                txtItemName.Enabled = true;
                txtDesc.Enabled = true;
            }
            else
            {
                this.Text = "修改模板";
                txtItemCode.Enabled = false;
                txtItemName.Enabled = false;
                txtDesc.Enabled = false;
                BindModel();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //2 实例化查询子窗体
            itemQuery = new ItemCodeQuery();

            itemQuery.sendVauleEvent += new SendValue(fMain_ReceiveValueEvent);
            itemQuery.ShowDialog();
        }

        //父窗体接收参数事件
        public void fMain_ReceiveValueEvent(BasItemParams param)
        {
            if (param != null)
            {
                txtItemCode.Text = param.itemCode;
                txtItemName.Text = param.itemName;
                txtDesc.Text = param.itemDesc;
                //txtModel.Text = param.MatModel;
                MatType = param.MatType;
                txtMatType.Text = param.MatType;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(!ChechEmpty())
            {
                return;
            }
            if(string.IsNullOrEmpty(filePath))
            {
                this.ShowWarningDialog("请先选择要上传的模板文件", UIStyle.Blue);
                return;
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                UploadFile(serverUrl, filePath, username, password, ref msg);
            }

            if (!string.IsNullOrEmpty(msg))
            {
                this.ShowWarningDialog($"模板文件上传FTP服务器失败：{msg}", UIStyle.Blue);
                return;
            }

            if (string.IsNullOrEmpty(ItemCode))
            {
                DoAddUpdate("ADD");
            }
            else
            {
                DoAddUpdate("UPDATE");
            }
        }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool ChechEmpty()
        {
            bool bFlag = true;

            int iSNCount = txtSNQty.Value;
            if (iSNCount == 0)
            {
                this.ShowWarningDialog("模板打印份数必须大于0", UIStyle.Blue);
                return false;
            }
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {

                this.ShowWarningDialog("产品物料编码不能为空", UIStyle.Blue);
                return false;
            }
            if (string.IsNullOrEmpty(txtSNFile.Text))
            {

                this.ShowWarningDialog("选择打印模板", UIStyle.Blue);
                return false;
            }
            if (string.IsNullOrEmpty(ItemCode)) //表示新增
            {
                BasTemplate template = templateLogic.GetOnedeleteMark(txtItemCode.Text, cmbType.SelectedValue.ToString(),"N");

                if (template != null)
                {
                    sMsg = $"该物料[{txtItemCode.Text}]已有 {cmbType.SelectedText} 类型模板，不能重复新增";
                    this.ShowWarningDialog(sMsg, UIStyle.Blue);
                    return false;
                }
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


            int iSNCount = txtSNQty.Value;
            if (action == "ADD")
            {
                model.ItemCode = txtItemCode.Text;
                model.TemplateType = cmbType.SelectedValue.ToString();
                model.HostURL = serverUrl;
                model.TemplateName = txtSNFile.Text;
                model.TemplateURL = filePath;
                model.PrintCount = iSNCount;
                model.IsEnabled = "Y";
                model.DeleteMark = "N";
                model.CreateTime = DateTime.Now;
                model.ModifyTime = DateTime.Now;
                model.CreateUser = GlobalConfig.CurrentUser.Account;
                model.ModifyUser = GlobalConfig.CurrentUser.Account;
            }
            else
            {

                model.TemplateType = cmbType.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(filePath))
                {
                    model.TemplateURL = filePath;
                }
                model.TemplateName = txtSNFile.Text;
                model.PrintCount = iSNCount;
                model.ModifyUser = GlobalConfig.CurrentUser.Account;
                model.ModifyTime = DateTime.Now;
            }

            int row = 0;
            if (action == "ADD")
            {

                int temp = templateLogic.Insert(model);
                if (temp >= 0)
                {
                    sMsg = "物料模板新增成功！";
                }
                else
                {
                    sMsg = "物料模板新增失败！";
                }
            }
            else
            {
                int temp = templateLogic.Update(model);
                if (temp >= 0)
                {
                    sMsg = "物料模板修改成功！";
                }
                else
                {
                    
                    sMsg = "物料模板修改失败！";
                }
            }

            this.ShowWarningDialog(sMsg, UIStyle.Blue);

            ParentPage.Init();
            FormHelper.subForm = null;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 选择产品模板文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "模板文件 (*.*)|*.Lab";
            openFileDialog.Title = "选择要上传的文件";
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; // 获取文件路径

                string[] sArray = filePath.Split("\\");
                sArray.Count();
                int let = 0;
                if (sArray.Count() > 1)
                {
                    let = sArray.Count() - 1;

                }
                string aa = sArray[let];
                txtSNFile.Text = aa;
            }
        }


        public void UploadFile(string ftpUrl, string filePath, string username, string password, ref string msg)
        {
            msg = "";
            try
            {                
                FileInfo fileInfo = new FileInfo(filePath);
                //DateTime dateTime = DateTime.Now;
                //long timelong =  DateTimeToTimestamp(dateTime);

                //string uploadUrl = ftpUrl + "/"+(timelong + fileInfo.Name);

                string uploadname = CommonHelper.Generate();
                string uploadUrl = ftpUrl + "/" + uploadname + fileInfo.Extension;
                model.RemoteName = uploadname + fileInfo.Extension;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UseBinary = true;
                request.UsePassive = false;
                request.EnableSsl = false;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => true);

                // 读取文件内容
                byte[] fileContents;
                using (FileStream fs = fileInfo.OpenRead())
                {
                    fileContents = new byte[fs.Length];
                    fs.Read(fileContents, 0, (int)fs.Length);
                }

                // 上传文件
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }
                // 获取上传响应
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    msg = "";
                    //Console.WriteLine("Upload status: " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                //Console.WriteLine("Error uploading file: " + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ftpUrl">源文件路径</param>
        /// <param name="savePath">下载后保存的文件路径</param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="msg"></param>
        public void DownloadFile(string ftpUrl, string savePath, string username, string password, ref string msg)
        {
             msg = "";

            // 检查保存文件路径的目录是否存在
            string directory = Path.GetDirectoryName(savePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UseBinary = true;
                request.UsePassive = false;
                request.EnableSsl = false;

                // 获取响应
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // 检查文件的大小
                    long contentLength = response.ContentLength; // 获取文件大小
                    string feilname = response.ResponseUri.LocalPath.ToString();
                    string[] sArray = feilname.Split("\\");
                    sArray.Count();
                    int let = 0;
                    if (sArray.Count() > 1)
                    {
                        let = sArray.Count() - 1;

                    }
                    String result = sArray[let];
                    //Console.WriteLine("File Size: " + contentLength);

                    string sLocationPath = savePath + result;
                    using (Stream responseStream = response.GetResponseStream())
                    using (FileStream fs = new FileStream(sLocationPath, FileMode.Create, FileAccess.Write))
                    {
                        responseStream.CopyTo(fs); // 下载文件
                    }
                }

            }
            catch (NotSupportedException ex)
            {
                msg = ex.Message;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }

        /// <summary>
        /// 下载模板文件到本地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            string sTempType = cmbType.SelectedText;
            if (string.IsNullOrEmpty(txtSNFile.Text.Trim()))
            {
                this.ShowWarningDialog($"该料号没有上传{sTempType}，请上传后再下载", UIStyle.Blue);
                return;
            }
            BasTemplate template = templateLogic.GetOnedeleteMark(txtItemCode.Text, cmbType.SelectedValue.ToString(), "N");
            if (template == null)
            {
                this.ShowWarningDialog($"该料号没有上传{sTempType}，请上传后再下载", UIStyle.Blue);
                return;
            }

            //获取服务器源模板文件
            string ftpUrl = template.HostURL + "/" + template.RemoteName;

            //本地保存
            string dirFilePath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = template.RemoteName;
            saveFileDialog.Filter = "模板文件（.Lab）|*.Lab";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dirFilePath = saveFileDialog.FileName;
            }

            DownloadFile(ftpUrl, dirFilePath, username, password, ref sMsg);
            if(!string.IsNullOrEmpty(sMsg))
            {
                this.ShowWarningDialog($"打印模板文件下载失败：{sMsg}", UIStyle.Blue);
                return;
            }
            else
            {
                this.ShowWarningDialog("打印模板文件下载成功", UIStyle.Blue);
            }
        
        }

        //public static long DateTimeToTimestamp(DateTime datetime)
        //{
        //    DateTime dd = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        //    DateTime timeUTC = DateTime.SpecifyKind(datetime, DateTimeKind.Utc);//本地时间转成UTC时间
        //    TimeSpan ts = (timeUTC - dd);
        //    return (Int64)ts.TotalMilliseconds;//精确到毫秒
        //}

    }
}
