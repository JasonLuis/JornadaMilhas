using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using JornadaMilhas.Shared.Models.Models.Destinos;

namespace JornadaMilhas.API.Destinos.CriarDestinos;

public class CriarDestinoEndpoint(): CommandEndpoint<CriarDestinoRequest>(default!, true)
{

    internal static async Task<CriarDestinoResponse> ExecuteAsync(IHostEnvironment env, CriarDestinoRequest request, IDestinoRepository destinoRepository)
    {
        string foto = "";

        if (request.Foto is not null)
        {
            var nome = request.Foto.Trim();
            foto = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpeg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "Fotos", foto);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(request.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);
        }

        var destino = new Destino(request.Nome, request.Preco)
        {
            Foto = foto,
        };

        var response = destinoRepository.Adicionar(destino);

        return new CriarDestinoResponse(response.Id, response.Nome, response.Preco, response.Foto);
    }
}
