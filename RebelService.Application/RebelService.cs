using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelService.Application
{
    public class RebelService
    {        

        public bool GetRebelInfo(RebelInfoService rebelInfo)
        {
            string stringResult;
            FileManager fManager = new FileManager();
            bool boolValue = true;

            if (fManager.createFile())
                Logger.Log.Info("File created");

            try
            {

                if (string.IsNullOrEmpty(rebelInfo.RebelName) || string.IsNullOrEmpty(rebelInfo.RebelPlanet))
                {
                    throw new ArgumentException();
                }
                else
                {
                    stringResult = "Rebel " + rebelInfo.RebelName + " on " + rebelInfo.RebelPlanet + " at " +
                        DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString() + ".";
                }

                if (fManager.writeFile(stringResult))
                    Logger.Log.Info("String (" + stringResult + ") added to file.");

            }
            catch (Exception e)
            {
                Logger.Log.Error(e.ToString());
                boolValue = false;
            }

            return boolValue;
        }
    }
}
