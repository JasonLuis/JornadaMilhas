using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Destinos.CriarDestinos;

public class CriarDestinoRequest
{
    public CriarDestinoRequest(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    [Required]
    public string Nome { get; set; }
    [Required]
    public double Preco { get; set; }
    public string? Foto { get; set; }
}
