namespace geral;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inicio");

        foreach (var item in args) 
            Console.WriteLine(item);

        Console.WriteLine("fim");

    }

    private static int Exemplo()
    {
        Console.WriteLine("exemplo");

        return 0;
    }
}