using JornadaMilhas.API.core.Endpoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.EndPoint;

public abstract class QueryEndpoint<TResponse>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "",
    EndpointCacheOutput cacheOutput = EndpointCacheOutput.None)
    : EndpointBase(EndpointMethod.Get, serializerContext, allowAnonymous, cacheOutput, tag);

public abstract class QueryEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "",
    EndpointCacheOutput cacheOutput = EndpointCacheOutput.None)
    : EndpointBase(EndpointMethod.Get, serializerContext, allowAnonymous, cacheOutput, tag : tag)
{
}
