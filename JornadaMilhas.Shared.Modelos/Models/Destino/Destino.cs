﻿namespace JornadaMilhas.Shared.Models.Models.Destinos;

public class Destino
{
    public Destino(string nome, string meta)
    {
        Nome = nome;
        Meta = meta;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string? Foto1 { get; set; }
    public string? Foto2 { get; set; }
    public string Meta { get; set; }
    public string? TextoDescritivo { get; set; }
}
