using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GoSportsApplication.Controller
{
    [DataContract]
    public class TeamController
    {
        [DataMember]
        public string teamName { get; set; }

        [DataMember]
        public List<PlayerController> player { get; set; }

        [DataMember]
        public List<InningsController> innings { get; set; }
    }
}
