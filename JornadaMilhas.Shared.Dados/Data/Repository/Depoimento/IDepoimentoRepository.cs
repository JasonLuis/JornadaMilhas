namespace JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;

public interface IDepoimentoRepository
{
    Depoimento Adicionar(Depoimento depoimento);

    Depoimento Atualizar(Depoimento depoimento);

    void Remover(Depoimento depoimento);
}
