using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace JCSoft.ApiCore.Tests
{
    public class MyApiWhoRequest : ApiRequestBase<MyApiResponse<String>>
    {
        public override HttpMethod HttpMethod => HttpMethod.Get;

        public override string Url => $"http://my.apiquan.com/api/who";
    }
}
