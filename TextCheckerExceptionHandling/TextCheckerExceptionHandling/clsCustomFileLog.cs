using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCheckerExceptionHandling
{
    public static class CustomFileLog
    {
        const string _logPath = @"C:\SyntraWestTemp\Logging";

        public static void AddErrorLog(string message)
        {
            //Create directory if it does not exists
            Directory.CreateDirectory(_logPath);
            File.AppendAllText(_logPath + "/log.txt", string.Format("{0}\n{1}" + Environment.NewLine, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), message + "\n"));
        }
    }
}
