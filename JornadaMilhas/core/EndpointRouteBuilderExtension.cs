namespace JornadaMilhas.API.Common;

public static class EndpointRouteBuilderExtension
{
    internal static IEndpointRouteBuilder MapJornadaMilhasEndpoint(this IEndpointRouteBuilder endpoints,
        EndpointBase endpoint,
        Delegate del)
    {
        endpoints.MapJornadaMilhasRequest(endpoint, del);
        return endpoints;
    }

    internal static RouteHandlerBuilder MapJornadaMilhasRequest(this IEndpointRouteBuilder endpoints, EndpointBase endpoint, Delegate del)
    {
        var routeBuilder = endpoint.Method switch
        {
            _ when endpoint.Method == HttpMethod.Get => endpoints.MapGet(endpoint.Paths, del),
            _ when endpoint.Method == HttpMethod.Post => endpoints.MapPost(endpoint.Paths, del),
            _ => throw new NotImplementedException()
        };
        if (endpoint.AllowAnonymous)
        {
            routeBuilder.AllowAnonymous();
        }
        else
        {
            //routeBuilder.RequireAuthorization();
            routeBuilder.AllowAnonymous();
        }
        return routeBuilder;
    }
}
