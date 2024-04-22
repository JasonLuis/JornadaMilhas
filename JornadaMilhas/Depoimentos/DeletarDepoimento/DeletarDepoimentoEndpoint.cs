using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.core.Request;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using Menso.Tools.Exceptions;

namespace JornadaMilhas.API.Depoimentos.DeletarDepoimento;

public class DeletarDepoimentoEndpoint() : DeleteEndpoint<ValueRequest<Guid>>(default!)
{
    internal static void ExecuteAsync([AsParameters] ValueRequest<Guid> id, DAL<Depoimento> dal)
    {
        var depoimento = dal.RecuperarPor(a => a.Id == id.Value);

        if (depoimento is null)
        {
            Throw.When.Null(depoimento, "depoimento não encontrado");
        }

        dal.Remover(depoimento);
    }
}
