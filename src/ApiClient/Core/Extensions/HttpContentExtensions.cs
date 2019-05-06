using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.ApiClient.Core.Extensions
{
    public static class HttpContentExtensions
    {
        private static T DeserializeObject<T>(string contentString)
            where T : class
        {
            if (String.IsNullOrWhiteSpace(contentString))
                return null;

            T obj = JsonConvert.DeserializeObject<T>(contentString);
            return obj;
        }

        public static async Task<T> ReadAsAsync<T>(this HttpContent httpContent)
            where T : class
        {
            string contentString = await httpContent.ReadAsStringAsync();
            T obj = DeserializeObject<T>(contentString);
            return obj;
        }
    }
}
