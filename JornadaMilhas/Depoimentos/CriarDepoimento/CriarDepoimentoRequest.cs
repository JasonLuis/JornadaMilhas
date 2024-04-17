using System.ComponentModel.DataAnnotations;

namespace JornadaMilhas.API.Depoimentos.CriarDepoimento;

public class CriarDepoimentoRequest
{
    public CriarDepoimentoRequest(string nome, string texto, string? foto)
    {
        Nome = nome;
        Texto = texto;
        Foto = foto;
    }


    [Required]
    public string Nome { get; set; }
    [Required]
    public string Texto { get; set; }
    public string? Foto { get; set; }

}
