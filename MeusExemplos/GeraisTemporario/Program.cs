

using System.ComponentModel;


namespace geral;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(Guid.NewGuid());
        }
    }
}


