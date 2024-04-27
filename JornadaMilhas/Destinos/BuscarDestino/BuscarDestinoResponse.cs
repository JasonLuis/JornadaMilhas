namespace JornadaMilhas.API.Destinos.BuscarDestino;

public class BuscarDestinoResponse
{
    public BuscarDestinoResponse(Guid id, string nome, string? foto1, string? foto2, string meta, string textoDescritivo)
    {
        Id = id;
        Nome = nome;
        Foto1 = foto1;
        Foto2 = foto2;
        Meta = meta;
        TextoDescritivo = textoDescritivo;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string? Foto1 { get; set; }
    public string? Foto2 { get; set; }
    public string Meta { get; set; }
    public string TextoDescritivo { get; set; }

}
