using JornadaMilhas.API.core.Request;
using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.EditarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]

[JsonSerializable(typeof(CriarDepoimentoRequest))]
[JsonSerializable(typeof(CriarDepoimentoResponse))]

[JsonSerializable(typeof(EditarDepoimentoRequest))]
[JsonSerializable(typeof(EditarDepoimentoResponse))]

[JsonSerializable(typeof(ValueRequest<Guid>))]

[JsonSerializable(typeof(ListarDepoimentosResponse[]))]
public partial class DepoimentosContextSeralization : JsonSerializerContext { }