using JCSoft.ApiCore.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore
{
    public class DefaultRequestBuilderFactory : IRequestBuilderFactory
    {
        public async Task<TResponse> Execute<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase
        {
           if(request.HttpMethod == HttpMethod.Post)
                return await HttpRequestFactory.Post(request.Url, request.GetPostContent(), request.Header, true).ContentToType<TResponse>();

            if (request.HttpMethod == HttpMethod.Put)
                return await HttpRequestFactory.Put(request.Url, request.GetPostContent(), request.Header).ContentToType<TResponse>();

            if (request.HttpMethod == HttpMethod.Get)
                return await HttpRequestFactory.Get(request.Url, request.Header, true).ContentToType<TResponse>();

            if (request.HttpMethod == HttpMethod.Delete)
                return await HttpRequestFactory.Delete(request.Url, request.Header).ContentToType<TResponse>();

            throw new NotSupportedException("不支持的方法");
        }
    }
}
