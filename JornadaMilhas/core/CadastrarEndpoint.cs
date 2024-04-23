using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.DeletarDepoimento;
using JornadaMilhas.API.Depoimentos.EditarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using JornadaMilhas.API.Depoimentos.ListarDepoimentosRandomico;
using JornadaMilhas.API.Destinos.CriarDestinos;

namespace JornadaMilhas.API.core;

public static class CadastrarEndpoint
{
    public static void Register(IEndpointRegistry registry)
    {
        // Depoimentos
        registry.Register(new CriarDepoimentoEndpoint(), CriarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new EditarDepoimentoEndpoint(), EditarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new ListarDepoimentoEndpoint(), ListarDepoimentoEndpoint.Execute);
        registry.Register(new DeletarDepoimentoEndpoint(), DeletarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new ListarDepoimentoRandomicoEndpoint(), ListarDepoimentoRandomicoEndpoint.Execute);

        //Destinos
        registry.Register(new CriarDestinoEndpoint(), CriarDestinoEndpoint.ExecuteAsync);
    }
}
