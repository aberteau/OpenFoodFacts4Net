using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using OpenFoodFacts4Net.ApiClient.Data;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class ProductSerializationTests
    {
        [Fact]
        public void Should_Deserialize_Product_3029330003533()
        {
            string json = DataSetHelper.ReadFileContent("Product.3029330003533.json");
            Product product = JsonConvert.DeserializeObject<Product>(json);

            Assert.Equal("Pain de mie complet", product.GenericName);
            Assert.NotNull(product.NutrientLevels);
        }
    }
}
