namespace JornadaMilhas.Shared.Modelos.Models.Depoimentos;

public class Depoimento
{


    public Depoimento() { }


    public Depoimento(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }

    public Guid Id { get; set; }

    public string Nome { get; set; }
    public string Texto { get; set; }
    public string? Foto { get; set; }

}
