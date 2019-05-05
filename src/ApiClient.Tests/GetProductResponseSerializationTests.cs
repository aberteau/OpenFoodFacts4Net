using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using OpenFoodFacts4Net.ApiClient.Data;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class GetProductResponseSerializationTests
    {
        [Fact]
        public void Should_Deserialize_GetProductResponse_3029330003533()
        {
            string json = DataSetHelper.ReadFileContent("GetProductResponse.3029330003533.json");
            GetProductResponse response = JsonConvert.DeserializeObject<GetProductResponse>(json);

            Assert.Equal(1, response.Status);
            Assert.Equal("3029330003533", response.Code);
            Assert.Equal("product found", response.StatusVerbose);
        }
    }
}
