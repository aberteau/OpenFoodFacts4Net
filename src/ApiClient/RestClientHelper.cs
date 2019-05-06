using System;
using OpenFoodFacts4Net.Json;
using RestSharp;

namespace OpenFoodFacts4Net.ApiClient
{
    public class RestClientHelper
    {
        public static RestClient Create(string baseUrl, String userAgent)
        {
            RestClient restClient = new RestClient(baseUrl);
            restClient.UserAgent = userAgent;

            restClient.AddHandler("application/json", CreateNewtonsoftJsonSerializer);
            restClient.AddHandler("text/json", CreateNewtonsoftJsonSerializer);
            restClient.AddHandler("text/x-json", CreateNewtonsoftJsonSerializer);
            restClient.AddHandler("text/javascript", CreateNewtonsoftJsonSerializer);
            restClient.AddHandler("*+json", CreateNewtonsoftJsonSerializer);

            return restClient;
        }

        private static NewtonsoftJsonSerializer CreateNewtonsoftJsonSerializer()
        {
            return SerializationHelper.CreateNewtonsoftJsonSerializer();
        }
    }
}
