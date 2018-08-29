using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SW_Rebel_List_Oporto_David
{
    public class RebelListService : IRebelListService
    {
        public bool GetRebelInfo(RebelInfo rebelInfo)
        {
            RebelService.Application.RebelService rebelService = new RebelService.Application.RebelService();
            RebelService.Application.RebelInfoService rebelInfoService = new RebelService.Application.RebelInfoService();
            rebelInfoService.RebelName = rebelInfo.RebelName;
            rebelInfoService.RebelPlanet = rebelInfo.RebelPlanet;
            var result = rebelService.GetRebelInfo(rebelInfoService);
            return result;
        }
    }
}
