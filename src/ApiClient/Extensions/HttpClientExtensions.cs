using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenFoodFacts4Net.Json.Data;

namespace OpenFoodFacts4Net.ApiClient.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<GetProductResponse> GetProductAsync(this HttpClient httpClient, String barcode)
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"/api/v0/product/{barcode}.json");
            httpResponseMessage.EnsureSuccessStatusCode();
            string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
            GetProductResponse response = JsonConvert.DeserializeObject<GetProductResponse>(responseBody);
            return response;
        }
    }
}
