

namespace MeuNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular(5, 6, 7);
            Calcular(233, 66, 7, 8, 9);
        }

        static void Calcular(params int[] valores)
        {
            int res = 0;
            for (int i = 0; i < valores.Length; i++)
                res += valores[i];

            Console.WriteLine($"Res: {res}");
        }
    }
}