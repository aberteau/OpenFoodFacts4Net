using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using OpenFoodFacts4Net.ApiClient.Converters;

namespace OpenFoodFacts4Net.ApiClient.Data
{
    public class Product
    {
        [JsonProperty("image_small_url")]
        public string ImageSmallUrl { get; set; }

        [JsonProperty("image_nutrition_url")]
        public string ImageNutritionUrl { get; set; }

        [JsonProperty("image_front_url")]
        public string ImageFrontUrl { get; set; }

        [JsonProperty("image_ingredients_url")]
        public string ImageIngredientsUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("traces_tags")]
        public IEnumerable<string> TracesTags { get; set; }

        [JsonProperty("ingredients_that_may_be_from_palm_oil_tags")]
        public IEnumerable<string> IngredientsThatMayBeFromPalmOilTags { get; set; }

        [JsonProperty("additives_tags")]
        public IEnumerable<string> AdditivesTags { get; set; }

        [JsonProperty("allergens_hierarchy")]
        public IEnumerable<string> AllergensHierarchy { get; set; }

        [JsonProperty("manufacturing_places")]
        public string ManufacturingPlaces { get; set; }

        [JsonProperty("brands_tags")]
        public IEnumerable<string> BrandsTags { get; set; }

        [JsonProperty("categories_tags")]
        public IEnumerable<string> CategoriesTags { get; set; }

        [JsonProperty("product_name")]
        [JsonConverter(typeof(ProductStringConverter))]
        public string ProductName { get; set; }

        [JsonProperty("generic_name")]
        [JsonConverter(typeof(ProductStringConverter))]
        public string GenericName { get; set; }

        [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n")]
        public long IngredientsFromOrThatMayBeFromPalmOilN { get; set; }

        [JsonProperty("serving_size")]
        public string ServingSize { get; set; }

        [JsonProperty("last_modified_by")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("nutrition_grade_fr")]
        public string NutritionGradeFr { get; set; }

        [JsonProperty("nutrient_levels")]
        public NutrientLevels NutrientLevels { get; set; }

        [JsonProperty("countries_tags")]
        public IEnumerable<string> CountriesTags { get; set; }

        [JsonProperty("labels_hierarchy")]
        public IEnumerable<string> LabelsHierarchy { get; set; }

        [JsonProperty("labels_tags")]
        public IEnumerable<string> LabelsTags { get; set; }

        [JsonProperty("ingredients_from_palm_oil_n")]
        public long IngredientsFromPalmOilN { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("emb_codes_tags")]
        public IEnumerable<string> EmbCodesTags { get; set; }

        [JsonProperty("states_tags")]
        public IEnumerable<string> StatesTags { get; set; }

        [JsonProperty("vitamins_tags")]
        public IEnumerable<string> VitaminsTags { get; set; }

        [JsonProperty("minerals_tags")]
        public IEnumerable<string> MineralsTags { get; set; }

        [JsonProperty("amino_acids_tags")]
        public IEnumerable<string> AminoAcidsTags { get; set; }

        [JsonProperty("other_nutritional_substances_tags")]
        public IEnumerable<string> OtherNutritionalSubstancesTags { get; set; }

        [JsonProperty("created_t")]
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime CreatedDateTime { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("last_modified_t")]
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime LastModifiedTime { get; set; }

        [JsonProperty("editors_tags")]
        public IEnumerable<string> EditorsTags { get; set; }

        [JsonProperty("nova_groups")]
        public string NovaGroups { get; set; }

        [JsonProperty("environment_impact_level_tags")]
        public IEnumerable<string> EnvironmentImpactLevelTags { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("purchase_places")]
        public string PurchasePlaces { get; set; }

        [JsonProperty("nutrition_data_per")]
        public string NutritionDataPer { get; set; }

        [JsonProperty("no_nutrition_data")]
        public string NoNutritionData { get; set; }

        [JsonProperty("other_information")]
        public string OtherInformation { get; set; }

        [JsonProperty("conservation_conditions")]
        public string ConservationConditions { get; set; }

        [JsonProperty("recycling_instructions_to_discard")]
        public string RecyclingInstructionsToDiscard { get; set; }

        [JsonProperty("recycling_instructions_to_recycle")]
        public string RecyclingInstructionsToRecycle { get; set; }

        [JsonProperty("warning")]
        public string Warning { get; set; }

        [JsonProperty("customer_service")]
        public string CustomerService { get; set; }

        [JsonProperty("environment_infocard")]
        public string EnvironmentInfocard { get; set; }
    }
}
