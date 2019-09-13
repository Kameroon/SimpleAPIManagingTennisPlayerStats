using Newtonsoft.Json;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;

namespace SimpleApiReturnTenisPlaysStats.Repository.Implementations
{
    public class TenisPlaysStatsRepository : ITenisPlaysStatsRepository
    {
        #region -- Properties --
        private TenisPlayerObject _tenisPlayerObject;
        #endregion

        #region -- Constructor --
        public TenisPlaysStatsRepository()
        {
            GetTenisPlayes();
        }
        #endregion

        #region -- Methods --
        private TenisPlayerObject GetTenisPlayes()
        {   
            string jsonFileURL = "https://eurosportdigital.github.io/eurosport-csharp-developer-recruitment/headtohead.json";

            try
            {
                using (WebClient proxy = new WebClient())
                {
                    string jsonFile = proxy.DownloadString(jsonFileURL); 

                    _tenisPlayerObject = JsonConvert.DeserializeObject<TenisPlayerObject>(jsonFile);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());

                throw new WebFaultException<string>("Une erreur s'est produite lors du chargement", 
                    HttpStatusCode.NotFound);               
            }

            return _tenisPlayerObject;
        }

        public void Delete(int id)
        {
            var tenisPlayer = _tenisPlayerObject.TenisPlayers.Where(
                    tenis => tenis.Id == id
                ).FirstOrDefault();

            if (tenisPlayer != null)
            {
                _tenisPlayerObject.TenisPlayers.Remove(tenisPlayer);
            }
        }

        public TenisPlayer GetPlayerById(string stringId)
        {
            int realId = int.Parse(stringId);

            try
            {
                var tenisPlayer = _tenisPlayerObject.TenisPlayers.Where(
                            tenis => tenis.Id == realId
                        ).FirstOrDefault();

                if (tenisPlayer != null)
                {
                    return tenisPlayer;
                }

                throw new WebFaultException<string>("Une erreur s'est produite", 
                    HttpStatusCode.NotFound);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw;
            }
        }

        public IEnumerable<TenisPlayer> GetPlayers()
        {
            return _tenisPlayerObject.TenisPlayers;
        }
        #endregion
    }
}
