using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace JornadaMilhas.API.core.Endpoint;

public class ExceptionToProblemDetailsHandler(IProblemDetailsService problemDetailsService) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {

        httpContext.Response.StatusCode = exception switch
        {
            HttpRequestException httpRequestException => (int?)httpRequestException.StatusCode ?? (int)HttpStatusCode.BadRequest,
            InvalidOperationException => (int)HttpStatusCode.BadRequest,
            _ => httpContext.Response.StatusCode
        };

        return await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails =
            {
                Title = "Operação inválida",
                Detail = exception.Message,
                Status = httpContext.Response.StatusCode
            },
            Exception = exception
        });
    }
}
