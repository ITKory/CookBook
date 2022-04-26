
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model.Lib.DataModels
{


    public partial class RandomRecipes
    {
        [JsonProperty("recipes")]
        public List<FullRecipeInformation> Recipes { get; set; }

        [JsonProperty("results")]
        public List<FullRecipeInformation> Results { get; set; }
    }


    public partial class AnalyzedInstruction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("steps")]
        public List<Step> Steps { get; set; }
    }

    public partial class Step
    {
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("step")]
        public string StepStep { get; set; }

        [JsonProperty("ingredients")]
        public List<Ent> Ingredients { get; set; }

        [JsonProperty("equipment")]
        public List<Ent> Equipment { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public Length Length { get; set; }
    }

    public partial class Ent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
        public Length Temperature { get; set; }
    }

    public partial class Length
    {
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }







}
