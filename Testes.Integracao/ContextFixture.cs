using JornadaMilhas.Shared.Dados.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Testcontainers.MsSql;

namespace Testes.Integracao;

public class ContextFixture: IAsyncLifetime
{

    public JornadaMilhasContext Context { get; private set; }
    private MsSqlContainer _msSqlContainer;
    private readonly IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

    public async Task InitializeAsync()
    {
        var connectionString = configuration.GetConnectionString("mssqlconnection");

        if (connectionString.IsNullOrEmpty())
        {
            throw new Exception("Error, string connection empty");
        }

        _msSqlContainer = new MsSqlBuilder()
            .WithImage(connectionString)
            .Build();

        await _msSqlContainer.StartAsync();
        
        var options = new DbContextOptionsBuilder<JornadaMilhasContext>
            ()
            .UseSqlServer(_msSqlContainer.GetConnectionString())
            .Options;

        Context = new JornadaMilhasContext(options);
        Context.Database.Migrate();
    }

    public async Task DisposeAsync()
    {
        await _msSqlContainer.StopAsync();
    }
}
