

namespace Generics
{
    internal class Generics
    {
        public void Comparar<TipoGenerico>(TipoGenerico v1, TipoGenerico v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"tipos: {v1.GetType()} {v2.GetType()}");
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }
    }
}
