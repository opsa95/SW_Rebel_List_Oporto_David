using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RebelService.Application
{
    public class FileManager
    {
        string fileName = "C:/applogs/output.txt";

        public bool createFile()
        {
            try
            {
                FileStream fs = null;
                if (!File.Exists(fileName))
                {
                    Directory.CreateDirectory("C:/applogs");
                    using (fs = File.Create(fileName))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Logger.Log.Error("An error occurred: '{0}'", e);
                return false;
            }

        }

        public bool writeFile(string result)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamWriter sw = new StreamWriter(fileName, true)) 
                    {
                        sw.Write(result + Environment.NewLine);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Logger.Log.Error("An error occurred: '{0}'", e);
                return false;
            }           

        }

    }
}