using System;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.ApiClient.Data;
using OpenFoodFacts4Net.ApiClient.Extensions;
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
            RestClient restClient = RestClientHelper.Create();
            GetProductResponse productResponse = await restClient.GetProductAsync(barcode);
            Console.WriteLine(productResponse.Product.GenericName);
        }
    }
}
