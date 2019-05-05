using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.ApiClient.Converters
{
    public class ProductStringConverter
        : JsonConverter<String>
    {
        public override void WriteJson(JsonWriter writer, string value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override string ReadJson(JsonReader reader, Type objectType, string existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string str = (string)reader.Value;
            //StringEscapeUtils.unescapeHtml4(value).replace("\\'", "'").replace("&quot", "'");
            return str;
        }
    }
}
