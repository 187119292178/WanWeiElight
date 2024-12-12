using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Elight.WinForm.Common
{
    public class FileHelper
    {

        public static void DownloadFile(string URL, string filename)
        {
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    so.Write(by, 0, osize);
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
            }
            catch (System.Exception ex)
            {

                string ss = ex.Message;
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public static bool DownloadFile(string URL, string filename, ref string sMsg)
        {
            bool bResult = true;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    so.Write(by, 0, osize);
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
                bResult = true;
            }
            catch (System.Exception ex)
            {
                bResult = false;
                sMsg = ex.Message;
                throw;
            }

            return bResult;
        }


        public static void UploadFile(string ftpUrl, string filePath, string username, string password)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string uploadUrl = ftpUrl + "/" + fileInfo.Name;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UseBinary = true;
                request.UsePassive = false;
                request.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
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
                    Console.WriteLine("Upload status: " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error uploading file: " + ex.Message);
            }
        }

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }


        public static void DownloadFile(string ftpUrl, string savePath, string username, string password)
        {


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
                request.UseBinary = true; // 以二进制方式下载
                request.UsePassive = true; // 使用被动模式
                request.EnableSsl = false; // 如果不需要SSL，可以关闭

                // 获取响应
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // 检查文件的大小
                    long contentLength = response.ContentLength; // 获取文件大小
                    string feilname = response.ResponseUri.LocalPath.ToString();
                    String result = feilname.Substring(4);
                    Console.WriteLine("File Size: " + contentLength);

                    string sLocationPath = savePath + result;
                    using (Stream responseStream = response.GetResponseStream())
                    using (FileStream fs = new FileStream(sLocationPath, FileMode.Create, FileAccess.Write))
                    {
                        responseStream.CopyTo(fs); // 下载文件
                    }
                    System.Diagnostics.Process process = System.Diagnostics.Process.Start(sLocationPath);

                }

                Console.WriteLine("Download complete.");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Error downloading file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }


    }
}
