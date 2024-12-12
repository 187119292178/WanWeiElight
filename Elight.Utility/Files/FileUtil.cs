using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;
using Elight.Utility.Core;
using Elight.Utility.Other;
using System.Linq;
using System.Net.Security;

using System.Net;
using FluentFTP.Rules;


#if !NETFRAMEWORK
using Microsoft.AspNetCore.Http;
#endif
namespace Elight.Utility.Files
{
    /// <summary>
    /// 文件操作辅助类。
    /// </summary>
    public class FileUtil
    {


        private string username = "ftpuser";
        private string password = "Test123456";
        private string serverUrl = "ftp://47.107.77.75"; // 替换为你的服务器地址


#if !NETFRAMEWORK
        public static void Save(IFormFile file, string filePath)
        {
            long size = 0;
            size += file.Length;
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
        }
#endif
        #region Stream、byte[] 和 文件之间的转换

        /// <summary>
        /// 将流读取到缓冲区中
        /// </summary>
        /// <param name="stream">原始流</param>
        public static byte[] StreamToBytes(Stream stream)
        {
            try
            {
                //创建缓冲区
                byte[] buffer = new byte[stream.Length];

                //读取流
                stream.Read(buffer, 0, Convert.ToInt32(stream.Length));

                //返回流
                return buffer;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            finally
            {
                //关闭流
                stream.Close();
            }
        }

        /// <summary>
        /// 将 byte[] 转成 Stream
        /// </summary>
        public static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        /// <summary>
        /// 将 Stream 写入文件
        /// </summary>
        public static void StreamToFile(Stream stream, string fileName)
        {
            // 把 Stream 转换成 byte[]
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);
            // 把 byte[] 写入文件
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bytes);
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// 从文件读取 Stream
        /// </summary>
        public static Stream FileToStream(string fileName)
        {
            // 打开文件
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            // 读取文件的 byte[]
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();
            // 把 byte[] 转换成 Stream
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        /// <summary>
        /// 将文件读取到缓冲区中
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static byte[] FileToBytes(string filePath)
        {
            //获取文件的大小
            int fileSize = GetSize(filePath);

            //创建一个临时缓冲区
            byte[] buffer = new byte[fileSize];

            //创建一个文件流
            FileInfo fi = new FileInfo(filePath);
            FileStream fs = fi.Open(FileMode.Open);

            try
            {
                //将文件流读入缓冲区
                fs.Read(buffer, 0, fileSize);

                return buffer;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            finally
            {
                //关闭文件流
                fs.Close();
            }
        }

        /// <summary>
        /// 将文本文件读取到字符串中。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static string FileToString(string filePath)
        {
            return FileToString(filePath, Encoding.Default);
        }

        /// <summary>
        /// 将文本文件读取到字符串中。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        /// <param name="encoding">字符编码</param>
        public static string FileToString(string filePath, Encoding encoding)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 从嵌入资源中读取文件内容(e.g: xml).
        /// </summary>
        /// <param name="fileWholeName">嵌入资源文件名，包括项目的命名空间.</param>
        /// <returns>资源中的文件内容.</returns>
        public static string ReadFileFromEmbedded(string fileWholeName)
        {
            string result = string.Empty;

            using (TextReader reader = new StreamReader(
                Assembly.GetExecutingAssembly().GetManifestResourceStream(fileWholeName)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        #endregion

        #region 获取文件的编码类型

        /// <summary>
        /// 获取文件编码。
        /// </summary>
        /// <param name="filePath">文件绝对路径</param>
        /// <returns></returns>
        public static Encoding GetEncoding(string filePath)
        {
            return GetEncoding(filePath, Encoding.Default);
        }

        /// <summary>
        /// 获取文件编码。
        /// </summary>
        /// <param name="filePath">文件绝对路径</param>
        /// <param name="defaultEncoding">找不到则返回这个默认编码</param>
        /// <returns></returns>
        public static Encoding GetEncoding(string filePath, Encoding defaultEncoding)
        {
            Encoding targetEncoding = defaultEncoding;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4))
            {
                if (fs != null && fs.Length >= 2)
                {
                    long pos = fs.Position;
                    fs.Position = 0;
                    int[] buffer = new int[4];
                    buffer[0] = fs.ReadByte();
                    buffer[1] = fs.ReadByte();
                    buffer[2] = fs.ReadByte();
                    buffer[3] = fs.ReadByte();

                    fs.Position = pos;

                    if (buffer[0] == 0xFE && buffer[1] == 0xFF)//UnicodeBe
                    {
                        targetEncoding = Encoding.BigEndianUnicode;
                    }
                    if (buffer[0] == 0xFF && buffer[1] == 0xFE)//Unicode
                    {
                        targetEncoding = Encoding.Unicode;
                    }
                    if (buffer[0] == 0xEF && buffer[1] == 0xBB && buffer[2] == 0xBF)//UTF8
                    {
                        targetEncoding = Encoding.UTF8;
                    }
                }
            }

            return targetEncoding;
        }

        #endregion

        #region 文件操作

        #region 获取一个文件的长度
        /// <summary>
        /// 获取一个文件的长度,单位为Byte。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static int GetSize(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            return (int)file.Length;
        }

        /// <summary>
        /// 获取一个文件的长度,单位为KB。
        /// </summary>
        /// <param name="filePath">文件的路径</param>
        public static double GetSizeKB(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            return ConvertHelper.ToDouble(Convert.ToDouble(file.Length) / 1024, 1);
        }

        /// <summary>
        /// 获取一个文件的长度,单位为MB。
        /// </summary>
        /// <param name="filePath">文件的路径</param>
        public static double GetSizeMB(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            return ConvertHelper.ToDouble(Convert.ToDouble(file.Length) / 1024 / 1024, 1);
        }
        #endregion

        /// <summary>
        /// 向文本文件中写入内容。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        /// <param name="content">写入的内容</param>
        public static void WriteText(string filePath, string content)
        {
            File.WriteAllText(filePath, content, Encoding.Default);
        }

        /// <summary>
        /// 向文本文件的尾部追加内容。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        /// <param name="content">写入的内容</param>
        public static void AppendText(string filePath, string content)
        {
            File.AppendAllText(filePath, content, Encoding.Default);
        }

        /// <summary>
        /// 将源文件的内容复制到目标文件中。
        /// </summary>
        /// <param name="sourceFilePath">源文件的绝对路径</param>
        /// <param name="destFilePath">目标文件的绝对路径</param>
        public static void Copy(string sourceFilePath, string destFilePath)
        {
            File.Copy(sourceFilePath, destFilePath, true);
        }

        /// <summary>
        /// 将文件移动到指定目录。
        /// </summary>
        /// <param name="sourceFilePath">需要移动的源文件的绝对路径</param>
        /// <param name="descDirectoryPath">移动到的目录的绝对路径</param>
        public static void Move(string sourceFilePath, string descDirectoryPath)
        {
            //获取源文件的名称
            string sourceFileName = GetFileName(sourceFilePath);

            if (Directory.Exists(descDirectoryPath))
            {
                //如果目标中存在同名文件,则删除
                if (Exists(descDirectoryPath + "\\" + sourceFileName))
                {
                    Delete(descDirectoryPath + "\\" + sourceFileName);
                }
                //将文件移动到指定目录
                File.Move(sourceFilePath, descDirectoryPath + "\\" + sourceFileName);
            }
        }

        /// <summary>
        /// 检测指定文件是否存在,如果存在则返回true。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static bool Exists(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// 创建一个文件。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static void Create(string filePath)
        {
            try
            {
                //如果文件不存在则创建该文件
                if (!Exists(filePath))
                {
                    File.Create(filePath);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 创建一个文件,并将字节流写入文件。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        /// <param name="buffer">二进制流数据</param>
        public static void Create(string filePath, byte[] buffer)
        {
            try
            {
                //如果文件不存在则创建该文件
                if (!Exists(filePath))
                {
                    //创建文件
                    using (FileStream fs = File.Create(filePath))
                    {
                        //写入二进制流
                        fs.Write(buffer, 0, buffer.Length);

                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取文本文件的行数。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static int GetLineCount(string filePath)
        {
            //将文本文件的各行读到一个字符串数组中
            string[] rows = File.ReadAllLines(filePath);

            //返回行数
            return rows.Length;
        }

        /// <summary>
        /// 从文件的绝对路径中获取扩展名。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static string GetExtension(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            return fi.Extension;
        }

        /// <summary>
        /// 清空文件内容。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static void Clear(string filePath)
        {
            File.Delete(filePath);
            Create(filePath);
        }

        /// <summary>
        /// 删除指定文件。
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static void Delete(string filePath)
        {
            if (Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// 文件是否只读。
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public static bool IsReadOnly(string fullpath)
        {
            FileInfo file = new FileInfo(fullpath);
            if ((file.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 设置文件是否只读。
        /// </summary>
        /// <param name="fullpath"></param>
        /// <param name="flag">true表示只读，反之</param>
        public static void SetFileReadonly(string fullpath, bool flag)
        {
            FileInfo file = new FileInfo(fullpath);

            if (flag)
            {
                // 添加只读属性
                file.Attributes |= FileAttributes.ReadOnly;
            }
            else
            {
                // 移除只读属性
                file.Attributes &= ~FileAttributes.ReadOnly;
            }
        }

        /// <summary>
        /// 取文件名。
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public static string GetFileName(string fullpath, bool removeExt = false)
        {
            FileInfo fi = new FileInfo(fullpath);
            string name = fi.Name;
            if (removeExt)
            {
                name = name.Remove(name.IndexOf('.'));
            }
            return name;
        }

        /// <summary>
        /// 取文件创建时间。
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public static DateTime GetFileCreateTime(string fullpath)
        {
            FileInfo fi = new FileInfo(fullpath);
            return fi.CreationTime;
        }

        /// <summary>
        /// 取文件最后存储时间。
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public static DateTime GetLastWriteTime(string fullpath)
        {
            FileInfo fi = new FileInfo(fullpath);
            return fi.LastWriteTime;
        }

        /// <summary>
        /// 创建一个零字节临时文件。
        /// </summary>
        /// <returns></returns>
        public static string CreateTempZeroByteFile()
        {
            return Path.GetTempFileName();
        }

        /// <summary>
        /// 创建一个随机文件名，不创建文件本身。
        /// </summary>
        /// <returns></returns>
        public static string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        /// <summary>
        /// 判断两个文件的哈希值是否一致。
        /// </summary>
        /// <param name="fileName1"></param>
        /// <param name="fileName2"></param>
        /// <returns></returns>
        public static bool CompareFilesHash(string fileName1, string fileName2)
        {
            using (HashAlgorithm hashAlg = HashAlgorithm.Create())
            {
                using (FileStream fs1 = new FileStream(fileName1, FileMode.Open), fs2 = new FileStream(fileName2, FileMode.Open))
                {
                    byte[] hashBytes1 = hashAlg.ComputeHash(fs1);
                    byte[] hashBytes2 = hashAlg.ComputeHash(fs2);
                    return (BitConverter.ToString(hashBytes1) == BitConverter.ToString(hashBytes2));
                }
            }
        }

        #endregion

        public static string Base64ToFile(string filePath, string ext, string strBase64)
        {
            strBase64 = "eyJlcnJjb2RlIjo0MTAAPPwiZXJybXNnIjoiYWNjZXNzX3Rva2VuIG1pc3NpbmcgaGludDogW1JScGREQTA4ODl2cjI5IV0ifQ==";
            ext = "amr";
            byte[] contents = Convert.FromBase64String(strBase64);
            string fileName = DateTime.Today.ToString("yyyyMMdd") + UUID.StrSnowId + "." + ext;
            filePath = filePath.Replace("\\", "/");
            if (!filePath.EndsWith("/"))
                filePath += "/";
            string saveFileName = filePath + fileName;
            using (var fs = new FileStream(saveFileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(contents, 0, contents.Length);
                fs.Flush();
            }
            return fileName;
        }

        public static long DateTimeToTimestamp(DateTime datetime)
        {
            DateTime dd = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime timeUTC = DateTime.SpecifyKind(datetime, DateTimeKind.Utc);//本地时间转成UTC时间
            TimeSpan ts = (timeUTC - dd);
            return (Int64)ts.TotalMilliseconds;//精确到毫秒
        }

        public void UploadFile( string filePath,  ref string msg, ref string RemoteName)
        {
            try
            {
                msg = "";
                FileInfo fileInfo = new FileInfo(filePath);
                DateTime dateTime = DateTime.Now;
                long timelong = DateTimeToTimestamp(dateTime);

                string uploadUrl = serverUrl + "/" + (timelong + fileInfo.Name);
                RemoteName = timelong + fileInfo.Name;
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
                    msg = "OK";
                    Console.WriteLine("Upload status: " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                msg = "NG";

                Console.WriteLine("Error uploading file: " + ex.Message);
            }
        }


        public void DownloadFile( string savePath, string username , string password , string serverUrl,  ref string msg)
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
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUrl);
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
                    string[] sArray = feilname.Split(new char[] {'\\'});
                    sArray.Count();
                    int let = 0;
                    if (sArray.Count() > 1)
                    {
                        let = sArray.Count() - 1;

                    }
                    String result = sArray[let];
                    Console.WriteLine("File Size: " + contentLength);

                    string sLocationPath = savePath + result;
                    using (Stream responseStream = response.GetResponseStream())
                    using (FileStream fs = new FileStream(sLocationPath, FileMode.Create, FileAccess.Write))
                    {
                        responseStream.CopyTo(fs); // 下载文件
                    }
                    //   System.Diagnostics.Process process = System.Diagnostics.Process.Start(sLocationPath);

                }
                msg = "OK";
                Console.WriteLine("Download complete.");
            }
            catch (NotSupportedException ex)
            {
                msg = "NG";

                Console.WriteLine("Error downloading file: " + ex.Message);
            }
            catch (Exception ex)
            {
                msg = "NG";

                Console.WriteLine("Error: " + ex.Message);

            }
        }

        /// <summary>
        /// 从服务器下载模板文件
        /// </summary>
        /// <param name="hostUrl">服务器地址</param>
        /// <param name="remoteName">服务器端模板文件</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="msg">返回内容</param>
        /// <returns></returns>
        //public int DownLoadFile(string hostUrl, string remoteName, string username, string password, ref string msg)
        //{
        //    int retn = 1;
        //    string filePaths = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + remoteName;
        //    FileInfo fileInfo = new FileInfo(filePaths);
        //    string savePath = "";
        //    if (fileInfo.Exists)
        //    {

        //    }
        //    else
        //    {
        //        savePath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\";
        //        string ftpUrl = hostUrl + "/" + remoteName;
        //        DownloadFile(savePath, username, password, ftpUrl, ref msg);
        //    }

        //    return retn;
        //}

        public int DownloadFile(DateTime modifyTime ,string remoteName , string username, string password, string hostURL) 
        {
            int retn = 1;
            string filePaths = AppDomain.CurrentDomain.BaseDirectory + @"Lab\" + remoteName;
            FileInfo fileInfo = new FileInfo(filePaths);

            if (fileInfo.Exists)
            {
                DateTime fileInfocreationTime = fileInfo.CreationTime;
                DateTime creationTime = modifyTime;
                //本地文件小于更新时间
                if (creationTime > fileInfocreationTime)
                {

                    string msg = "";
                    string savePath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\";
                    string ftpUrl = hostURL + "/" + remoteName;
                    DownloadFile(savePath, username, password, ftpUrl, ref msg);
                    if (msg.Equals("NG"))
                    {
                        retn = -1;
                        return retn;
                    }
                }

            }
            else
            {
                string msg = "";
                string savePath = AppDomain.CurrentDomain.BaseDirectory + @"Lab\";
                string ftpUrl = hostURL + "/" + remoteName;
                DownloadFile(savePath, username, password, ftpUrl, ref msg);
                if (msg.Equals("NG"))
                {
                    retn = -1;
                    return retn;
                }
            }
            return 1;

        }
    }
}
