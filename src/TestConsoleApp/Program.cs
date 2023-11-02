using OpenFoodFacts4Net.ApiClient;
using OpenFoodFacts4Net.Csv;
using OpenFoodFacts4Net.Json.Data;
using OpenFoodFacts4Net.Taxonomy.Json;
using OpenFoodFacts4Net.Taxonomy.Json.Data;

const string OffCsvFilePath = @"E:\Temp\OpenFoodFacts\fr.openfoodfacts.org.products.csv";
const string HeaderOutputFilePath = @"E:\Temp\OpenFoodFacts\csv_headers.txt";
const string CategoriesTaxonomyJsonFilePath = @"F:\UserData\Amael\OneDrive\Projets\Suppliz\OpenFoodFacts\Data\categories.json";

//string barcode = "3029330003533";
//GetProductAsync(barcode).Wait();
//WriteCsvHeaders(OffCsvFilePath);
//ReadCsv(OffCsvFilePath);
ReadCategoriesTaxonomy(CategoriesTaxonomyJsonFilePath);
Console.ReadLine();

static void ReadCategoriesTaxonomy(string filePath)
{
    string jsonContent = File.ReadAllText(filePath);
    IDictionary<String, Taxon> data = TaxonomySerializer.Deserialize(jsonContent);
}

static async Task GetProductAsync(string barcode)
{
    String userAgent = UserAgentHelper.GetUserAgent("OpenFoodFacts4Net.ApiClient.TestConsoleApp", ".Net Platform", "0.1", null);
    Client client = new Client(Constants.BaseUrl, userAgent);
    GetProductResponse productResponse = await client.GetProductAsync(barcode);
    Console.WriteLine(productResponse.Product.GenericName);
}

static void WriteCsvHeaders(string filename)
{
    IDictionary<Int32, String> headerByIndex = CsvFileHelper.GetHeaderByIndex(filename);
    IEnumerable<string> lines = headerByIndex.Select(kvp => $"{kvp.Key}\t{kvp.Value}");
    File.WriteAllLines(HeaderOutputFilePath, lines);
}

static void ReadCsv(String filename)
{
    ProductHelper.GetProducts(filename, 1000, DebugWrite);
}

static void DebugWrite(IEnumerable<OpenFoodFacts4Net.Csv.Data.Product> products)
{
    foreach (OpenFoodFacts4Net.Csv.Data.Product product in products)
    {
        System.Diagnostics.Debug.WriteLine("*** Code = {0}, ProductName = {1}, ProductName = {2}", product.Code, product.ProductName, product.GenericName);
    }
}