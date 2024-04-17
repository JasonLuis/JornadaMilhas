using JornadaMilhas.API.Depoimentos.CriarDepoimento;
using JornadaMilhas.API.Depoimentos.ListarDepoimentos;
using System.Text.Json.Serialization;

namespace JornadaMilhas.API;

[JsonSerializable(typeof(ListarDepoimentosResponse[]))]
[JsonSerializable(typeof(CriarDepoimentoRequest))]
[JsonSerializable(typeof(CriarDepoimentoResponse))]
public partial class DepoimentosContextSeralization : JsonSerializerContext { }