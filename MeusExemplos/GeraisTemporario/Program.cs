

using System.ComponentModel;


namespace geral;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(nameof(Teste));

        var rand = new Random();

        for (int i = 0; i < 100; i++)
        {
            Console.Write( rand.Next(minValue:0, maxValue: 2) );
        }
    }
}

public class Teste()
{

}

