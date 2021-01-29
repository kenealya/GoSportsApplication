using System.Runtime.Serialization;

namespace CricketDomain.Domains
{
    [DataContract]
    public class PlayerDomain
    {
        [DataMember]
        public string playerName { get; set; }

        [DataMember]
        public int runScored { get; set; }

        [DataMember]
        public int oversBowled { get; set; }

        [DataMember]
        public int wicketsTaken { get; set; }
    }
}
