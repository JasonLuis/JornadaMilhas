namespace JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using JornadaMilhas.Shared.Models.Models.Destinos;

internal class DestinoRepository(DAL<Destino> dal): IDestinoRepository
{
    public Destino Adicionar(Destino destiono) =>
        dal.Adicionar(destiono);

    public Destino Atualizar(Destino destino) =>
        dal.Atualizar(destino);

   public void Remover(Destino destino) =>
        dal.Remover(destino);
}
