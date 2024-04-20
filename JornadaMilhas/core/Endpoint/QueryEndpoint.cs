using JornadaMilhas.API.core.Endpoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.EndPoint;

public abstract class QueryEndpoint<TResponse>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    EndpointCacheOutput cacheOutput = EndpointCacheOutput.None)
    : EndpointBase(EndpointMethod.Get, serializerContext, allowAnonymous, cacheOutput);

public abstract class QueryEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    EndpointCacheOutput cacheOutput = EndpointCacheOutput.None)
    : EndpointBase(EndpointMethod.Get, serializerContext, allowAnonymous, cacheOutput)
{
}
