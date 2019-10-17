using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JCSoft.ApiCore
{
    public interface IApiClient
    {
        /// <summary>
        /// 请求并获取原始String
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        string RequestGetString<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase;
        /// <summary>
        /// 异步请求并获取原始STring
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<string> RequestGetStringAsync<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase;
        /// <summary>
        /// 请求并返回实体对象
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        TResponse Request<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase;
        /// <summary>
        /// 异步请求并返回实体对象
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<TResponse> RequestAsync<TResponse>(ApiRequestBase<TResponse> request) where TResponse : ApiResponseBase;
    }
}
