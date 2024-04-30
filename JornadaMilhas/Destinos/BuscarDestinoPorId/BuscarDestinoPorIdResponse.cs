using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Destinos.BuscarDestinoPorId;

public class BuscarDestinoPorIdResponse
{
    public BuscarDestinoPorIdResponse(Guid id, string foto1, string foto2, string nome, string meta, string textoDescritivo)
    {
        Id = id;
        Foto1 = foto1;
        Foto2 = foto2;
        Nome = nome;
        Meta = meta;
        TextoDescritivo = textoDescritivo;
    }

    [Required]
    public Guid Id { get; set; }
    public string? Foto1 {  get; set; }
    public string? Foto2 {  get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Meta { get; set; }
    public string? TextoDescritivo { get; set;}

}
