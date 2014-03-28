using Common.Logging;
using PFSheet.Utility.PostsharpAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.Utility.Logger
{
    [LogMethodInOutAttribute(AttributeExclude = true)]
    public class PFLogger : IPFLogger
    {
        private readonly ILog Log = LogManager.GetLogger("PFLogger");

        //public static bool UseNoErrorCacheing = false;
        //public static int CacheSize = 20;
        //private static List<string> LoggerCache = new List<string>();

        private static void PushToCache(string message)
        {
            //LoggerCache.Add(message);
            //if (LoggerCache.Count > CacheSize)
            //{
            //    LoggerCache.RemoveAt(0);
            //}
        }

        public void Debug(string message)
        {
            Log.Debug(message);
        }

        public void Info(string message)
        {
            Log.Info(message);
        }

        public void Warning(string message)
        {
            Log.Warn(message);
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Error(Exception ex)
        {
            Log.Error(ex);
        }

        public void Error(string message, Exception ex)
        {
            Log.Error(message, ex);
        }
    }
}
