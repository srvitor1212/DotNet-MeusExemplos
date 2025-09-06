using MultiTasksApi;
using LogApiTasks;

var id = Guid.NewGuid();
Log.Write(id, "Program.cs inicio");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.AdicionarEndpoint();


Log.Write(id, "Program.cs run app");
await app.RunAsync();

