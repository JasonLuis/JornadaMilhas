using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;

namespace JornadaMilhas.API.core;

public static class CadastrarEndpoint
{
    public static void Register(IEndpointRegistry registry)
    {
        // Depoimentos
        registry.Register(new CriarDepoimentoEndpoint(), CriarDepoimentoEndpoint.ExecuteAsync);
    }
}
