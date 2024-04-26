namespace Fabric.Middlewares
{
    public class EndPointListenerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<EndPointListenerMiddleware> _logger;
        public EndPointListenerMiddleware(RequestDelegate next, ILogger<EndPointListenerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            _logger.LogInformation(httpContext.Request.Path.Value);
            await _next(httpContext);
        }
    }
}
