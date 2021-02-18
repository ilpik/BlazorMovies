using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorMovies.Client2.Helpers
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Success = success;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Success { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<String> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
     }
}