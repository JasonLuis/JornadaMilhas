using JornadaMilhas.API.core.Endpoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.EndPoint;

public abstract class EndpointBase(
    EndpointMethod method,
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    EndpointCacheOutput cacheOutput = EndpointCacheOutput.None)
{
    public EndpointMethod Method => method;
    public bool AllowAnonymous => allowAnonymous;
    public JsonSerializerContext SerializerContext => serializerContext;
    public EndpointCacheOutput CacheOutput => cacheOutput;
    public string CacheOutputPolicy => cacheOutput.ToString();

    public string Paths => $"api/{GetType().FullName!.Replace(".", "/")}";

    public HttpMethod GetHttpMethod => method switch
    {
        EndpointMethod.Get => HttpMethod.Get,
        EndpointMethod.Post => HttpMethod.Post,
        _ => throw new NotImplementedException()
    };
}

public interface IEndpointRegistry
{
    IEndpointRegistry Register(EndpointBase endpoint, Delegate del);
    IEndpointRegistry Register<TRequest>(CommandEndpoint<TRequest> endpoint, Delegate del);
    IEndpointRegistry Register<TResponse, TRequest>(QueryEndpoint<TResponse, TRequest> endpoint, Delegate del);
    IEndpointRegistry Register<TRequest, TParameters>(UploadFileCommandEndpoint<TRequest> endpoint, Delegate del) where TParameters : TRequest;
}
