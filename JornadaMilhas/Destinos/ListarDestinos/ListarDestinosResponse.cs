using JornadaMilhas.API.core.EndPoint;

namespace JornadaMilhas.API.Destinos.ListarDestinos;

public class ListarDestinosResponse
{
    public ListarDestinosResponse(Guid id, string nome, double preco, string? foto = "")
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Foto = foto;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string? Foto { get; set; }
}
