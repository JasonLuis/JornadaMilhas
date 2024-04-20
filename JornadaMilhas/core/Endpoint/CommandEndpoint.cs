

using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class CommandEndpoint(bool allowAnonymous = false) : EndpointBase(EndpointMethod.Post, default!, allowAnonymous);

public abstract class CommandEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false) : EndpointBase(EndpointMethod.Post, serializerContext, allowAnonymous)
{
    
}

public abstract class CommandEndpoint<TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false) : EndpointBase(EndpointMethod.Post, serializerContext, allowAnonymous)
{
}