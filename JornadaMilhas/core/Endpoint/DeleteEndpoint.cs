using Azure;
using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class DeleteEndpoint(bool allowAnonymous = false, string tag = "") : EndpointBase(EndpointMethod.Delete, default!, allowAnonymous, tag: tag);

public abstract class DeleteEndpoint<TResponse>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "")
    : EndpointBase(EndpointMethod.Delete, serializerContext, allowAnonymous, tag: tag);

public abstract class DeleteEndpoint<TResponse, TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false,
    string tag = "")
    : EndpointBase(EndpointMethod.Delete, serializerContext, allowAnonymous, tag: tag)
{
}
