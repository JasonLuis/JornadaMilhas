using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Destinos.EdiarDestino;

public class EditarDestinoRequest
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public double Preco { get; set; }
    public string? Foto {  get; set; }
}
