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
        public void Should_Deserialize_Product_3029330003533()
        {
            string json = DataSetHelper.ReadFileContent("Product.3029330003533.json");
            Product product = JsonConvert.DeserializeObject<Product>(json);

            product.GenericName.Should().Be("Pain de mie complet");
            product.NutrientLevels.Should().NotBeNull();
        }

        [Fact]
        public void Should_Deserialize_ProductDates_3029330003533()
        {
            string json = DataSetHelper.ReadFileContent("Product.3029330003533.json");
            Product product = JsonConvert.DeserializeObject<Product>(json);

            DateTime creationDateTime = new DateTime(2012, 5, 26, 15, 42, 5);
            product.CreatedDateTime.Should().Be(creationDateTime);

            DateTime lastModifiedTime = new DateTime(2019, 4, 26, 12, 1, 45);
            product.LastModifiedTime.Should().Be(lastModifiedTime);
        }
    }
}
