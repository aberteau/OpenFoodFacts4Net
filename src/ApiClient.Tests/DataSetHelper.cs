using System.IO;
using System.Reflection;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    class DataSetHelper
    {
        public static string ReadFileContent(string filename)
        {
            Assembly assembly = typeof(ProductSerializationTests).GetTypeInfo().Assembly;
            string assemblyName = assembly.GetName().Name;
            string resourceName = $"{assemblyName}.DataSets.{filename}";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string fileContent = reader.ReadToEnd();
                return fileContent;
            }
        }
    }
}
