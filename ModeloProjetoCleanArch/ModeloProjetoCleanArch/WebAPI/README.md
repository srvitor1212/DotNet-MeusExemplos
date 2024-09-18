

	1 - Abrir o power shell na pasta raiz
Exemplo: ~\DotNet-MeusExemplos\ModeloProjetoCleanArch\ModeloProjetoCleanArch

	2 - Instalar os pacotes necessários
dotnet add .\WebAPI\WebAPI.csproj package Microsoft.EntityFrameworkCore.SqlServer
dotnet add .\WebAPI\WebAPI.csproj package Microsoft.EntityFrameworkCore.Tools
dotnet add .\WebAPI\WebAPI.csproj package Microsoft.EntityFrameworkCore.Design

	3 - Criar uma migration
dotnet ef migrations add Teste --project .\WebAPI\WebAPI.csproj

	4 - Atualizar o banco de dados
dotnet ef database update --project .\WebAPI\WebAPI.csproj