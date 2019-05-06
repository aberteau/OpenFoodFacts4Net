using System;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.Json.Data
{
    public class GetProductResponse
    {
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("status")]
        public Int32 Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status_verbose")]
        public string StatusVerbose { get; set; }
    }
}
