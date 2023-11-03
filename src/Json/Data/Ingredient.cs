using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFoodFacts4Net.Json.Data
{
    public class Ingredient
    {
        [JsonProperty("ciqual_food_code")]
        public string CiqualFoodCode { get; set; }

        [JsonProperty("from_palm_oil")]
        public string FromPalmOil { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ingredients")]
        public IEnumerable<Ingredient> Ingredients { get; set; }

        [JsonProperty("percent")]
        public double? Percent { get; set; }

        [JsonProperty("percent_estimate")]
        public double? PercentEstimate { get; set; }

        [JsonProperty("percent_max")]
        public double? PercentMax { get; set; }

        [JsonProperty("percent_min")]
        public double? PercentMin { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("vegan")]
        public string Vegan { get; set; }

        [JsonProperty("vegetarian")]
        public string Vegetarian { get; set; }
    }
}
