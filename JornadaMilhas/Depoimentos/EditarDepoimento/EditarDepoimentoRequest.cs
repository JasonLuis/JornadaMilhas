using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Depoimentos.EditarDepoimento;

public class EditarDepoimentoRequest
{
    public EditarDepoimentoRequest(Guid id, string nome, string texto)
    {
        Id = id;
        Nome = nome;
        Texto = texto;
    }

    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Nome { get; set; }
    [Required]
    public string Texto { get; set; }
    public string? Foto { get; set; }

}
