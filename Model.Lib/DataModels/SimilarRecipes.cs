using Newtonsoft.Json;
using System;

namespace Model.Lib.DataModels
{


    public partial record SimilarRecipes
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("readyInMinutes")]
        public long ReadyInMinutes { get; set; }

        [JsonProperty("servings")]
        public long Servings { get; set; }

        [JsonProperty("sourceUrl")]
        public Uri SourceUrl { get; set; }
    }


}


