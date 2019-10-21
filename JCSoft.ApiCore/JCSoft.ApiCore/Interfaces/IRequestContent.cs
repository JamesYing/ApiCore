namespace JCSoft.ApiCore.Interfaces
{
    public interface IRequestContent
    {
        string GetContent(IRequestBase request, RequestContentType contentType = RequestContentType.JSON);
    }
}
