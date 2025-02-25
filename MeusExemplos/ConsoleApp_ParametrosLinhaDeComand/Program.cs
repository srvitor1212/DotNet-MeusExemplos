

Console.WriteLine(">>> Executando o programa");

foreach(string arg in args)
    Console.WriteLine($"parâmetro recebido: [{arg}]");

Console.WriteLine(">>> Fim");

return 99;

/*

Para executar esse projeto precisa publicar ele e gerar um .exe

Depois acessar:
ConsoleApp_ParametrosLinhaDeComand\bin\Release\net8.0

Exemplo de comando:
ConsoleApp_ParametrosLinhaDeComand.exe maria caio vitor 200 400 teste

Exemplo de comando recuperando status:
no power shell: $LastExitCode
no prompt: %ERRORLEVEL%

 */