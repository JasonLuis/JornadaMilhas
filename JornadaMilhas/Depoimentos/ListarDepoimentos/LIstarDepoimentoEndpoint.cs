using JornadaMilhas.API.Common;
using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.API.core.EndPoint;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using System.Collections.Generic;

namespace JornadaMilhas.API.Depoimentos.ListarDepoimentos;

public class ListarDepoimentoEndpoint() : QueryEndpoint<ListarDepoimentosResponse[]>(default!)
{

    //internal static ListarDepoimentosResponse[] Execute(DAL<Depoimento> dal) => 
    //{
    //    var listar = dal.Listar();

    //    ListarDepoimentosResponse[] depoimentos =
    //        listar.Select(x => new ListarDepoimentosResponse(x.Id, x.Foto, x.Texto, x.Nome)).ToArray();

    //    return depoimentos;
    //}

    internal static ListarDepoimentosResponse[] Execute(DAL<Depoimento> dal) =>
        dal.Listar().Select(x => new ListarDepoimentosResponse(x.Id, x.Foto, x.Texto, x.Nome)).ToArray();

}
