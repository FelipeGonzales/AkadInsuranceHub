using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:5006");

// 🔹 Configuração do Ocelot
builder.Services.AddOcelot();

// 🔹 Configuração do Swagger (sem SwaggerForOcelot)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Gateway", Version = "v1" });

    // 🔹 Adicionando manualmente os serviços ao Swagger do API Gateway
    c.AddServer(new OpenApiServer { Url = "http://localhost:5048", Description = "Customer Service" });
    c.AddServer(new OpenApiServer { Url = "http://localhost:5058", Description = "Policy Service" });
    c.AddServer(new OpenApiServer { Url = "http://localhost:5247", Description = "Payment Service" });
});

var app = builder.Build();

// 🔹 Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("http://localhost:5048/swagger/v1/swagger.json", "Customer Service");
        c.SwaggerEndpoint("http://localhost:5058/swagger/v1/swagger.json", "Policy Service");
        c.SwaggerEndpoint("http://localhost:5247/swagger/v1/swagger.json", "Payment Service");
        c.RoutePrefix = "swagger"; // Acesse via http://localhost:5006/swagger
    });
}

// 🔹 Inicializa Ocelot
app.UseOcelot().Wait();
app.UseHttpsRedirection();
app.UseAuthorization();
app.Run();
