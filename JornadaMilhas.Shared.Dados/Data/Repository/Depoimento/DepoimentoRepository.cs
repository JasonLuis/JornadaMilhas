namespace JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
internal class DepoimentoRepository(DAL<Depoimento> dal) : IDepoimentoRepository
{
   

    public Depoimento Adicionar(Depoimento depoimento) =>
        dal.Adicionar(depoimento);

    public Depoimento Atualizar(Depoimento depoimento) =>
        dal.Atualizar(depoimento);

    public void Remover(Depoimento depoimento) =>
        dal.Remover(depoimento);
}
