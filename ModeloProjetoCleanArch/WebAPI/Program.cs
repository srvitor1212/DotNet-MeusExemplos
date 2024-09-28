using Infra.Connect;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);



// Serviços padrão
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Meus Serviços
builder.Services.AplicarSqlServer(builder.Configuration);
builder.Services.AplicarServices();
builder.Services.AplicarRepositories();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



//Adicionar endpoints
app.AdicionarEndpoints();
// Executar migrations
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<MeuContext>())
    context!.Database.Migrate();
    



app.Run();
