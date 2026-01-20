
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
    IGNORADO ao PUBLICAR

    +++ appsettings +++
    É o arquivo principal de configuração da aplicação no ASP.NET Core.
    Ele define como a aplicação se comporta, e não como ela é executada (diferente do launchSettings.json).
    Ele pode conter: Strings de conexão, Configurações de log, Feature flags, Chaves de APIs, Timeouts, Qualquer parâmetro configurável
    USADO ao PUBLICAR

    +++ appsettings.{Environment} +++
    Vai sobreescrever o appsettings de acordo com o ambiente.
    Se DEV, appsettings.Development sobreescreve appsettings
    Se PRD, appsettings.Production sobreescreve appsettings
     */
    var get = new Get();

    return string.Join("\n",
        $"EnvironmentName: {builder.Environment.EnvironmentName}\n",
        get.launchSettings(),
        get.appsettings(builder),
        get.appsettingsDevelopment(builder)
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
        var EU_SOU = builder.Configuration["EU_SOU"];
        var DefaultConnection_GetConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        var DefaultConnection = builder.Configuration["ConnectionStrings:DefaultConnection"];
        var Logging_LogLevel_Default = builder.Configuration["Logging:LogLevel:Default"];
        var FeatureFlags_FeatUm = builder.Configuration["FeatureFlags:FeatUm"];
        var FeatureFlags_FeatDois = builder.Configuration["FeatureFlags:FeatDois"];
        return
            $"appsettings\n" +
            $"EU_SOU= [{EU_SOU ?? "é null"}]\n" +
            $"DefaultConnection_GetConnectionString= [{DefaultConnection_GetConnectionString ?? "é null"}]\n" +
            $"DefaultConnection= [{DefaultConnection ?? "é null"}]\n" +
            $"Logging_LogLevel_Default= [{Logging_LogLevel_Default ?? "é null"}]\n" +
            $"FeatureFlags_FeatUm= [{FeatureFlags_FeatUm ?? "é null"}]\n" +
            $"FeatureFlags_FeatDois= [{FeatureFlags_FeatDois ?? "é null"}]\n" +
            $"";
    }

    public string appsettingsDevelopment(WebApplicationBuilder builder)
    {
        var EU_SOU = builder.Configuration["EU_SOU"];
        var DefaultConnection_GetConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        var DefaultConnection = builder.Configuration["ConnectionStrings:DefaultConnection"];
        var Logging_LogLevel_Default = builder.Configuration["Logging:LogLevel:Default"];
        var FeatureFlags_FeatUm = builder.Configuration["FeatureFlags:FeatUm"];
        return
            $"appsettings\n" +
            $"EU_SOU= [{EU_SOU ?? "é null"}]\n" +
            $"DefaultConnection_GetConnectionString= [{DefaultConnection_GetConnectionString ?? "é null"}]\n" +
            $"DefaultConnection= [{DefaultConnection ?? "é null"}]\n" +
            $"Logging_LogLevel_Default= [{Logging_LogLevel_Default ?? "é null"}]\n" +
            $"FeatureFlags_FeatUm= [{FeatureFlags_FeatUm ?? "é null"}]\n" +
            $"";
    }


}
