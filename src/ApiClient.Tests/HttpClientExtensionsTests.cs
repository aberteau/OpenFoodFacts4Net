using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using OpenFoodFacts4Net.ApiClient.Extensions;
using OpenFoodFacts4Net.Json.Data;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class HttpClientExtensionsTests
    {
        [Fact]
        public async Task Should_GetProductAsync_3017620422003()
        {
            string barcode = "3017620422003";
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.Tests", ".Net Platform", "0.1",  null);
            Uri baseAddress = new Uri(Constants.BaseUrl);
            HttpClient httpClient = HttpClientHelper.Create(baseAddress, userAgent);
            GetProductResponse productResponse = await httpClient.GetProductAsync(barcode);

            productResponse.Product.GenericName.Should().Be("Pâte à tartiner aux noisettes et au cacao");
        }
    }
}
