using System.Runtime.Serialization;

namespace GoSportsApplication.Controller
{
    [DataContract]
    public class PlayerController
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
