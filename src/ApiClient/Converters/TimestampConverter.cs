using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.ApiClient.Converters
{
    public class TimestampConverter
        : JsonConverter<DateTime>
    {
        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            long intValue = Convert.ToInt64(reader.Value);
            DateTime dateTime = DateTimeHelper.UnixTimestampToDateTime(intValue);
            return dateTime;
        }
    }
}
