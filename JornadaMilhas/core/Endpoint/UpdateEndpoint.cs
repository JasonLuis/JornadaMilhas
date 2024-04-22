using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class UpdateEndpoint(bool allowAnonymous = false) : EndpointBase(EndpointMethod.Put, default!, allowAnonymous);

public abstract class UpdateEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false) : EndpointBase(EndpointMethod.Put, serializerContext, allowAnonymous)
{

}

public abstract class UpdateEndpoint<TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false) : EndpointBase(EndpointMethod.Put, serializerContext, allowAnonymous)
{
}