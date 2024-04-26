using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.core.Request;
using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using JornadaMilhas.Shared.Models.Models.Destinos;
using JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Destinos.DeletarDestino;

public class DeletarDestinoEndpoint() : DeleteEndpoint<ValueRequest<Guid>>(default!, true, "Destino")
{
    internal static void ExecuteAsync([AsParameters] ValueRequest<Guid> id, DAL<Destino> dal, IDestinoRepository destinoRepository)
    {
        var destino = dal.RecuperarPor(a => a.Id == id.Value);

        //Throw.When.Null(destino, "Destino não encontrado");
        if(destino is null)
        {
            Throw.Http.BadRequest.When.Null(destino, "Pessoa física não encontrada");
        }
        
        destinoRepository.Remover(destino);
    }
}