using Azure;
using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class UpdateEndpoint(bool allowAnonymous = false, string tag = "") : EndpointBase(EndpointMethod.Put, default!, allowAnonymous, tag : tag);

public abstract class UpdateEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "") : EndpointBase(EndpointMethod.Put, serializerContext, allowAnonymous, tag: tag)
{

}

public abstract class UpdateEndpoint<TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "") : EndpointBase(EndpointMethod.Put, serializerContext, allowAnonymous, tag: tag)
{
}