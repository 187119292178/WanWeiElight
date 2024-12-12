using Elight.Utility.Other;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elight.WinForm.UserControls
{
    public partial class ProgressForm : UIForm
    {
        public delegate void EndEventHandler(object sender);
        public event EndEventHandler EndHandler;


        public delegate void ErrorEventHandler(object sender, Exception ex);
        public event ErrorEventHandler ErrorHandler;
        public ProgressForm()
        {
            InitializeComponent();
            CloseForm = new CloseFormDelegate(() =>
            {
                this.Close();
            });
        }

        public void SetValue(int value)
        {
            uiProcessBar1.InvokeProgressValue(value);
        }

        public delegate void CloseFormDelegate();
        public CloseFormDelegate CloseForm;

        public string FileName { get; internal set; }

        public void Download(string method, string url, Dictionary<string, string> parms)
        {
            Thread thread = new Thread(() =>
            {
                try
                {
                    if (string.IsNullOrEmpty(url))
                    {
                        throw new ArgumentNullException("url");
                    }
                    HttpWebRequest request = null;
                    //如果是发送HTTPS请求  
                    if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                    {
                        ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback((sender, certificate, chain, errors) => { return true; });
                        request = WebRequest.Create(url) as HttpWebRequest;
                        request.ProtocolVersion = HttpVersion.Version10;
                    }
                    else
                    {
                        request = WebRequest.Create(url) as HttpWebRequest;
                    }

                    //request.CookieContainer = m_Cookie;
                    request.Method = method;
                    request.ContentType = "application/x-www-form-urlencoded";

                    request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
                    // 设置参数

                    //如果需要POST数据  
                    if (!(parms == null || parms.Count == 0))
                    {
                        StringBuilder buffer = new StringBuilder();
                        int i = 0;
                        foreach (string key in parms.Keys)
                        {
                            if (i > 0)
                            {
                                buffer.AppendFormat("&{0}={1}", key, parms[key]);
                            }
                            else
                            {
                                buffer.AppendFormat("{0}={1}", key, parms[key]);
                            }
                            i++;
                        }
                        byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());
                        using (Stream stream1 = request.GetRequestStream())
                        {
                            stream1.Write(data, 0, data.Length);
                        }
                    }
                    //发送请求并获取相应回应数据
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    //直到request.GetResponse()程序才开始向目标网页发送Post请求
                    Stream responseStream = response.GetResponseStream();

                    long totalLenght = response.ContentLength;
                    //StartHandler?.Invoke(this, totalLenght);

                    long current = 0;
                    //创建写入流
                    FileStream pFileStream = new FileStream(FileName, FileMode.OpenOrCreate);
                    byte[] bArr = new byte[10240];
                    int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                    while (size > 0)
                    {
                        current += size;
                        uiProcessBar1.InvokeProgressValue((int)((current * 1.0 / totalLenght) * 100));
                        pFileStream.Write(bArr, 0, size);
                        size = responseStream.Read(bArr, 0, (int)bArr.Length);
                    }
                    responseStream.Close();
                    pFileStream.Close();
                    this.Invoke(CloseForm, null);
                    EndHandler?.Invoke(this);
                }
                catch (Exception ex)
                {
                    this.Invoke(CloseForm, null);
                    ErrorHandler?.Invoke(this, ex);
                }
            });
            thread.Start();
        }
    }
}
