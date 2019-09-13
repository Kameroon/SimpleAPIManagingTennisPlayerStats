using SimpleApiReturnTenisPlaysStats.Models.Contracts;
using System.Runtime.Serialization;

namespace SimpleApiReturnTenisPlaysStats.Models.Implementations
{
    [DataContract]
    public class TenisPlayer : ITenisPlayer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string ShortName { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public Country Country { get; set; }
        [DataMember]
        public Data Data { get; set; }
    }
}
