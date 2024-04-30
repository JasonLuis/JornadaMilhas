using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.Helpers;
using JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using JornadaMilhas.Shared.Models.Models.Destinos;
using Microsoft.IdentityModel.Tokens;

namespace JornadaMilhas.API.Destinos.CriarDestinos;

public class CriarDestinoEndpoint(): CommandEndpoint<CriarDestinoRequest>(default!, true, "Destino")
{

    internal static async Task<CriarDestinoResponse> ExecuteAsync(IHostEnvironment env, CriarDestinoRequest request, IDestinoRepository destinoRepository)
    {


        var destino = new Destino(request.Nome, request.Meta)
        {
            Foto1 = await UploadFile.Upload(request.Foto1, env),
            Foto2 = await UploadFile.Upload(request.Foto2, env),
            TextoDescritivo = request.TextoDescritivo.IsNullOrEmpty() 
            ? await GerarTextoDescritivo.GerarTexto(request.Nome, 120)
            : null,
        };

        var response = destinoRepository.Adicionar(destino);

        return new CriarDestinoResponse(response.Id, response.Nome, response.Foto1, response.Foto2, response.Meta, response.TextoDescritivo);
    }
}
