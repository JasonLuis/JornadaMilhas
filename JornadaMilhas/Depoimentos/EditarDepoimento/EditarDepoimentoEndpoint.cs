using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Depoimentos.EditarDepoimento;

public class EditarDepoimentoEndpoint() : UpdateEndpoint<EditarDepoimentoRequest>(default!, true)
{
    internal static async Task<EditarDepoimentoResponse> ExecuteAsync(IHostEnvironment env, EditarDepoimentoRequest request, DAL<Depoimento> dal, IDepoimentoRepository depoimentoRepository)
    {

        var depoimento = dal.RecuperarPor(d => d.Id == request.Id);
        Throw.When.Null(depoimento, "depoimento não encontrado");

        string foto = "";

        if (request.Foto is not null)
        {
            var nome = request.Foto.Trim();
            foto = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpeg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "Fotos", foto);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(request.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);
            depoimento!.Foto = foto;
        }

        depoimento!.Nome = request.Nome;
        depoimento.Texto = request.Texto;

        var response = depoimentoRepository.Atualizar(depoimento);

        return new EditarDepoimentoResponse(response.Id, response.Nome, response.Texto, response.Foto);
    }
}
