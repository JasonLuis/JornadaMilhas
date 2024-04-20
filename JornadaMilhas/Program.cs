using JornadaMilhas.API;
using JornadaMilhas.API.core;
using JornadaMilhas.Shared.Dados.Data;
using JornadaMilhas.Shared.Modelos.Models.Depoimentos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<JornadaMilhasContext>();
builder.Services.AddTransient<DAL<Depoimento>>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapCadastramentoEndpoints();

app.MapJornadaMilhasEndpoints
(
    CadastrarEndpoint.Register
);

app.UseHttpsRedirection();

app.Run();