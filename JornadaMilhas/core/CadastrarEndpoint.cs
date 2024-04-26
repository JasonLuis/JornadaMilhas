using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.DeletarDepoimento;
using JornadaMilhas.API.Depoimentos.EditarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using JornadaMilhas.API.Depoimentos.ListarDepoimentosRandomico;
using JornadaMilhas.API.Destinos.BuscarDestino;
using JornadaMilhas.API.Destinos.CriarDestinos;
using JornadaMilhas.API.Destinos.DeletarDestino;
using JornadaMilhas.API.Destinos.EdiarDestino;
using JornadaMilhas.API.Destinos.ListarDestinos;

namespace JornadaMilhas.API.core;

public static class CadastrarEndpoint
{
    public static void Register(IEndpointRegistry registry)
    {
        // Depoimentos
        registry.Register(new CriarDepoimentoEndpoint(), CriarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new DeletarDepoimentoEndpoint(), DeletarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new EditarDepoimentoEndpoint(), EditarDepoimentoEndpoint.ExecuteAsync);
        registry.Register(new ListarDepoimentosEndpoint(), ListarDepoimentosEndpoint.Execute);
        registry.Register(new ListarDepoimentosRandomicoEndpoint(), ListarDepoimentosRandomicoEndpoint.Execute);

        //Destinos
        registry.Register(new CriarDestinoEndpoint(), CriarDestinoEndpoint.ExecuteAsync);
        registry.Register(new DeletarDestinoEndpoint(), DeletarDestinoEndpoint.ExecuteAsync);
        registry.Register(new EditarDestinoEndpoint(), EditarDestinoEndpoint.ExecuteAsync);
        registry.Register(new ListarDestinosEndpoint(), ListarDestinosEndpoint.Execute);
        registry.Register(new BuscarDestinoEndpoint(), BuscarDestinoEndpoint.Execute);
    }
}
