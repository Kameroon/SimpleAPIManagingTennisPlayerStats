using Newtonsoft.Json;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApiReturnTenisPlaysStats.Repository.Moqs
{
    public class TenisPlaysStatsRepositoryMock : ITenisPlaysStatsRepository
    {

        string filePath = "tenisPlayer.json";
        public TenisPlayerObject _mokTenisPlayers = null;

        public TenisPlaysStatsRepositoryMock()
        {
            Initialize();
        }

        private void Initialize()
        {
            string json = @"C:\Users\Sweet Family\source\repos\SimpleApiReturnTenisPlaysStats\SimpleApiReturnTenisPlaysStats.UnitTests\tenisPlayer.json";

            using (WebClient proxy = new WebClient())
            {
                string jsonFile = proxy.DownloadString(json);

                _mokTenisPlayers = JsonConvert.DeserializeObject<TenisPlayerObject>(jsonFile);
            }
        }

        public void Delete(int id)
        {
            var tenisPlayer = _mokTenisPlayers.TenisPlayers.Where(
                    tenis => tenis.Id == id
                ).FirstOrDefault();

            if (tenisPlayer != null)
            {
                _mokTenisPlayers.TenisPlayers.Remove(tenisPlayer);
            }
        }

        public TenisPlayer GetPlayerById(string stringId)
        {
            int id = int.Parse(stringId);

            var teniPlayer = _mokTenisPlayers.TenisPlayers.Where(
                    tenis => tenis.Id == id
                ).FirstOrDefault();

            if (teniPlayer != null)
            {
                return teniPlayer;
            }

            throw new WebFaultException<string>("Une erreur s'est produite",
                HttpStatusCode.BadRequest);
        }

        public IEnumerable<TenisPlayer> GetPlayers()
        {
            return _mokTenisPlayers.TenisPlayers;
        }
    }
}
