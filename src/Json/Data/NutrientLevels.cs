using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenFoodFacts4Net.Json.Data
{
    public class NutrientLevels
    {
        [JsonProperty("salt")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrimentLevel Salt { get; set; }

        [JsonProperty("fat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrimentLevel Fat { get; set; }

        [JsonProperty("sugars")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrimentLevel Sugars { get; set; }

        [JsonProperty("saturated-fat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NutrimentLevel SaturatedFat { get; set; }
    }
}