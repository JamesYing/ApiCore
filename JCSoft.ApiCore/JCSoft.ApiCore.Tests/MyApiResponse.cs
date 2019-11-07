using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.ApiCore.Tests
{
    public class MyApiResponse : ApiResponseBase
    {
        public string ErrorMsg { get; set; }
        public string ErrorReason { get; set; }
        public bool IsError { get; set; }
        public int Code { get; set; }
    }

    public class MyApiResponse<T> : MyApiResponse
    {
        public T Data { get; set; }
    }
}
