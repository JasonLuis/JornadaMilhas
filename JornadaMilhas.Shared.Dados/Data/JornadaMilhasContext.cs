using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using Microsoft.EntityFrameworkCore;
namespace JornadaMilhas.Shared.Dados.Data;

public class JornadaMilhasContext: DbContext
{

    public DbSet<Depoimento> Depoimentos { get; set; }

    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JornadaMilhasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public JornadaMilhasContext ()
    {

    }

    public JornadaMilhasContext(DbContextOptions options) : base(options)
    {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }


}
