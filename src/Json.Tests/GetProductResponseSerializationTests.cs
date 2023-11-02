using FluentAssertions;
using Newtonsoft.Json;
using OpenFoodFacts4Net.Json.Data;
using Xunit;

namespace OpenFoodFacts4Net.Json.Tests
{
    public class GetProductResponseSerializationTests
    {
        [Fact]
        public void Should_Deserialize_GetProductResponse_3017620422003_2311030018()
        {
            string json = DataSetHelper.ReadFileContent("GetProductResponse.3017620422003_2311030018.json");
            GetProductResponse response = JsonConvert.DeserializeObject<GetProductResponse>(json);

            response.Status.Should().Be(1);
            response.Code.Should().Be("3017620422003");
            response.StatusVerbose.Should().Be("product found");
        }
    }
}
