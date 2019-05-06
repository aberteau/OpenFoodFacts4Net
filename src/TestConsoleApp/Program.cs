using System;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.Json.Data;

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
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.TestConsoleApp", ".Net Platform", "0.1", null);
            Client client = new Client(Constants.BaseUrl, userAgent);
            GetProductResponse productResponse = await client.GetProductAsync(barcode);
            Console.WriteLine(productResponse.Product.GenericName);
        }
    }
}
