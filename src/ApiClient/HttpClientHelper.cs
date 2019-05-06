using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OpenFoodFacts4Net.ApiClient
{
    public class HttpClientHelper
    {
        public static HttpClient Create(String baseAddress, String userAgent)
        {
            Uri baseUri = new Uri(baseAddress);
            HttpClient httpClient = Create(baseUri, userAgent);
            return httpClient;
        }

        public static HttpClient Create(Uri baseAddress, String userAgent)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = baseAddress;
            httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }
    }
}
