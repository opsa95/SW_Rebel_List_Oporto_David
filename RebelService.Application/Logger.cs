using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelService.Application
{
    public static class Logger
    {
        public static readonly ILog Log = GetLogger("RebelService");
        public static ILog GetLogger(string applicationName)
        {

            var logger = LogManager.GetLogger(applicationName);

            var applicationPath = "C:/applogs/logs"; 
            log4net.GlobalContext.Properties["ApplicationPath"] = applicationPath;
            log4net.GlobalContext.Properties["ApplicationName"] = applicationName;
            log4net.GlobalContext.Properties["Date"] = $"{DateTime.Now:dd-MM-yyyy}";

            var log4NetConfigFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\RebelService.Application\\Config\\log4net.xml";
            var fileInfo = new FileInfo(log4NetConfigFilePath);
            XmlConfigurator.Configure(fileInfo);

            logger.Info(string.Format("Logger initialized. Config {0}, LogFilePath {1}", applicationPath, log4NetConfigFilePath));

            return logger;
        }      
    }
}
