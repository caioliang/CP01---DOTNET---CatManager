using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Application.Interfaces;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Adicionar DbContext com Oracle
builder.Services.AddDbContext<CatContext>(opts =>
    opts.UseOracle(builder.Configuration.GetConnectionString("OracleDb")));

// 2. Registrar serviços de aplicação (SOLID: DIP)
builder.Services.AddScoped<ICatService, CatService>();

// 3. Adicionar controllers e habilitar Swagger/OpenAPI
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4. Configurar pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiOracleCats v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

// 5. Mapear Controllers (rotas de API)
app.MapControllers();

app.Run();
