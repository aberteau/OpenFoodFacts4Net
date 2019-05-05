using Newtonsoft.Json;

namespace OpenFoodFacts4Net.ApiClient
{
    public class SerializationHelper
    {
        public static NewtonsoftJsonSerializer CreateNewtonsoftJsonSerializer()
        {
            JsonSerializer serializer = CreateJsonSerializer();
            NewtonsoftJsonSerializer jsonSerializer = new NewtonsoftJsonSerializer(serializer);
            return jsonSerializer;
        }

        private static JsonSerializer CreateJsonSerializer()
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore,
            };
            return serializer;
        }
    }
}
