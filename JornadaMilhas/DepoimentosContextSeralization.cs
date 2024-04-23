using JornadaMilhas.API.core.Request;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.EditarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using JornadaMilhas.API.Depoimentos.ListarDepoimentosRandomico;
using JornadaMilhas.API.Destinos.CriarDestinos;
using JornadaMilhas.API.Destinos.EdiarDestino;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]

[JsonSerializable(typeof(CriarDepoimentoRequest))]
[JsonSerializable(typeof(CriarDepoimentoResponse))]

[JsonSerializable(typeof(EditarDepoimentoRequest))]
[JsonSerializable(typeof(EditarDepoimentoResponse))]

[JsonSerializable(typeof(ValueRequest<Guid>))]

[JsonSerializable(typeof(ListarDepoimentosResponse[]))]
[JsonSerializable(typeof(ListarDepoimentoRandomicoResponse[]))]

// Destino
[JsonSerializable(typeof(CriarDestinoRequest))]
[JsonSerializable(typeof(CriarDestinoResponse))]

[JsonSerializable(typeof(EditarDestinoRequest))]
[JsonSerializable(typeof(EditarDestinoResponse))]


public partial class DepoimentosContextSeralization : JsonSerializerContext { }