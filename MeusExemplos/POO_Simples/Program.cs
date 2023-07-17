

namespace POO_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse minhaClasse = new MinhaClasse();
            minhaClasse.Name = "João";
            minhaClasse.Age = 10;
            Console.WriteLine(
                $"Nome: {minhaClasse.Name}" +
                $", Idade: {minhaClasse.Age}");

            Console.WriteLine("\n\nOverride do ToString()");
            Console.WriteLine(minhaClasse);
        }
    }
}