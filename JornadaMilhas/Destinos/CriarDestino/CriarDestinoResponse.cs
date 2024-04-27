namespace JornadaMilhas.API.Destinos.CriarDestinos;

public record CriarDestinoResponse(Guid Id, string Nome, string? Foto1, string? Foto2, string Meta, string? TextoDescritivo);
