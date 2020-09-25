using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainWatch.Models.SJApiResponses;
using TrainWatch.Interfaces;

namespace TrainWatch.Services
{
    public partial class SJApiService : ISJApiService
    {
        private const string _trainStatiomTrainInfoBaseUrl = "https://api-prod.adp.sj.se/public/trafficinfo/trafficinfo/v1/rest/connections?lang=sv";
        private const string _trainStatiomBaseUrl = "https://api-prod.adp.sj.se/public/trafficinfo/trafficinfo/v1/rest/locations";
        private const string publicApiKey = "4020da00baec48f09a8bc038c3990b03"; //TODO: Check if this key needs to be updated by mocking user web request since this is an auto generated public api key that might change over time

        public async Task<SJTrainStationResponseModel> GetResponsByTrainStation(DateTime date, string stationCode)
        {
            var client = new RestClient($"{_trainStatiomTrainInfoBaseUrl}&date={date:yyyy-MM-dd}&locationCode={stationCode}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Ocp-Apim-Subscription-Key", publicApiKey);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<SJTrainStationResponseModel>(response.Content);
        }

        public async Task<List<SJStationInfoModel>> GetAllTrainStationInformations()
        {
            var client = new RestClient(_trainStatiomBaseUrl)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Ocp-Apim-Subscription-Key", publicApiKey);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<SJStationInfoModel>>(response.Content);
        }
    }
}