using System;
using System.Net.Http;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient.Core;
using OpenFoodFacts4Net.ApiClient.Core.Extensions;
using OpenFoodFacts4Net.Json.Data;

namespace OpenFoodFacts4Net.ApiClient.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<GetProductResponse> GetProductAsync(this HttpClient httpClient, String barcode)
        {
            IResponse<GetProductResponse> response = await httpClient.GetAsync<GetProductResponse>($"/api/v0/product/{barcode}.json");
            return response.Data;
        }
    }
}
