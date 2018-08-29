using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SW_Rebel_List_Oporto_David
{
      [ServiceContract]
      public interface IRebelListService
      {

          [OperationContract]
          bool GetRebelInfo(RebelInfo rebelInfo);

      }
      
}
