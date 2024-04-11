using Microsoft.EntityFrameworkCore;
using MinimalApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContextDb>(opt => opt.UseInMemoryDatabase("DBTodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();



// Adiciona os endpoints
app.AddEndpoints();



app.Run();