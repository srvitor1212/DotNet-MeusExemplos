

namespace MeuNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref pode criar referência mesmo em tipos struct
            int valor = 10;

            Console.WriteLine("...sem ref");
            SemRef(valor);
            Console.WriteLine(valor);

            Console.WriteLine("...usando ref");
            UsandoRef(ref valor);
            Console.WriteLine(valor);
        }

        static void SemRef(int v) { 
            v = v + 5;
        }

        static void UsandoRef(ref int v)
        {
            v = v + 6;
        }

    }
}