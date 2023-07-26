

namespace Generics
{
    internal class GenericClass<TipoUm, TipoDois>
    {
        public void CompararMesmoTipo<TipoUm>(TipoUm v1, TipoUm v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"tipos: {v1.GetType()} {v2.GetType()}");
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }

        public void CompararTipos<TipoUm, TipoDois>(TipoUm v1, TipoDois v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"tipos: {v1.GetType()} {v2.GetType()}");
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }
    }
}
