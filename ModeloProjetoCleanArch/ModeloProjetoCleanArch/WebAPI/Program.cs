var builder = WebApplication.CreateBuilder(args);



// Servi�os padr�o
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Meus Servi�os
//..



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();