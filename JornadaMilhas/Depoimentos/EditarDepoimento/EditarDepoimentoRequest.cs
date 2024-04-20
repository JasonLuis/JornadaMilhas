using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Depoimentos.EditarDepoimento;

public class EditarDepoimentoRequest
{
    public EditarDepoimentoRequest(int id, string nome, string texto, string? foto)
    {
        Nome = nome;
        Texto = texto;
        Foto = foto;
    }

    [Required]
    public string Id { get; set; }

    [Required]
    public string Nome { get; set; }
    [Required]
    public string Texto { get; set; }
    public string? Foto { get; set; }

}
