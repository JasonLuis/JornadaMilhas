namespace JornadaMilhas.API.Depoimentos.ListarDepoimentos;

public class ListarDepoimentosResponse
{
    public ListarDepoimentosResponse(Guid id, string? foto, string? texto, string nome)
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
