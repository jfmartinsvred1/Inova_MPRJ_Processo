using Desafio_Backend.Interfaces;
using Desafio_Backend.Profiles;
using Desafio_Backend.Rest;
using Desafio_Backend.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inversão de dependência.(CONCEITO SOLID)
builder.Services.AddSingleton<ICepService, CepService>();
builder.Services.AddSingleton<IViaCepApi, ViaCepRest>();
builder.Services.AddSingleton<ICorretoraService, CorretoraService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();
builder.Services.AddSingleton<IFeriadoService, FeriadoService>();


//Adicionando o Mapping
builder.Services.AddAutoMapper(typeof(CepMapping));
builder.Services.AddAutoMapper(typeof(CorretoraMapping));
builder.Services.AddAutoMapper(typeof(FeriadoMapping));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
