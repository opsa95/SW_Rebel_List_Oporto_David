using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SW_Rebel_List_Oporto_David
{
    [DataContract]
    public class RebelInfo
    {

        [DataMember]
        public string RebelName { get; set; }

        [DataMember]
        public string RebelPlanet { get; set; }

    }
}