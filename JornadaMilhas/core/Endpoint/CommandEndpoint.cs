

using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class CommandEndpoint(bool allowAnonymous = false, string tag = "") : EndpointBase(EndpointMethod.Post, default!, allowAnonymous, tag: tag);

public abstract class CommandEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "") : EndpointBase(EndpointMethod.Post, serializerContext, allowAnonymous, tag: tag)
{
    
}

public abstract class CommandEndpoint<TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "") : EndpointBase(EndpointMethod.Post, serializerContext, allowAnonymous, tag: tag)
{
}