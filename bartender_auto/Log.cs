using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartenderStudy
{
	public static class Log
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">log 信息</param>
        /// <param name="path">log 路径 </param>
        /// <param name="name">log日志名称</param>
        public static void LogPrint(string message)
        {
            string sLogTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string path = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string __stringFileName = path + "/" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
                using (TextWriter logFile = TextWriter.Synchronized(File.AppendText(__stringFileName)))
                {
                   // logFile.WriteLine(DateTime.Now);
                    logFile.WriteLine(sLogTime + " \t"  +message);
                    logFile.Flush();
                    logFile.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }
    }
}
