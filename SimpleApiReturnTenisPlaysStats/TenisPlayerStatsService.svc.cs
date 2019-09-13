using System.Collections.Generic;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using SimpleApiReturnTenisPlaysStats.Repository.Implementations;

namespace SimpleApiReturnTenisPlaysStats
{
    public class TenisPlaysStatsService : ITenisPlayerStatsService
    {
        #region -- Properties --
        private ITenisPlaysStatsRepository _tenisPlaysStatsRepository;
        #endregion

        #region -- Constructor --
        public TenisPlaysStatsService()
        {
            _tenisPlaysStatsRepository = new TenisPlaysStatsRepository();
        }
        #endregion

        #region -- Methods --
        public void Delete(int id)
        {
            _tenisPlaysStatsRepository.Delete(id);
        }

        public TenisPlayer GetPlayerById(string id)
        {
            return _tenisPlaysStatsRepository.GetPlayerById(id);           
        }

        public IEnumerable<TenisPlayer> GetPlayers()
        {            
            return _tenisPlaysStatsRepository.GetPlayers();
        }
        #endregion
    }
}
