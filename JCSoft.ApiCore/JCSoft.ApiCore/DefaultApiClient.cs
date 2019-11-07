using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore
{
    public class DefaultApiClient : IApiClient
    {
        private IRequestBuilderFactory _builderFactory;
        public DefaultApiClient(IRequestBuilderFactory builderFactory)
        {
            _builderFactory = builderFactory;
        }

        public TResponse Request<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase => 
            RequestAsync(request).GetAwaiter().GetResult();

        public Task<TResponse> RequestAsync<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase
        {
            return _builderFactory.Execute<TResponse>(request);
        }
    }
}
