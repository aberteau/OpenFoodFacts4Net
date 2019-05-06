using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenFoodFacts4Net.ApiClient.Extensions;
using OpenFoodFacts4Net.Json.Data;
using RestSharp;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class RestClientExtensionsTests
    {
        [Fact]
        public async Task Should_GetProductAsync_3029330003533()
        {
            string barcode = "3029330003533";
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.Tests", ".Net Platform", "0.1",  Constants.ProjectUrl);
            RestClient restClient = RestClientHelper.Create(Constants.BaseUrl, userAgent);
            GetProductResponse productResponse = await restClient.GetProductAsync(barcode);

            Assert.Equal("Pain de mie complet", productResponse.Product.GenericName);
        }
    }
}
