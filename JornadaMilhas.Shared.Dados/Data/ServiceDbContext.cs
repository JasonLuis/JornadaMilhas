using JornadaMilhas.Shared.Dados.Data.Repository.Depoimento;
using JornadaMilhas.Shared.Dados.Data.Repository.Destino;
using Microsoft.Extensions.DependencyInjection;


namespace JornadaMilhas.Shared.Dados.Data;

public static class ServiceDbContext
{
    public static void AddServiceApplicationContext(this IServiceCollection services)
    {
        services.AddScoped<IDepoimentoRepository, DepoimentoRepository>();
        services.AddScoped<IDestinoRepository, DestinoRepository>();
    }
}
