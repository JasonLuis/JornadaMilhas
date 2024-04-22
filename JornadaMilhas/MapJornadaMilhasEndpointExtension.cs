using JornadaMilhas.API.core;
using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.core.EndPoint;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhas.API;

public static class MapJornadaMilhasEndpointExtension
{
    public static IEndpointRouteBuilder MapJornadaMilhasEndpoints(
       this IEndpointRouteBuilder endpoints,
       params Action<IEndpointRegistry>[] registrators)
    {
        var registry = new EndpointRegistry(endpoints);
        registrators.ToList().ForEach(r => r(registry));
        return endpoints;
    }

    public static IEndpointRouteBuilder MapJornadaMilhasUploadEndpoint<TRequest, TParameters>(
        this IEndpointRouteBuilder endpoints,
        UploadFileCommandEndpoint<TRequest> endpoint,
        Delegate del) where TParameters : TRequest
    {

        var routeBuilder = endpoints.MapPost(endpoint.Paths, async (
            [AsParameters] TParameters parameters,
            [FromForm] IFormFile file) =>
        {
            var fileParameter = new FileParameter
            {
                Name = file.Name,
                Stream = file.OpenReadStream(),
                ContentType = file.ContentType
            };

            await (Task)del.DynamicInvoke(parameters, fileParameter)!;
        });

        routeBuilder.DisableAntiforgery();

        //if (endpoint.AllowAnonymous)
        //{
        routeBuilder.AllowAnonymous();
        //}
        //else
        //{
        //    routeBuilder.RequireAuthorization();
        //}

        return endpoints;
    }

    public static IEndpointRouteBuilder MapJornadaMilhasEndpoint(
        this IEndpointRouteBuilder endpoints,
        EndpointBase endpoint,
        Delegate del)
    {
        endpoints.MapJornadaMilhasRequest(endpoint, del);
        return endpoints;
    }

    public static IEndpointRouteBuilder MaJornadaMilhasEndpoint<TRequest>(
        this IEndpointRouteBuilder endpoints,
        CommandEndpoint<TRequest> endpoint,
        Delegate del)
    {
        var end = endpoints.MapJornadaMilhasRequest(endpoint, del);
        
        return endpoints;
    }

    public static IEndpointRouteBuilder MapJornadaMilhasEndpoint<TResponse, TRequest>(
        this IEndpointRouteBuilder endpoints,
        QueryEndpoint<TResponse, TRequest> endpoint,
        Delegate del)
    {
        endpoints.MapJornadaMilhasRequest(endpoint, del);
        
        return endpoints;
    }

    public static IEndpointRouteBuilder MapJornadaMilhasEndpoint<TResponse, TRequest>(
        this IEndpointRouteBuilder endpoints,
        CommandEndpoint<TResponse, TRequest> endpoint,
        Delegate del)
    {
        endpoints.MapJornadaMilhasRequest(endpoint, del);
        
        return endpoints;
    }

    private static RouteHandlerBuilder MapJornadaMilhasRequest(this IEndpointRouteBuilder endpoints, EndpointBase endpoint, Delegate del)
    {
        var routeBuilder = endpoint.Method switch
        {
            EndpointMethod.Get => endpoints.MapGet(endpoint.Paths, del),
            EndpointMethod.Post => endpoints.MapPost(endpoint.Paths, del),
            EndpointMethod.Put => endpoints.MapPut(endpoint.Paths, del),
            EndpointMethod.Delete => endpoints.MapDelete(endpoint.Paths, del),
            _ => throw new NotImplementedException()
        };

        if (endpoint.CacheOutput is not EndpointCacheOutput.None)
        {
            routeBuilder.CacheOutput(endpoint.CacheOutputPolicy);
        }

        //if (endpoint.AllowAnonymous)
        //{
        routeBuilder.AllowAnonymous();
        //}
        //else
        //{
        //    routeBuilder.RequireAuthorization();
        //}
        return routeBuilder;
    }
}
