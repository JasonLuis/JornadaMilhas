using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]

[JsonSerializable(typeof(ListarDepoimentosResponse[]))]
[JsonSerializable(typeof(CriarDepoimentoRequest))]
[JsonSerializable(typeof(CriarDepoimentoResponse))]
public partial class DepoimentosContextSeralization : JsonSerializerContext { }