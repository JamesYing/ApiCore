using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.ApiCore.Common
{
    public static class JsonHelper
    {
        public static T JsonToObj<T>(this string str)
        {
            return !String.IsNullOrEmpty(str) ?
                JsonConvert.DeserializeObject<T>(str) :
                default(T);
        }
    }
}
