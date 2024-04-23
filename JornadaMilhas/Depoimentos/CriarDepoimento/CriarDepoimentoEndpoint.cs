using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;

namespace JornadaMilhas.API.Depoimentos.CriarDepoimento;

public class CriarDepoimentoEndpoint() : CommandEndpoint<CriarDepoimentoRequest>(default!, true)
{
    internal static async Task<CriarDepoimentoResponse> ExecuteAsync(IHostEnvironment env, CriarDepoimentoRequest request, IDepoimentoRepository DepoimentoRepository)
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

        var depoimento = new Depoimento(request.Nome, request.Texto)
        {
            Foto = foto,
        };
        var response = DepoimentoRepository.Adicionar(depoimento);

        return new CriarDepoimentoResponse(response.Id, response.Nome, response.Texto, response.Foto);
    }
}
