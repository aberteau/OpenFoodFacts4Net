using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using OpenFoodFacts4Net.Csv.Data;

namespace OpenFoodFacts4Net.Csv
{
    public class ProductHelper
    {

        public static IEnumerable<Product> GetProducts(String filename)
        {
            using (TextReader reader = File.OpenText(filename))
            {
                IEnumerable<Product> products = GetProducts(reader).ToList();
                return products;
            }
        }

        public static IEnumerable<Product> GetProducts(TextReader textReader)
        {
            var csv = new CsvReader(textReader);
            csv.Configuration.RegisterClassMap<ProductClassMap>();
            csv.Configuration.Delimiter = CsvFileHelper.Separator.ToString();
            IEnumerable<Product> products = csv.GetRecords<Product>().ToList();
            return products;
        }

        public static void GetProducts(String filename, Int32 batchSize, Action<IEnumerable<Product>> action)
        {
            using (TextReader reader = File.OpenText(filename))
            {
                bool isLastBatch = false;
                int i = 0;
                while (!isLastBatch)
                {
                    IEnumerable<Product> products = ProductHelper.GetProducts(reader).Take(batchSize).ToList();
                    action(products);
                    i += batchSize;
                    isLastBatch = products.Count() < batchSize;
                }
            }

        }
    }
}
