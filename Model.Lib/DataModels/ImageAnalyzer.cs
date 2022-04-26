using Newtonsoft.Json;

namespace Model.Lib.DataModels
{
    public class ImageAnalyzer
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }
    }
}
