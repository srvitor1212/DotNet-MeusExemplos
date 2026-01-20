
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/start-endpoint", () => 
{
    /* 
    +++ launchSettings +++
    Serve apenas para desenvolvimento local.
    Não é lido diretamente. O ASP.NET Core é quem lê e cria variáveis de ambiente e configurações
    Usado por: Visual Studio, dotnet run
    IGNORADO em PRODUÇÃO

    +++ appsettings +++
    É o arquivo principal de configuração da aplicação no ASP.NET Core.
    Ele define como a aplicação se comporta, e não como ela é executada (diferente do launchSettings.json).
    Ele pode conter: Strings de conexão, Configurações de log, Feature flags, Chaves de APIs, Timeouts, Qualquer parâmetro configurável
    
     */
    var get = new Get();

    return string.Join("\n",
        get.launchSettings(),
        get.appsettings(builder)
        );
});

app.Run();

class Get
{
    public string launchSettings()
    {
        var VAR_TESTE_LAUNCH = Environment.GetEnvironmentVariable("VAR_TESTE_LAUNCH");
        var ASPNETCORE_ENVIRONMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var VAR_TESTE_LAUNCH_FORA_environmentVariables = Environment.GetEnvironmentVariable("VAR_TESTE_LAUNCH_FORA");
        return
            $"launchSettings\n" +
            $"VAR_TESTE_LAUNCH= [{VAR_TESTE_LAUNCH ?? "é null"}]\n" +
            $"ASPNETCORE_ENVIRONMENT= [{ASPNETCORE_ENVIRONMENT ?? "é null"}]\n" +
            $"VAR_TESTE_LAUNCH_FORA_environmentVariables= [{VAR_TESTE_LAUNCH_FORA_environmentVariables ?? "é null"}]\n";
    }

    public string appsettings(WebApplicationBuilder builder)
    {
        var DefaultConnection_GetConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        var DefaultConnection = builder.Configuration["ConnectionStrings:DefaultConnection"];
        var Logging_LogLevel_Default = builder.Configuration["Logging:LogLevel:Default"];
        return
            $"appsettings\n" +
            $"DefaultConnection_GetConnectionString= [{DefaultConnection_GetConnectionString ?? "é null"}]\n" +
            $"DefaultConnection= [{DefaultConnection ?? "é null"}]\n" +
            $"Logging_LogLevel_Default= [{Logging_LogLevel_Default ?? "é null"}]\n";
    }
}
