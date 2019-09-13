using SimpleApiReturnTenisPlaysStats.Models.Contracts;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SimpleApiReturnTenisPlaysStats.Models.Implementations
{
    [DataContract]
    public class TenisPlayerObject : ITenisPlayerObject
    {
        [DataMember(Name = "players")]
        public List<TenisPlayer> TenisPlayers { get; set; }
    }
}
