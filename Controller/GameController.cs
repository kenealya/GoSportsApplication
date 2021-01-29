using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GoSportsApplication.Controller
{
    [DataContract]
    public class GameController
    {
        [DataMember]
        public string gameName { get; set; }

        [DataMember]
        public List<TeamController> team { get; set; }

        [DataMember]
        public int cricketOver { get; set; }

        [DataMember]
        public int runs { get; set; }

        [DataMember]
        public int wickets { get; set; }
    }
}
