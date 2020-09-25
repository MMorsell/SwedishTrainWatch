using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrainWatch.Models.SJApiResponses
{
    public class SJTrainStationResponseModel
    {
        [JsonPropertyName("locationId")]
        public string LocationId { get; set; }

        [JsonPropertyName("locationName")]
        public string LocationName { get; set; }

        [JsonPropertyName("arrivalConnections")]
        public List<SJArrivalStationConnectionsModel> ArrivalConnections { get; set; }

        [JsonPropertyName("departureConnections")]
        public List<SJArrivalStationConnectionsModel> DepartureConnections { get; set; }

        //Dont really need this responses, but will leave it here for future use
        //"arrivalConnectionsUpdatedDateTime": "2020-09-25 22:37:00",
        //"departureConnectionsUpdatedDateTime": "2020-09-25 22:37:00"
    }
}