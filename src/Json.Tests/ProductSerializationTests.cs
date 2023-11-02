using System;
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

            product.GenericName.Should().Be("Pâte à tartiner aux noisettes et au cacao");
            product.NutrientLevels.Should().NotBeNull();
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
