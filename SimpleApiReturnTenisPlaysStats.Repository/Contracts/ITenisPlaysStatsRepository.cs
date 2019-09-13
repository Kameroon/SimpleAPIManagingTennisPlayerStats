
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using System.Collections.Generic;

namespace SimpleApiReturnTenisPlaysStats.Repository.Contracts
{
    public interface ITenisPlaysStatsRepository
    {

        void Delete(int id);
        TenisPlayer GetPlayerById(string id);
        IEnumerable<TenisPlayer> GetPlayers();
    }
}
