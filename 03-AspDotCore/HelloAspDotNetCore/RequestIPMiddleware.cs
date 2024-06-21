using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HelloAspDotNetCore
{
    /// <summary>
    /// 获取IP地址的中间件
    /// </summary>
    public class RequestIPMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestIPMiddleware(RequestDelegate next,ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger= loggerFactory.CreateLogger<RequestIPMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("User IP:" + context.Connection.RemoteIpAddress.ToString());
            await _next.Invoke(context);
        }
    }

    public static class RequestIPExtensions
    {
        public static IApplicationBuilder UseRequestIP(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIPMiddleware>();
        }
    }
}
