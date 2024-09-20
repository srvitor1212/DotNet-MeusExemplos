using Infra.Connect;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);



// Servi�os padr�o
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Meus Servi�os
builder.Services.AplicarSqlServer(builder.Configuration);
builder.Services.AplicarServices();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



//Adicionar endpoints
app.AdicionarEndpoints();



app.Run();
