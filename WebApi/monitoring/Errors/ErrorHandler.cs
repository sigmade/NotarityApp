namespace WebApi.monitoring.Errors
{
    public class ErrorHandler : IErrorHandler
    {
        private readonly Serilog.ILogger _logger;

        public ErrorHandler(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public static int Id()
        {
            return new Random().Next(100, 99999);
        }

        public string DefaultHandle(string methodName, Exception exception)
        {
            var errorId = Id();
            _logger.Error($"{methodName} failed. ErrorId: {errorId}. Message: {exception.Message}. Trace: {exception.StackTrace}");
            return $"Ошибка операции. Код {errorId}";
        }
    }
}