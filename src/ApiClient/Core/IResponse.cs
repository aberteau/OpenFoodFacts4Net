using System.Net.Http;

namespace OpenFoodFacts4Net.ApiClient.Core
{
    public interface IResponse
    {
        HttpResponseMessage HttpResponseMessage { get; }
    }

    public interface IResponse<T>
         : IResponse
    {
        T Data { get; }
    }
}