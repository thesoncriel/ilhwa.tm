using System;
using System.Text;
using System.IO;

namespace Theson.Util
{
    public class TextLogger
    {
        private String _logPath = "";
        public String LogFilePath
        {
            get { return _logPath; }
            set { 
            	_logPath = CheckFilePath(value);
            }
        }

        public TextLogger(String logPath) { LogFilePath = CheckFilePath(logPath); }
        public TextLogger() { LogFilePath = Environment.CurrentDirectory + "\\log.txt"; }

        public void WriteLog(String msg)
        {
            StreamWriter sw = File.AppendText(_logPath);
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "\t" + msg);
            sw.Close();
        }

        public String ConvertToHexa(String data)
        {
            char[] arrData = data.ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (char c in arrData)
            {
                sb.Append(String.Format("[{0:X}]", (int)c));
            }

            return sb.ToString();
        }
        public String ConvertToHexa(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte b in data)
            {
                sb.Append(String.Format("[{0:X}]", (int)b));
            }

            return sb.ToString();
        }
        
        public String CheckFilePath(String filePath)
        {
            String[] asTmp = filePath.Split('\\');

            // 파일 경로에 루트(ex c:\, d:\)가 존재 할 시 있는 그대로 반환.
            if ((asTmp.Length > 1) &&
                (filePath.Contains(":\\") == true))
            {
                return filePath;
            }
            // 파일 경로에 루트가 없고 파일명만 있거나 그와 함께 부모 폴더명이 여럿 존재 할 때
            else if (asTmp.Length >= 1)
            {
                return Environment.CurrentDirectory + "\\" + filePath;
            }

            throw new IOException("올바른 파일 경로가 아닙니다.\r\n위치:AbsEmbededDB.CheckFilePath(...)\r\n값:" + filePath);
        }
    }
}
