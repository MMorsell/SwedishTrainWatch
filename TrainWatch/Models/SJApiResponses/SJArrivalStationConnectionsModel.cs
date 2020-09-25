using System.Text.Json.Serialization;

namespace TrainWatch.Models.SJApiResponses
{
    public class SJArrivalStationConnectionsModel
    {
        [JsonPropertyName("trainNumber")]
        public string TrainNumber { get; set; }

        [JsonPropertyName("otn")]
        public string Otn { get; set; }

        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("currentTime")]
        public string CurrentTime { get; set; }

        [JsonPropertyName("originalTime")]
        public string OriginalTime { get; set; }

        [JsonPropertyName("station")]
        public string Station { get; set; }

        [JsonPropertyName("currentTrack")]
        public string CurrentTrack { get; set; }

        [JsonPropertyName("originalTrack")]
        public string OriginalTrack { get; set; }

        [JsonPropertyName("transportType")]
        public string TransportType { get; set; }

        [JsonPropertyName("hasArrived")]
        public bool HasArrived { get; set; }

        [JsonPropertyName("hasDeparted")]
        public bool HasDeparted { get; set; }

        [JsonPropertyName("awaitingTime")]
        public bool AwaitingTime { get; set; }

        [JsonPropertyName("changedTrack")]
        public bool ChangedTrack { get; set; }

        [JsonPropertyName("markDelayed")]
        public bool MarkDelayed { get; set; }

        [JsonPropertyName("delayed")]
        public bool Delayed { get; set; }

        [JsonPropertyName("cancelled")]
        public bool Cancelled { get; set; }

        //Dont really need this responses, but will leave it here for future use
        //        "remarks": [
        //            {
        //                "id": "ANA007",
        //                "level": {
        //                    "severity": 2,
        //                    "name": "WARN"
        //                },

        //                "information": "Buss ersätter"
        //            },

        //            {
        //"id": "ONA124",
        //                "level": {
        //    "severity": 0,
        //                    "name": "NONE"
        //                },
        //                "information": "Buss ers. mellan Nässjö och Vetlanda."
        //            }
        //        ],
    }
}