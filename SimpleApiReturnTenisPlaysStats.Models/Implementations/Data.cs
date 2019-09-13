using SimpleApiReturnTenisPlaysStats.Models.Contracts;
using System.Runtime.Serialization;

namespace SimpleApiReturnTenisPlaysStats.Models.Implementations
{
    [DataContract]
    public class Data : IData
    {
        [DataMember]
        public int Rank { get; set; }
        [DataMember]
        public int Points { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        public int Height { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int[] Last { get; set; }
    }
}
