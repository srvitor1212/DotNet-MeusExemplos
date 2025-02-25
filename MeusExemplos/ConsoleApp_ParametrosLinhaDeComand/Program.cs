


////>>>>>>>> EXEMPLO 1
//Console.WriteLine(">>> Executando o programa");

//foreach (string arg in args)
//    Console.WriteLine($"parâmetro recebido: [{arg}]");

//Console.WriteLine(">>> Fim");

//return 99;




//>>>>>>>> EXEMPLO 2
namespace MeuNameSpace;
class Program
{
    public static async Task<int> Main(string[] args)
    {
        Console.WriteLine(">>> Chamou");

        foreach (string arg in args)
            Console.WriteLine($"parâmetro recebido: [{arg}]");


        return await AsyncConsoleWork();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        return 22;
    }
}


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