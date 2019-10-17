using JCSoft.ApiCore.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore.Utils
{
    public static class HttpResponseExtensions
    {
        public static async Task<T> ContentToType<T>(this Task<HttpResponseMessage> message) =>
            (await ContentToString(message)).JsonToObj<T>();

        public static async Task<string> ContentToString(this Task<HttpResponseMessage> message) =>
           await (await message)?.Content?.ReadAsStringAsync();

    }
}
