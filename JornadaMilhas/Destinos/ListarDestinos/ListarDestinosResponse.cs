using JornadaMilhas.API.core.EndPoint;
using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Destinos.ListarDestinos;

public class ListarDestinosResponse
{
    public ListarDestinosResponse(Guid id, string nome, string? foto1, string? foto2, string meta, string textoDescritivo)
    {
        Id = id;
        Nome = nome;
        Foto1 = foto1;
        Foto2 = foto2;
        Meta = meta;
        TextoDescritivo = textoDescritivo;
    }

    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string? Foto1 { get; set; }
    [Required]
    public string? Foto2 { get; set; }
    [Required]
    public string Meta { get; set; }
    [Required]
    public string TextoDescritivo { get; set;}
}
