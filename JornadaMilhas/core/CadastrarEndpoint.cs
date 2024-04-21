using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;

namespace JornadaMilhas.API.core;

public static class CadastrarEndpoint
{
    public static void Register(IEndpointRegistry registry)
    {
        // Depoimentos
        registry.Register(new CriarDepoimentoEndpoint(), CriarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new ListarDepoimentoEndpoint(), ListarDepoimentoEndpoint.Execute);
    }
}
