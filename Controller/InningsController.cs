using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GoSportsApplication.Controller
{
    [DataContract]
    public class InningsController
    {
        [DataMember]
        public int innings { get; set; }

        [DataMember]
        public int cricketOver { get; set; }

        [DataMember]
        public int totalRuns { get; set; }

        [DataMember]
        public int wickets { get; set; }
    }
}
