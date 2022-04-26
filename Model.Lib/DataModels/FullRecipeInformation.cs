using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Model.Lib.DataModels
{

    public partial record FullRecipeInformation
    {
        [JsonProperty("vegetarian")]
        public bool Vegetarian { get; set; }

        [JsonProperty("vegan")]
        public bool Vegan { get; set; }

        [JsonProperty("glutenFree")]
        public bool GlutenFree { get; set; }

        [JsonProperty("dairyFree")]
        public bool DairyFree { get; set; }

        [JsonProperty("veryHealthy")]
        public bool VeryHealthy { get; set; }

        [JsonProperty("cheap")]
        public bool Cheap { get; set; }

        [JsonProperty("veryPopular")]
        public bool VeryPopular { get; set; }

        [JsonProperty("sustainable")]
        public bool Sustainable { get; set; }

        [JsonProperty("weightWatcherSmartPoints")]
        public long WeightWatcherSmartPoints { get; set; }

        [JsonProperty("gaps")]
        public string Gaps { get; set; }

        [JsonProperty("lowFodmap")]
        public bool LowFodmap { get; set; }

        [JsonProperty("aggregateLikes")]
        public long AggregateLikes { get; set; }

        [JsonProperty("spoonacularScore")]
        public long SpoonacularScore { get; set; }

        [JsonProperty("healthScore")]
        public long HealthScore { get; set; }

        [JsonProperty("creditsText")]
        public string CreditsText { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("sourceName")]
        public string SourceName { get; set; }

        [JsonProperty("pricePerServing")]
        public double PricePerServing { get; set; }

        [JsonProperty("extendedIngredients")]
        public List<ExtendedIngredient> ExtendedIngredients { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("readyInMinutes")]
        public long ReadyInMinutes { get; set; }

        [JsonProperty("servings")]
        public long Servings { get; set; }

        [JsonProperty("sourceUrl")]
        public Uri SourceUrl { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("cuisines")]
        public List<object> Cuisines { get; set; }

        [JsonProperty("dishTypes")]
        public List<string> DishTypes { get; set; }

        [JsonProperty("diets")]
        public List<object> Diets { get; set; }

        [JsonProperty("occasions")]
        public List<object> Occasions { get; set; }

        [JsonProperty("winePairing")]
        public WinePairing WinePairing { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("analyzedInstructions")]
        public List<object> AnalyzedInstructions { get; set; }

        [JsonProperty("originalId")]
        public object OriginalId { get; set; }

        [JsonProperty("spoonacularSourceUrl")]
        public Uri SpoonacularSourceUrl { get; set; }
    }

    public partial record ExtendedIngredient
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        [JsonProperty("aisle")]
        public string Aisle { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("consistency")]
        public string Consistency { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameClean")]
        public string NameClean { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("meta")]
        public List<string> Meta { get; set; }

        [JsonProperty("measures")]
        public Measures Measures { get; set; }
    }

    public partial record Measures
    {
        [JsonProperty("us")]
        public Metric Us { get; set; }

        [JsonProperty("metric")]
        public Metric Metric { get; set; }
    }

    public partial record Metric
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unitShort")]
        public string UnitShort { get; set; }

        [JsonProperty("unitLong")]
        public string UnitLong { get; set; }
    }

    public partial record WinePairing
    {
        [JsonProperty("pairedWines")]
        public List<object> PairedWines { get; set; }

        [JsonProperty("pairingText")]
        public string PairingText { get; set; }

        [JsonProperty("productMatches")]
        public List<object> ProductMatches { get; set; }
    }





}
