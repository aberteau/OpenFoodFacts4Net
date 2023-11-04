using System;
using System.Threading.Tasks;
using FluentAssertions;
using OpenFoodFacts4Net.Json.Data;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class ClientTests
    {
        [Fact]
        public async Task ClientWithoutUserAgent_Should_GetProduct_3017620422003()
        {
            Client apiClient = new Client();

            string barcode = "3017620422003";
            GetProductResponse productResponse = await apiClient.GetProductAsync(barcode);

            productResponse.Product.GenericName.Should().Be("Pâte à tartiner aux noisettes et au cacao");
        }

        [Fact]
        public async Task ClientWithUserAgent_Should_GetProduct_3017620422003()
        {
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.Tests", ".Net Platform", "0.1", null);
            Client apiClient = new Client(userAgent);

            string barcode = "3017620422003";
            GetProductResponse productResponse = await apiClient.GetProductAsync(barcode);

            productResponse.Product.GenericName.Should().Be("Pâte à tartiner aux noisettes et au cacao");
        }
    }
}
