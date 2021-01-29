using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CricketDomain.Domains
{
    [DataContract]
    public class TeamDomain
    {
        [DataMember]
        public string teamName { get; set; }

        [DataMember]
        public List<PlayerDomain> player { get; set; }

        [DataMember]
        public List<InningsDomain> innings { get; set; }
    }
}
