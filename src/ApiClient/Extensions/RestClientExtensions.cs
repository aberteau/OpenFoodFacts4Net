using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenFoodFacts4Net.Json.Data;
using RestSharp;

namespace OpenFoodFacts4Net.ApiClient.Extensions
{
    public static class RestClientExtensions
    {
        public static async Task<GetProductResponse> GetProductAsync(this RestClient restClient, String barcode)
        {
            IRestRequest request = new RestRequest("/api/v0/product/{barcode}.json", Method.GET);
            request.AddParameter("barcode", barcode, ParameterType.UrlSegment);
            IRestResponse<GetProductResponse> response = await restClient.ExecuteGetTaskAsync<GetProductResponse>(request);
            return response.Data;
        }
    }
}
