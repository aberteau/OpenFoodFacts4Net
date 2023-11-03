using FluentAssertions;
using Newtonsoft.Json;
using OpenFoodFacts4Net.Json.Data;
using Xunit;

namespace OpenFoodFacts4Net.Json.Tests
{
    public class NutrientLevelsSerializationTests
    {
        [Fact]
        public void Should_Deserialize_NutrientLevels_01()
        {
            string productJson = DataSetHelper.ReadFileContent("NutrientLevels.01.json");
            NutrientLevels nutrientLevels = JsonConvert.DeserializeObject<NutrientLevels>(productJson);

            nutrientLevels.Salt.Should().Be(NutrientLevel.Moderate);
            nutrientLevels.SaturatedFat.Should().Be(NutrientLevel.Low);
            nutrientLevels.Fat.Should().Be(NutrientLevel.High);
            nutrientLevels.Sugars.Should().Be(NutrientLevel.Moderate);
        }
    }
}
