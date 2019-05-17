using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OpenFoodFacts4Net.Csv
{
    public class CsvFileHelper
    {
        public const char Separator = '\t';

        public static string[] GetHeaders(String filename)
        {
            string headerLine = File.ReadLines(filename).Take(1).FirstOrDefault();
            string[] headers = headerLine == null ? new string[0] : headerLine.Split(Separator);
            return headers;
        }

        public static IDictionary<Int32, String> GetHeaderByIndex(String filename)
        {
            string[] headers = GetHeaders(filename);

            Int32 index = 0;
            IDictionary<Int32, String> headerByIndex = new Dictionary<int, string>();
            foreach (string header in headers)
            {
                headerByIndex.Add(index, header);
                index++;
            }

            return headerByIndex;
        }
    }
}
