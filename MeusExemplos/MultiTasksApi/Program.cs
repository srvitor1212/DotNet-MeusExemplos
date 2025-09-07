using MultiTasksApi;
using LogApiTasks;
using MultiTasksApi.database;

var id = Guid.NewGuid();
Log.Write(id, "Program.cs inicio");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AdicionarSqlite();
builder.Services.AdicionarRepos();

// registra a classe de seed
builder.Services.AddTransient<SeedDataBase>();

var app = builder.Build();

// roda o seed após o build, mas antes do Run
using (var scope = app.Services.CreateScope())
{
    var seed = scope.ServiceProvider.GetRequiredService<SeedDataBase>();
    await seed.SeedCliente();
}

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

