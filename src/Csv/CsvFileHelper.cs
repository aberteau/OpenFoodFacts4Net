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
    }
}
