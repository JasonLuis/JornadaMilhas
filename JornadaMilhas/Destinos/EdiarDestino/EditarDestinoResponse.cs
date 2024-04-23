namespace JornadaMilhas.API.Destinos.EdiarDestino;

public record EditarDestinoResponse(Guid Id, string Nome, Double preco, string? Foto = "");

