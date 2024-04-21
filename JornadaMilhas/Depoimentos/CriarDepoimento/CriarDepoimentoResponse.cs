namespace JornadaMilhas.API.Depoimentos.CriarDepoimento;

public record CriarDepoimentoResponse(Guid Id, string Nome, string Texto, string? Foto = "");