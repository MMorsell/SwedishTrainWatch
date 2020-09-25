using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using TrainWatch.Models.SJApiResponses;

namespace TrainWatch.Services
{
    public class SJApiService
    {
        private const string _trainStatiomBaseUrl = "https://api-prod.adp.sj.se/public/trafficinfo/trafficinfo/v1/rest/connections?lang=sv";

        public async Task<SJTrainStationResponseModel> GetResponsByTrainStation(DateTime date, string stationCode)
        {
            var client = new RestClient($"{_trainStatiomBaseUrl}&date={date:yyyy-MM-dd}&locationCode={stationCode}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Ocp-Apim-Subscription-Key", "4020da00baec48f09a8bc038c3990b03");
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<SJTrainStationResponseModel>(response.Content);
        }
    }
}