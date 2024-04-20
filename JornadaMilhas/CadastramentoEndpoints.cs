using JornadaMilhas.API.Common;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;

namespace JornadaMilhas.API;

public static class CadastramentoEndpoints
{
    public static void MapCadastramentoEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints
            .MapJornadaMilhasEndpoint(
                new ListarDepoimentoEndpoint(),
                ListarDepoimentoEndpoint.Execute);
            //.MapJornadaMilhasEndpoint(
            //    new CriarDepoimentoEndpoint(),
            //    CriarDepoimentoEndpoint.ExecuteAsync);
    }
}