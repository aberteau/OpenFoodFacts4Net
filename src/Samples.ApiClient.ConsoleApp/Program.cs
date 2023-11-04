using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.Json.Data;

string barcode = "3029330003533";

// Without User-Agent header
Client client = new Client();

// With User-Agent header
//String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.Samples.ApiClient.ConsoleApp", ".Net Platform", "0.1", null);
//Client client = new Client(userAgent);

GetProductResponse productResponse = await client.GetProductAsync(barcode);
Console.WriteLine(productResponse.Product.GenericName);
