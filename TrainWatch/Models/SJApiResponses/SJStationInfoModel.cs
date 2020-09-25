using System.Text.Json.Serialization;

namespace TrainWatch.Models.SJApiResponses
{
    public class SJStationInfoModel
    {
        [JsonPropertyName("stationName")]
        public string StationName { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("locationCode")]
        public string LocationCode { get; set; }
    }
}