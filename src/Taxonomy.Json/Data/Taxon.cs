using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.Taxonomy.Json.Data
{
    public class Taxon
    {
        [JsonProperty("name")]
        public IDictionary<String, String> Name { get; set; }

        [JsonProperty("parents")]
        public IEnumerable<String> Parents { get; set; }

        [JsonProperty("children")]
        public IEnumerable<String> Children { get; set; }

        [JsonProperty("country")]
        public IDictionary<String, String> Country { get; set; }

        [JsonProperty("region")]
        public IDictionary<String, String> Region { get; set; }

        [JsonProperty("instanceof")]
        public IDictionary<String, String> InstanceOf { get; set; }

        [JsonProperty("wikidata")]
        public IDictionary<String, String> Wikidata { get; set; }
    }
}
