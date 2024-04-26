using JornadaMilhas.API.core.Endpoint;
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

        string foto = "";

        if (request.Foto is not null)
        {
            var nome = request.Foto.Trim();
            foto = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpeg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "Fotos", foto);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(request.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);
            destino!.Foto = foto;
        }

        destino!.Nome = request.Nome;
        destino.Preco = request.Preco;

        var response = repository.Atualizar(destino);

        return new EditarDestinoResponse(response.Id, response.Nome, response.Preco, response.Foto);
    }
}
