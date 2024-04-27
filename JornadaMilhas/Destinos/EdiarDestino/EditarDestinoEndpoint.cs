using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.Helpers;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using JornadaMilhas.Shared.Models.Models.Destinos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Destinos.EdiarDestino;

public class EditarDestinoEndpoint() : UpdateEndpoint<EditarDestinoRequest>(default!, true, "Destino")
{

    internal static async Task<EditarDestinoResponse> ExecuteAsync(IHostEnvironment env, EditarDestinoRequest request, DAL<Destino> dal, IDestinoRepository repository)
    {
        var destino = dal.RecuperarPor(d => d.Id == request.Id);
        Throw.Http.BadRequest.When.Null(destino, "Destino não encontrada");

        destino!.Nome = request.Nome;
        destino.Foto1 = await UploadFile.Upload(request.Foto1, env);
        destino.Foto2 = await UploadFile.Upload(request.Foto2, env);
        destino.Meta = request.Meta;
        destino.TextoDescritivo = request.TextoDescritivo;

        var response = repository.Atualizar(destino);

        return new EditarDestinoResponse(destino.Id, destino.Nome, destino.Meta, destino.TextoDescritivo, destino.Foto1, destino.Foto2);
    }
}
