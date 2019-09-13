using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using System.Collections.Generic;

namespace SimpleApiReturnTenisPlaysStats.Models.Contracts
{
    public interface ITenisPlayerObject
    {
        List<TenisPlayer> TenisPlayers { get; set; }
    }
}
