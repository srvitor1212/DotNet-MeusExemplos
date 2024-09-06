using Application.Features;
using Infra.Connect;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();




//Adicionar meus serviços
builder.Services.AdicionarSqlServer(builder.Configuration);
builder.Services.AddScoped<HelloWorld>();




var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();




//Adicionar os endpoints
app.AdicinarEndpoints();




app.Run();