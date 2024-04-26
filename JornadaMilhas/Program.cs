using JornadaMilhas.API;
using JornadaMilhas.API.core;
using JornadaMilhas.API.core.Endpoint;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;
using JornadaMilhas.Shared.Models.Models.Destinos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<JornadaMilhasContext>();
builder.Services.AddTransient<DAL<Depoimento>>();
builder.Services.AddTransient<DAL<Destino>>();


// builder.Services.AddScoped<IDepoimentoRepository, DepoimentoRepository>();
builder.Services.AddServiceApplicationContext();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<ExceptionToProblemDetailsHandler>();

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();

});

app.UseHttpsRedirection();
app.UseExceptionHandler();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapJornadaMilhasEndpoints
(
    CadastrarEndpoint.Register
);

app.UseHttpsRedirection();

app.Run();