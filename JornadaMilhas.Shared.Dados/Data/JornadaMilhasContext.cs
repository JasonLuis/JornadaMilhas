using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using JornadaMilhas.Shared.Models.Models.Destinos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
namespace JornadaMilhas.Shared.Dados.Data;

public class JornadaMilhasContext: DbContext
{

    public DbSet<Depoimento> Depoimentos { get; set; }
    public DbSet<Destino> Destinos { get; set; }

    public JornadaMilhasContext ()
    {}

    public JornadaMilhasContext(DbContextOptions options) : base(options)
    {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("key"); 
        if (connectionString.IsNullOrEmpty())
        {
            throw new Exception("Error, string connection empty");
        }
        optionsBuilder
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }


}
