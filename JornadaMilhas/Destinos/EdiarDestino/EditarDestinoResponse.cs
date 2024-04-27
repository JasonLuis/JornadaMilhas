namespace JornadaMilhas.API.Destinos.EdiarDestino;

public record EditarDestinoResponse(Guid Id, string Nome, string Meta, string TextoDescritivo, string? Foto1 = "", string? Foto2 = "");

