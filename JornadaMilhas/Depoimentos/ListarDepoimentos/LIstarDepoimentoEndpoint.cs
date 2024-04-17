using JornadaMilhas.API.Common;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;

namespace JornadaMilhas.API.Depoimentos.ListarDepoimentos;

public class ListarDepoimentoEndpoint() : EndpointBase(HttpMethod.Get)
{

    internal static ListarDepoimentosResponse[] Execute(DAL<Depoimento> dal)
    {
        var listar = dal.Listar();

        ListarDepoimentosResponse[] depoimentos =
            listar.Select(x => new ListarDepoimentosResponse(x.Id, x.Foto, x.Texto, x.Nome)).ToArray();

        return depoimentos;
    }

    public static ITaskWrapperType<ListarDepoimentosResponse[]> RequestAsync(IAppApiService client)
    {
        return client.RequestAsync(
            new ListarDepoimentoEndpoint(),
            DepoimentosContextSeralization.Default.ListarDepoimentosResponseArray
        )!;
    }
}
