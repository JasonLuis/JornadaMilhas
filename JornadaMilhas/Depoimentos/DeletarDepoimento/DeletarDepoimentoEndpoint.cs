using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.core.Request;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Depoimentos.DeletarDepoimento;

public class DeletarDepoimentoEndpoint() : DeleteEndpoint<ValueRequest<Guid>>(default!, true, "Depoimentos")
{
    internal static void ExecuteAsync([AsParameters] ValueRequest<Guid> id, DAL<Depoimento> dal, IDepoimentoRepository depoimentoRepository)
    {
        var depoimento = dal.RecuperarPor(a => a.Id == id.Value);

        Throw.Http.BadRequest.When.Null(depoimento, "depoimento não encontrado");

        depoimentoRepository.Remover(depoimento);
    }
}
