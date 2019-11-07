using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore.Utils
{
    public static class HttpRequestFactory
    {
        public static async Task<HttpResponseMessage> Get(string requestUri, Dictionary<string, string> header = null, bool isJson = true)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Get)
                                .AddRequestUri(requestUri)
                                .IsJson(isJson)
                                .AddHeader(header);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
           string requestUri, string value, Dictionary<string, string> header = null, bool isJson = true)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .IsJson(isJson)
                                .AddContentObject(value)
                                .AddHeader(header);


            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(
           string requestUri, string value, Dictionary<string, string> header = null, bool isJson = true)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Put)
                                .AddRequestUri(requestUri)
                                .IsJson(isJson)
                                .AddContent(new JsonContent(value))
                                .AddHeader(header);

            return await builder.SendAsync();
        }


        public static async Task<HttpResponseMessage> Delete(string requestUri, Dictionary<string, string> header = null, bool isJson = true)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Delete)
                                .AddHeader(header)
                                .IsJson(isJson)
                                .AddRequestUri(requestUri);

            return await builder.SendAsync();
        }
    }
}
