using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.ApiCore
{
    /// <summary>
    /// Api 请求的基类
    /// </summary>
    public abstract class ApiRequestBase<TResponse>
        where TResponse : ApiResponseBase
    {
        /// <summary>
        /// Http 方法
        /// </summary>
        [JsonIgnore]
        public abstract HttpMethod HttpMethod { get; }

        [JsonIgnore]
        /// <summary>
        /// Api接口地址
        /// </summary>
        public abstract string Url { get; }

        /// <summary>
        /// 请求时带入的头部信息
        /// </summary>
        [JsonIgnore]
        public virtual Dictionary<string, string> Header { get; set; }

        /// <summary>
        /// 验证参数用
        /// </summary>
        public virtual void Verify()
        {

        }

        /// <summary>
        /// 获取PostData使用
        /// </summary>
        /// <returns></returns>
        public virtual string GetPostContent()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
