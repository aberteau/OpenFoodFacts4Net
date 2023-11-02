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
        public async Task Should_GetProductAsync_3029330003533()
        {
            string barcode = "3029330003533";
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.Tests", ".Net Platform", "0.1",  null);

            Client client = new Client(Constants.BaseUrl, userAgent);
            GetProductResponse productResponse = await client.GetProductAsync(barcode);

            productResponse.Product.GenericName.Should().Be("Pain de mie complet");
        }
    }
}
