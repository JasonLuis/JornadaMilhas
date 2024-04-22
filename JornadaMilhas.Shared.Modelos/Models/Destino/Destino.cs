namespace JornadaMilhas.Shared.Models.Models.Destinos;

public class Destino
{
    public Destino(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string? Foto { get; set; }
}
