using System.Net.Http;
using System.Threading.Tasks;

namespace OpenFoodFacts4Net.ApiClient.Core.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static async Task<T> ReadContentAsAsync<T>(this HttpResponseMessage response)
            where T : class
        {
            T obj = await response.Content.ReadAsAsync<T>();
            return obj;
        }
    }
}
