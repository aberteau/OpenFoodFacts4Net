using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient.Core;
using OpenFoodFacts4Net.ApiClient.Core.Extensions;
using OpenFoodFacts4Net.Json.Data;

namespace OpenFoodFacts4Net.ApiClient
{
    public class Client
    {
        public const string BaseUrl = "https://world.openfoodfacts.org/";

        private readonly HttpClient _httpClient;

        public Client(String userAgent)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);

            if (!string.IsNullOrEmpty(userAgent))
                _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Client()
            : this(null)
        { }

        public async Task<GetProductResponse> GetProductAsync(String barcode)
        {
            string requestUri = $"/api/v2/product/{barcode}.json";
            IResponse<GetProductResponse> response = await _httpClient.GetAsync<GetProductResponse>(requestUri);
            return response.Data;
        }
    }
}
