using Azure.Core;
using Detran.Common.Core;
using JornadaMilhas.API.Common;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;

namespace JornadaMilhas.API.Depoimentos.CriarDepoimento;

public class CriarDepoimentoEndpoint() : EndpointBase(HttpMethod.Post)
{
    internal static async Task<CriarDepoimentoResponse> ExecuteAsync(IHostEnvironment env, CriarDepoimentoRequest request, DAL<Depoimento> dal)
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
        var res = dal.Adicionar(depoimento);

        var depoimentoResponse = new CriarDepoimentoResponse(res.Id, res.Nome, res.Texto);
        return depoimentoResponse;
    }

    public static ITaskWrapperType<CriarDepoimentoResponse> RequestAsync(IAppApiService client)
    {
        return client.RequestAsync(
            new CriarDepoimentoEndpoint(),
            DepoimentosContextSeralization.Default.CriarDepoimentoResponse
        );
    }
}
