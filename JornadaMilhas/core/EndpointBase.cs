namespace JornadaMilhas.API.Common;

public abstract class EndpointBase<TRequest>(HttpMethod method, bool allowAnonymous = false) : EndpointBase(method, allowAnonymous)
{
}

public abstract class EndpointBase(HttpMethod method, bool allowAnonymous = false)
{
    public HttpMethod Method => method;
    public bool AllowAnonymous => allowAnonymous;
    public string Paths => $"api/{GetType().FullName!.Replace(".", "/")}";
}