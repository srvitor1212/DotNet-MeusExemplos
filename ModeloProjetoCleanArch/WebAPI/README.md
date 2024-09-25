
	1 - Instalação de pacotes
	1.1 - Acessar o diretório correto (Developer PowerShell)
No diretório raiz, mesmo diretório da solution exemplo: ~\DotNet-MeusExemplos\ModeloProjetoCleanArch

	2 - Pacotes para (Infra.Connect)
dotnet add .\Infra.Connect\Infra.Connect.csproj package Microsoft.Extensions.DependencyInjection
dotnet add .\Infra.Connect\Infra.Connect.csproj package Microsoft.Extensions.Configuration

	3 - Pacotes para (Infra.Data)
dotnet add .\Infra.Data\Infra.Data.csproj package Microsoft.EntityFrameworkCore.SqlServer
dotnet add .\Infra.Data\Infra.Data.csproj package Microsoft.EntityFrameworkCore.Tools
dotnet add .\Infra.Data\Infra.Data.csproj package Microsoft.EntityFrameworkCore.Design



	1 - Entity framework core
	1.1 - Acessar o diretório correto (Developer PowerShell)
No diretório raiz, exemplo: ~\DotNet-MeusExemplos\ModeloProjetoCleanArch>

	2 - Criar uma migration
dotnet ef migrations add NomeDaMigration --project .\Infra.Data\Infra.Data.csproj --startup-project .\WebAPI\WebAPI.csproj

	3 - Atualizar o banco de dados
dotnet ef database update --project .\Infra.Data\Infra.Data.csproj --startup-project .\WebAPI\WebAPI.csproj

	- Remover a última migration
dotnet ef migrations remove --project .\Infra.Data\Infra.Data.csproj --startup-project .\WebAPI\WebAPI.csproj
