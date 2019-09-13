using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using SimpleApiReturnTenisPlaysStats.Repository.Implementations;

namespace SimpleApiReturnTenisPlaysStats
{
    public class TenisPlaysStatsService : ITenisPlayerStatsService
    {
        private ITenisPlaysStatsRepository _tenisPlaysStatsRepository;

        public TenisPlaysStatsService()
        {
            _tenisPlaysStatsRepository = new TenisPlaysStatsRepository();
        }
               

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
    }
}
