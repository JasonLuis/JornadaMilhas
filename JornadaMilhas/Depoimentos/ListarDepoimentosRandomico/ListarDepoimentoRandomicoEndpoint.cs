using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using System;

namespace JornadaMilhas.API.Depoimentos.ListarDepoimentosRandomico;

public class ListarDepoimentoRandomicoEndpoint() : QueryEndpoint<ListarDepoimentoRandomicoResponse[]>(default!, true)
{
    internal static ListarDepoimentoRandomicoResponse[] Execute(DAL<Depoimento> dal)
    {
        Random random = new Random();
        var depoimentos = dal.Listar()
            .Select(x => new ListarDepoimentoRandomicoResponse(x.Id, x.Foto, x.Texto, x.Nome))
            .OrderBy(x => random.Next()).Take(3).ToArray();

        return depoimentos;
    }

}
