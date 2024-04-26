namespace JornadaMilhas.API.Depoimentos.ListarDepoimentosRandomico;

public class ListarDepoimentosRandomicoResponse
{
    public ListarDepoimentosRandomicoResponse(Guid id, string? foto, string? texto, string nome)
    {
        Id = id;
        Foto = foto;
        Texto = texto;
        Nome = nome;
    }

    public Guid Id { get; set; }
    public string? Foto { get; set; }
    public string? Texto { get; set; }
    public string? Nome { get; set; }
}
