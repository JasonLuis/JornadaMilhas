using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.core.Request;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Models.Models.Destinos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Destinos.BuscarDestino;

public class BuscarDestinoEndpoint(): QueryEndpoint<BuscarDestinoResponse,ValueRequest<string>>(default!, true, "Destino")
{

    internal static BuscarDestinoResponse Execute([AsParameters] ValueRequest<string> nome, DAL<Destino> dal) 
    { 
        var destino = dal.RecuperarPor(x => x.Nome.ToUpper().Equals(nome.ToString().ToUpper()));
        Throw.Http.NotFound.When.Null(destino, "Nenhum destino foi encontrado");

        return new BuscarDestinoResponse(destino.Id, destino.Nome, destino.Preco, destino.Foto);
    }
}
