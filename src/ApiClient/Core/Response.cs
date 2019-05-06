using System.Net.Http;

namespace OpenFoodFacts4Net.ApiClient.Core
{
    public class Response<T>
        : IResponse<T>
    {
        public Response(HttpResponseMessage httpResponseMessage, T content)
        {
            HttpResponseMessage = httpResponseMessage;
            Data = content;
        }

        public HttpResponseMessage HttpResponseMessage { get; }

        public T Data { get; }
    }
}
