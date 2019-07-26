using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenFoodFacts4Net.Taxonomy.Json.Data;

namespace OpenFoodFacts4Net.Taxonomy.Json
{
    public class TaxonomySerializer
    {
        public static IDictionary<String, Taxon> Deserialize(String json)
        {
            IDictionary<String, Taxon> taxonomyData = JsonConvert.DeserializeObject<IDictionary<String, Taxon>>(json);
            return taxonomyData;
        }
    }
}
