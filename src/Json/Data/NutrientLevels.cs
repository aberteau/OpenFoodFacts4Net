using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenFoodFacts4Net.Json.Data
{
    public class NutrientLevels
    {
        [JsonProperty("fat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrientLevel Fat { get; set; }

        [JsonProperty("salt")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrientLevel Salt { get; set; }

        [JsonProperty("saturated-fat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrientLevel SaturatedFat { get; set; }

        [JsonProperty("sugars")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrientLevel Sugars { get; set; }
    }
}