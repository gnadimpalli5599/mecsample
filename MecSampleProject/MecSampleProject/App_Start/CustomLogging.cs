using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using log4net;

namespace MecSampleProject
{
    public static class CustomLogging
    {
        private static ILog _log = null;
        private static string _logFile = null;

        public static void Initialize(string ApplicationPath)
        {
            _logFile = Path.Combine(ApplicationPath, "App_Data", "MecSampleProject.log");
            GlobalContext.Properties["LogFileName"] = _logFile;

            log4net.Config.XmlConfigurator.Configure(new FileInfo(Path.Combine(ApplicationPath, "Log4Net.config")));

            _log = LogManager.GetLogger("MecSampleProject");
        }

        public static string LogFile
        {
            get { return _logFile; }
        }

        public enum Trace
        {
            ALL, DEBUG, INFO, WARN, ERROR, FATAL, OFF
        }

        public static void LogMessage(Trace Level, string Message)
        {
            switch (Level)
            {
                case Trace.DEBUG:
                    _log.Debug(Message);
                    break;

                case Trace.INFO:
                    _log.Info(Message);
                    break;

                case Trace.WARN:
                    _log.Warn(Message);
                    break;

                case Trace.ERROR:
                    _log.Error(Message);
                    break;

                case Trace.FATAL:
                    _log.Fatal(Message);
                    break;
            }
        }
    }
}