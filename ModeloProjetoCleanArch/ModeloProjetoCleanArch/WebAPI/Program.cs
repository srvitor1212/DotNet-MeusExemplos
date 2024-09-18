using WebAPI;

var builder = WebApplication.CreateBuilder(args);



// Serviços padrão
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Meus Serviços
builder.Services.AplicarSqlServer(builder.Configuration);



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
