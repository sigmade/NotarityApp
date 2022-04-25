namespace WebApi.monitoring.Errors
{
    public interface IErrorHandler
    {
        string DefaultHandle(string methodName, Exception exception);
    }
}