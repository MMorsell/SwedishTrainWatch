using System;
using System.Threading.Tasks;
using TrainWatch.Models.SJApiResponses;

namespace TrainWatch.Interfaces
{
    public interface ISJApiService
    {
        Task<System.Collections.Generic.List<SJStationInfoModel>> GetAllTrainStationInformations();

        Task<SJTrainStationResponseModel> GetResponsByTrainStation(DateTime date, string stationCode);
    }
}