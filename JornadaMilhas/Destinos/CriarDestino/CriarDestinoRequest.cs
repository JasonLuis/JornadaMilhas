using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Destinos.CriarDestinos;

public class CriarDestinoRequest
{
    public CriarDestinoRequest(string nome, string meta)
    {
        Nome = nome;
        Meta = meta;
    }

    [Required]
    public string Nome { get; set; }
    public string? Foto1 { get; set; }
    public string? Foto2 { get; set; }
    [Required]
    public string Meta { get; set; }
    public string? TextoDescritivo { get; set; }
}
