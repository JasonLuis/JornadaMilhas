namespace JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using JornadaMilhas.Shared.Models.Models.Destinos;

public interface IDestinoRepository
{
    Destino Adicionar(Destino destiono);

    Destino Atualizar(Destino destino);

    void Remover(Destino destino);
}
