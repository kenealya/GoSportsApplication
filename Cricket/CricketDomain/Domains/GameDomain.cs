using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CricketDomain.Domains
{
    [DataContract]
    public class GameDomain
    {
        [DataMember]
        public string gameName { get; set; }

        [DataMember]
        public List<TeamDomain> team { get; set; }

        [DataMember]
        public int cricketOver { get; set; }

        [DataMember]
        public int runs { get; set; }

        [DataMember]
        public int wickets { get; set; }
    }
}
