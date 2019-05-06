using System;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.ApiClient.Extensions;
using OpenFoodFacts4Net.Json.Data;
using RestSharp;

namespace OpenFoodFacts4Net.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcode = "3029330003533";
            ReadProductAsync(barcode).Wait();
            Console.ReadLine();
        }

        private static async Task ReadProductAsync(string barcode)
        {
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.TestConsoleApp", ".Net Platform", "0.1", Constants.ProjectUrl);
            RestClient restClient = RestClientHelper.Create(Constants.BaseUrl, userAgent);
            GetProductResponse productResponse = await restClient.GetProductAsync(barcode);
            Console.WriteLine(productResponse.Product.GenericName);
        }
    }
}
