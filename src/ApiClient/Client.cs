using System;
using System.Net.Http;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient.Extensions;
using OpenFoodFacts4Net.Json.Data;

namespace OpenFoodFacts4Net.ApiClient
{
    public class Client
    {
        private readonly HttpClient _httpClient;

        public Client(string baseUrl, String userAgent)
        {
            _httpClient = HttpClientHelper.Create(baseUrl, userAgent);
        }

        public async Task<GetProductResponse> GetProductAsync(String barcode)
        {
            GetProductResponse response = await _httpClient.GetProductAsync(barcode);
            return response;
        }
    }
}
