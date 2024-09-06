using AutoBogus;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using Xunit.Abstractions;

namespace Testes.Integracao;

[Collection(nameof(ContextCollection))]
public class DepoimentoDal
{
    private readonly JornadaMilhasContext context;

    public DepoimentoDal(ITestOutputHelper output, ContextFixture fixture)
    {
        context = fixture.Context;
        output.WriteLine(context.GetHashCode().ToString());
    }

    [Fact]
    public void RecuperarDepoimentosNoBanco()
    {
        //arrage
        var dal = new DAL<Depoimento>(context);

        //act
        var depoimentos = dal.Listar();

        //assert
        Assert.NotNull(depoimentos);
        Assert.NotEmpty(depoimentos);
    }

    [Fact]
    public void CriarDepoimento()
    {
        //arrage
        var dal = new DAL<Depoimento>(context);
        var depoimento = AutoFaker.Generate<Depoimento>();

        //act
        var depoimentoAdicionado = dal.Adicionar(depoimento);

        //assert
        Assert.NotEqual(Guid.Empty, depoimentoAdicionado.Id);
    }
}