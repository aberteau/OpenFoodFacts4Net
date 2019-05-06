using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenFoodFacts4Net.ApiClient.Core.Extensions
{
    public static class HttpClientExtensions
    {
        #region GetAsync

        public static async Task<IResponse<T>> GetAsync<T>(this HttpClient httpClient, string requestUri)
            where T : class
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUri);
            httpResponseMessage.EnsureSuccessStatusCode();
            T obj = await httpResponseMessage.ReadContentAsAsync<T>();
            IResponse<T> response = new Response<T>(httpResponseMessage, obj);
            return response;
        }

        #endregion

        #region PostAsync

        public static async Task<IResponse<TReturn>> PostAsync<T, TReturn>(this HttpClient httpClient, String requestUri, T contentObj)
            where TReturn : class
        {
            HttpContent content = HttpContentHelper.ToJsonContent(contentObj);
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUri, content);
            httpResponseMessage.EnsureSuccessStatusCode();
            TReturn obj = await httpResponseMessage.ReadContentAsAsync<TReturn>();
            IResponse<TReturn> response = new Response<TReturn>(httpResponseMessage, obj);
            return response;
        }

        public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient httpClient, String requestUri, T contentObj)
        {
            HttpContent content = HttpContentHelper.ToJsonContent(contentObj);
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUri, content);
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }

        #endregion
    }
}
