namespace JCSoft.ApiCore
{
    /// <summary>
    /// Get请求生成Url的时候调用
    /// </summary>
    public interface IRequestToQueryString
    {
        string ToQueryString(object obj);
    }
}
