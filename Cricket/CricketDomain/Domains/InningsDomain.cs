using System.Runtime.Serialization;

namespace CricketDomain.Domains
{
    [DataContract]
    public class InningsDomain
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
