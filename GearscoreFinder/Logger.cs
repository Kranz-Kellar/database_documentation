using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class Logger
    {
        static private string logFileName = "log.txt";

        static public void Log(LogStatus status, string msg)
        {
            File.AppendAllText(logFileName, $"{GetFormattedLogStatusString(status)} [{msg}]{Environment.NewLine}");
        }

        static private string GetFormattedLogStatusString(LogStatus status)
        {
            return $"[{status.ToString()}]";
        }
        
        static public void SetLogFileName(string newName)
        {
            logFileName = newName;
        }

        

    }

    public enum LogStatus
    {
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        CRITICAL
    }
}
