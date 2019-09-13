using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SimpleApiReturnTenisPlaysStats
{
   
    [ServiceContract]
    public interface ITenisPlayerStatsService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/players",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]  // Configure le service en REST
        IEnumerable<TenisPlayer> GetPlayers();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/players/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        TenisPlayer GetPlayerById(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/players?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        void Delete(int id);
    }
}
