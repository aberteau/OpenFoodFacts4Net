using System;
using System.Linq;
using FluentAssertions;
using Newtonsoft.Json;
using OpenFoodFacts4Net.Json.Data;
using Xunit;

namespace OpenFoodFacts4Net.Json.Tests
{
    public class ProductSerializationTests
    {
        [Fact]
        public void Should_Deserialize_Product_3017620422003_2311030018()
        {
            string json = DataSetHelper.ReadFileContent("Product.3017620422003_2311030018.json");
            Product product = JsonConvert.DeserializeObject<Product>(json);

            product.Categories.Should().Be("Desserts,Frozen foods");
            product.EmbCodes.Should().Be("FR 42.129.001 EC");
            product.GenericName.Should().Be("Pâte à tartiner aux noisettes et au cacao");
            
            product.Ingredients.Should().HaveCount(7);
            Ingredient[] ingredientsArray = product.Ingredients.ToArray();
            
            Ingredient ingredient0 = ingredientsArray[0];
            ingredient0.CiqualFoodCode.Should().BeNull();
            ingredient0.FromPalmOil.Should().BeNull();
            ingredient0.Id.Should().Be("en:sugar");
            ingredient0.Percent.Should().BeNull();
            ingredient0.PercentEstimate.Should().Be(39.275);
            ingredient0.PercentMax.Should().Be(57.9);
            ingredient0.PercentMin.Should().Be(20.65);
            ingredient0.Text.Should().Be("sucre");
            ingredient0.Vegan.Should().Be("yes");
            ingredient0.Vegetarian.Should().Be("yes");

            Ingredient ingredient1 = ingredientsArray[1];
            ingredient1.CiqualFoodCode.Should().Be("16129");
            ingredient1.FromPalmOil.Should().Be("yes");
            ingredient1.Id.Should().Be("en:palm-oil");

            Ingredient ingredient2 = ingredientsArray[2];
            ingredient2.Id.Should().Be("en:hazelnut-oil");
            ingredient2.Percent.Should().Be(13);

            Ingredient ingredient5 = ingredientsArray[5];
            ingredient5.Id.Should().Be("en:emulsifier");
            ingredient5.Ingredients.Should().HaveCount(1);

            product.NovaGroup.Should().Be(4);

            product.NutrientLevels.Should().NotBeNull();

            product.NutritionGrades.Should().Be("e");
        }

        [Fact]
        public void Should_Deserialize_ProductDates_3017620422003_2311030018()
        {
            string json = DataSetHelper.ReadFileContent("Product.3017620422003_2311030018.json");
            Product product = JsonConvert.DeserializeObject<Product>(json);

            DateTime creationDateTime = new DateTime(2016, 3, 11, 7, 17, 32);
            product.CreatedDateTime.Should().Be(creationDateTime);

            DateTime lastModifiedTime = new DateTime(2023, 10, 17, 17, 34, 59);
            product.LastModifiedTime.Should().Be(lastModifiedTime);
        }
    }
}
