using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class DeleteEndpoint(bool allowAnonymous = false) : EndpointBase(EndpointMethod.Delete, default!, allowAnonymous);

public abstract class DeleteEndpoint<TResponse>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false)
    : EndpointBase(EndpointMethod.Delete, serializerContext, allowAnonymous);

public abstract class DeleteEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false)
    : EndpointBase(EndpointMethod.Delete, serializerContext, allowAnonymous)
{
}
