using Newtonsoft.Json;

namespace OpenFoodFacts4Net.Json.Data
{
    public class Nutriments
    {
        [JsonProperty("alcohol")]
        public int Alcohol { get; set; }

        [JsonProperty("alcohol_100g")]
        public int Alcohol100g { get; set; }

        [JsonProperty("alcohol_serving")]
        public int AlcoholServing { get; set; }

        [JsonProperty("alcohol_unit")]
        public string AlcoholUnit { get; set; }

        [JsonProperty("alcohol_value")]
        public int AlcoholValue { get; set; }

        [JsonProperty("carbohydrates")]
        public double Carbohydrates { get; set; }

        [JsonProperty("carbohydrates_100g")]
        public double Carbohydrates100g { get; set; }

        [JsonProperty("carbohydrates_serving")]
        public double CarbohydratesServing { get; set; }

        [JsonProperty("carbohydrates_unit")]
        public string CarbohydratesUnit { get; set; }

        [JsonProperty("carbohydrates_value")]
        public double CarbohydratesValue { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_product")]
        public int CarbonFootprintFromKnownIngredientsProduct { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_serving")]
        public double CarbonFootprintFromKnownIngredientsServing { get; set; }

        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("energy-kcal")]
        public int EnergyKcal { get; set; }

        [JsonProperty("energy-kcal_100g")]
        public int EnergyKcal100g { get; set; }

        [JsonProperty("energy-kcal_serving")]
        public double EnergyKcalServing { get; set; }

        [JsonProperty("energy-kcal_unit")]
        public string EnergyKcalUnit { get; set; }

        [JsonProperty("energy-kcal_value")]
        public int EnergyKcalValue { get; set; }

        [JsonProperty("energy-kcal_value_computed")]
        public double EnergyKcalValueComputed { get; set; }

        [JsonProperty("energy-kj")]
        public int EnergyKj { get; set; }

        [JsonProperty("energy-kj_100g")]
        public int EnergyKj100g { get; set; }

        [JsonProperty("energy-kj_serving")]
        public int EnergyKjServing { get; set; }

        [JsonProperty("energy-kj_unit")]
        public string EnergyKjUnit { get; set; }

        [JsonProperty("energy-kj_value")]
        public int EnergyKjValue { get; set; }

        [JsonProperty("energy-kj_value_computed")]
        public double EnergyKjValueComputed { get; set; }

        [JsonProperty("energy_100g")]
        public int Energy100g { get; set; }

        [JsonProperty("energy_serving")]
        public int EnergyServing { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("energy_value")]
        public int EnergyValue { get; set; }

        [JsonProperty("fat")]
        public double Fat { get; set; }

        [JsonProperty("fat_100g")]
        public double Fat100g { get; set; }

        [JsonProperty("fat_serving")]
        public double FatServing { get; set; }

        [JsonProperty("fat_unit")]
        public string FatUnit { get; set; }

        [JsonProperty("fat_value")]
        public double FatValue { get; set; }

        [JsonProperty("fiber")]
        public int Fiber { get; set; }

        [JsonProperty("fiber_100g")]
        public int Fiber100g { get; set; }

        [JsonProperty("fiber_serving")]
        public int FiberServing { get; set; }

        [JsonProperty("fiber_unit")]
        public string FiberUnit { get; set; }

        [JsonProperty("fiber_value")]
        public int FiberValue { get; set; }

        [JsonProperty("fruits-vegetables-legumes-estimate-from-ingredients_100g")]
        public int FruitsVegetablesLegumesEstimateFromIngredients100g { get; set; }

        [JsonProperty("fruits-vegetables-legumes-estimate-from-ingredients_serving")]
        public int FruitsVegetablesLegumesEstimateFromIngredientsServing { get; set; }

        [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_100g")]
        public int FruitsVegetablesNutsEstimateFromIngredients100g { get; set; }

        [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_serving")]
        public int FruitsVegetablesNutsEstimateFromIngredientsServing { get; set; }

        [JsonProperty("nova-group")]
        public int NovaGroup { get; set; }

        [JsonProperty("nova-group_100g")]
        public int NovaGroup100g { get; set; }

        [JsonProperty("nova-group_serving")]
        public int NovaGroupServing { get; set; }

        [JsonProperty("nutrition-score-fr")]
        public int NutritionScoreFr { get; set; }

        [JsonProperty("nutrition-score-fr_100g")]
        public int NutritionScoreFr100g { get; set; }

        [JsonProperty("proteins")]
        public double Proteins { get; set; }

        [JsonProperty("proteins_100g")]
        public double Proteins100g { get; set; }

        [JsonProperty("proteins_serving")]
        public double ProteinsServing { get; set; }

        [JsonProperty("proteins_unit")]
        public string ProteinsUnit { get; set; }

        [JsonProperty("proteins_value")]
        public double ProteinsValue { get; set; }

        [JsonProperty("salt")]
        public double Salt { get; set; }

        [JsonProperty("salt_100g")]
        public double Salt100g { get; set; }

        [JsonProperty("salt_serving")]
        public double SaltServing { get; set; }

        [JsonProperty("salt_unit")]
        public string SaltUnit { get; set; }

        [JsonProperty("salt_value")]
        public double SaltValue { get; set; }

        [JsonProperty("saturated-fat")]
        public double SaturatedFat { get; set; }

        [JsonProperty("saturated-fat_100g")]
        public double SaturatedFat100g { get; set; }

        [JsonProperty("saturated-fat_serving")]
        public double SaturatedFatServing { get; set; }

        [JsonProperty("saturated-fat_unit")]
        public string SaturatedFatUnit { get; set; }

        [JsonProperty("saturated-fat_value")]
        public double SaturatedFatValue { get; set; }

        [JsonProperty("sodium")]
        public double Sodium { get; set; }

        [JsonProperty("sodium_100g")]
        public double Sodium100g { get; set; }

        [JsonProperty("sodium_serving")]
        public double SodiumServing { get; set; }

        [JsonProperty("sodium_unit")]
        public string SodiumUnit { get; set; }

        [JsonProperty("sodium_value")]
        public double SodiumValue { get; set; }

        [JsonProperty("sugars")]
        public double Sugars { get; set; }

        [JsonProperty("sugars_100g")]
        public double Sugars100g { get; set; }

        [JsonProperty("sugars_serving")]
        public double SugarsServing { get; set; }

        [JsonProperty("sugars_unit")]
        public string SugarsUnit { get; set; }

        [JsonProperty("sugars_value")]
        public double SugarsValue { get; set; }
    }
}
