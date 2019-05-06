using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace OpenFoodFacts4Net.ApiClient.Core
{
    public class HttpContentHelper
    {
        public static HttpContent ToJsonContent<T>(T contentObj)
        {
            string jsonObject = contentObj == null ? null : JsonConvert.SerializeObject(contentObj);
            HttpContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            return content;
        }
    }
}
