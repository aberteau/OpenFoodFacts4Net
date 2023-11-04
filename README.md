# OpenFoodFacts4Net

.Net components for OpenFoodFacts (API Client, CSV data reader, ...)

Target Platform : .Net Standard 2.0

## Projects

| Name           | Description                 | Type                | TargetFramework | NuGet                                                                    |
|----------------|-----------------------------|---------------------|-----------------|--------------------------------------------------------------------------|
| Json           | JSON Serialization          | Class Library       | netstandard2.0  | ![Nuget](https://img.shields.io/nuget/v/OpenFoodFacts4Net.Json)          |
| ApiClient      | API Client                  | Class Library       | netstandard2.0  | ![Nuget](https://img.shields.io/nuget/v/OpenFoodFacts4Net.ApiClient)     |
| Csv            | CSV Dump Reader             | Class Library       | netstandard2.0  | ![Nuget](https://img.shields.io/nuget/v/OpenFoodFacts4Net.Csv)           |
| Taxonomy.Json  | JSON Taxonomy Serialization | Class Library       | netstandard2.0  | ![Nuget](https://img.shields.io/nuget/v/OpenFoodFacts4Net.Taxonomy.Json) |
| TestConsoleApp | Test Console App            | Console Application | net6.0          |                                                                          |

## Getting Started
Before you can use OpenFoodFacts4Net.ApiClient in your application, you need to add the NuGet package. You can do it using your IDE or the command line:

```
dotnet add package OpenFoodFacts4Net.ApiClient
```

### Basic Usage
(See [Samples.ApiClient.ConsoleApp](src/Samples.ApiClient.ConsoleApp/Program.cs))
```
Client client = new Client();
string barcode = "3017620422003";
GetProductResponse productResponse = await client.GetProductAsync(barcode);
```

If you want to set the `User-Agent` header :
```
String userAgent = UserAgentHelper.GetUserAgent("applicationName", "system", "version", "projectUrl");
Client client = new Client(userAgent);
string barcode = "3017620422003";
GetProductResponse productResponse = await client.GetProductAsync(barcode);
```

## Authors

* **Amael BERTEAU**

## License

This project is licensed under the Apache 2.0 License - see the [LICENSE](LICENSE) file for details

## NuGet Packages
Available on NuGet Gallery :
* [OpenFoodFacts4Net.Json](https://www.nuget.org/packages/OpenFoodFacts4Net.Json/)
* [OpenFoodFacts4Net.ApiClient](https://www.nuget.org/packages/OpenFoodFacts4Net.ApiClient/)
* [OpenFoodFacts4Net.Csv](https://www.nuget.org/packages/OpenFoodFacts4Net.Csv/)
* [OpenFoodFacts4Net.Taxonomy.Json](https://www.nuget.org/packages/OpenFoodFacts4Net.Taxonomy.Json/)

## Credits
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
* [CsvHelper](https://github.com/JoshClose/CsvHelper)
