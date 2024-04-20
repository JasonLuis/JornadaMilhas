using JornadaMilhas.API.Common;
using JornadaMilhas.API.core.EndPoint;
using EndpointBases = JornadaMilhas.API.core.EndPoint.EndpointBase;

namespace JornadaMilhas.API.core.Endpoint;

public class EndpointRegistry(IEndpointRouteBuilder endpoints) : IEndpointRegistry
{
    public IEndpointRegistry Register(EndpointBases endpoint, Delegate del)
    {
        endpoints.MapJornadaMilhasEndpoint(endpoint, del);
        return this;
    }

    public IEndpointRegistry Register<TRequest>(CommandEndpoint<TRequest> endpoint, Delegate del)
    {
        endpoints.MapJornadaMilhasEndpoint(endpoint, del);
        return this;
    }

    public IEndpointRegistry Register<TResponse, TRequest>(QueryEndpoint<TResponse, TRequest> endpoint, Delegate del)
    {
        endpoints.MapJornadaMilhasEndpoint(endpoint, del);
        return this;
    }

    public IEndpointRegistry Register<TRequest, TParameters>(UploadFileCommandEndpoint<TRequest> endpoint, Delegate del)
        where TParameters : TRequest
    {
        endpoints.MapJornadaMilhasUploadEndpoint<TRequest, TParameters>(endpoint, del);
        return this;
    }
}

