using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using JornadaMilhas.Shared.Models.Models.Destinos;

namespace JornadaMilhas.API.Destinos.ListarDestinos;

public class ListarDestinosEndpoint() : QueryEndpoint<ListarDestinosResponse[]>(default!, true, "Destino")
{

    internal static ListarDestinosResponse[] Execute(DAL<Destino> dal) =>
        dal.Listar().Select(x => new ListarDestinosResponse(x.Id, x.Nome, x.Preco, x.Foto)).ToArray();
}
