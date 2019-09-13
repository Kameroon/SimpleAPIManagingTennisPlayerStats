
using SimpleApiReturnTenisPlaysStats.Models.Contracts;
using System.Runtime.Serialization;

namespace SimpleApiReturnTenisPlaysStats.Models.Implementations
{
    [DataContract]
    public class Country : ICountry
    {
        [DataMember]
        public string Picture { get; set; }
        [DataMember]
        public string Code { get; set; }
    }
}
