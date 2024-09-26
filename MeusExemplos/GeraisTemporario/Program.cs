

using System.ComponentModel;


namespace geral;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(nameof(Teste));

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(Guid.NewGuid());
        }
    }
}

public class Teste()
{

}

