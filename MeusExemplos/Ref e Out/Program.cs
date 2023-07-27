

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

            int val;
            //UsandoRef(ref val); // O ref exige que a variável seja iniciada;
            // Out permite passa variável não inicializada
            UsandoOut(out val);
            Console.WriteLine($"out: {val}");
        }

        static void SemRef(int v)
        {
            v = v + 5;
        }

        static void UsandoRef(ref int v)
        {
            v = v + 6;
        }

        static void UsandoOut(out int v)
        {
            v = 200;
        }

    }
}