using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.core.Request;
using JornadaMilhas.API.Destinos.BuscarDestino;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Models.Models.Destinos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Destinos.BuscarDestinoPorId;

public class BuscarDestinoPorIdEndpoint(): QueryEndpoint<BuscarDestinoPorIdResponse, ValueRequest<string>>(default!, true, "Destino")
{

    internal static BuscarDestinoPorIdResponse Execute([AsParameters] ValueRequest<string> id, DAL<Destino> dal)
    {
        Guid idDestino = Guid.Parse(id);
        var response = dal.RecuperarPor(d => d.Id.Equals(idDestino));

        Throw.Http.NotFound.When.Null(response, "Destino não encontrado");

        return new BuscarDestinoPorIdResponse(response.Id, response.Foto1!, response.Foto2!, response.Nome, response.Meta, response.TextoDescritivo!);
    }
}
