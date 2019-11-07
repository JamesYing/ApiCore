using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore
{
    public interface IRequestBuilderFactory
    {
        Task<TResponse> Execute<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase;
    }
}
