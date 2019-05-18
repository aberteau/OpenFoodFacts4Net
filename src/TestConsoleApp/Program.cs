using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.Csv;
using OpenFoodFacts4Net.Json.Data;

namespace OpenFoodFacts4Net.TestConsoleApp
{
    class Program
    {
        private const string OffCsvFilePath = @"E:\Temp\OpenFoodFacts\fr.openfoodfacts.org.products.csv";
        private const string HeaderOutputFilePath = @"E:\Temp\OpenFoodFacts\csv_headers.txt";

        static void Main(string[] args)
        {
            string barcode = "3029330003533";
            //GetProductAsync(barcode).Wait();
            //WriteCsvHeaders(OffCsvFilePath);
            ReadCsv(OffCsvFilePath);

            Console.ReadLine();
        }

        private static async Task GetProductAsync(string barcode)
        {
            String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.TestConsoleApp", ".Net Platform", "0.1", null);
            Client client = new Client(Constants.BaseUrl, userAgent);
            GetProductResponse productResponse = await client.GetProductAsync(barcode);
            Console.WriteLine(productResponse.Product.GenericName);
        }

        private static void WriteCsvHeaders(string filename)
        {
            IDictionary<Int32, String> headerByIndex = CsvFileHelper.GetHeaderByIndex(filename);
            IEnumerable<string> lines = headerByIndex.Select(kvp => $"{kvp.Key}\t{kvp.Value}");
            File.WriteAllLines(HeaderOutputFilePath, lines);
        }

        public static void ReadCsv(String filename)
        {
            ProductHelper.GetProducts(filename, 1000, DebugWrite);
        }

        private static void DebugWrite(IEnumerable<Csv.Data.Product> products)
        {
            foreach (Csv.Data.Product product in products)
            {
                System.Diagnostics.Debug.WriteLine("*** Code = {0}, ProductName = {1}, ProductName = {2}", product.Code, product.ProductName, product.GenericName);
            }
        }
    }
}
