using Newtonsoft.Json;


namespace Model.Lib.DataModels
{


    public partial class QuickSearch
    {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }


    }



}
