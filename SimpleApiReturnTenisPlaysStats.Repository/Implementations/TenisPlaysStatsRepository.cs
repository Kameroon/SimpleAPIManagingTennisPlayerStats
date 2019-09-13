using Newtonsoft.Json;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace SimpleApiReturnTenisPlaysStats.Repository.Implementations
{
    public class TenisPlaysStatsRepository : ITenisPlaysStatsRepository
    {
        private TenisPlayerObject _tenisPlayerObject;

        public TenisPlaysStatsRepository()
        {
            GetTenisPlayes();
        }

        private TenisPlayerObject GetTenisPlayes()
        {   
            string jsonFileURL = @"https://eurosportdigital.github.io/eurosport-csharp-developer-recruitment/headtohead.json";

            using (WebClient proxy = new WebClient())
            {
                string jsonFile = proxy.DownloadString(jsonFileURL);

                _tenisPlayerObject = JsonConvert.DeserializeObject<TenisPlayerObject>(jsonFile);               
            }

            return _tenisPlayerObject;
        }

        public void Delete(int id)
        {
            var teniPlayer = _tenisPlayerObject.TenisPlayers.Where(
                    tenis => tenis.Id == id
                ).FirstOrDefault();

            if (teniPlayer != null)
            {
                _tenisPlayerObject.TenisPlayers.Remove(teniPlayer);
            }
        }

        public TenisPlayer GetPlayerById(string id)
        {
            int realId = Convert.ToInt32(id);

            var teniPlayer = _tenisPlayerObject.TenisPlayers.Where(
                    tenis => tenis.Id == realId
                ).FirstOrDefault();

            if (teniPlayer != null)
            {
                return teniPlayer;
            }

            return null;
        }

        public IEnumerable<TenisPlayer> GetPlayers()
        {
            return _tenisPlayerObject.TenisPlayers;
        }
    }
}
