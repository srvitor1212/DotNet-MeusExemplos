

namespace Generics
{
    internal class ClasseNaoUsandoGenerics
    {
        public void Comparar(int v1, int v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }
        public void Comparar(decimal v1, decimal v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }
        public void Comparar(string v1, string v2)
        {
            bool res = v1.Equals(v2);
            Console.WriteLine($"{v1} é igual a {v2} ? {res}");
        }
    }
}
