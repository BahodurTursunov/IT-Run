namespace Fabric.Middlewares
{
    public class AppicationKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AppicationKeyMiddleware> _logger;

        public AppicationKeyMiddleware(RequestDelegate next, ILogger<AppicationKeyMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            await _next(httpContext);
        }
    }
}
