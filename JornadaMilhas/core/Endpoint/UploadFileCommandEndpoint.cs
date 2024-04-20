using JornadaMilhas.API.core.EndPoint;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API.core.Endpoint;

public abstract class UploadFileCommandEndpoint<TRequest>(
    JsonSerializerContext serializerContext,
    bool allowAnonymous = false) : EndpointBase(EndpointMethod.Post, serializerContext, allowAnonymous);
