

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo sem usar Generics
        var naoGeneric = new ClasseNaoUsandoGenerics();
        int i1 = 10, i2 = 10;
        decimal d1 = 10, d2 = 10;
        string s1 = "10", s2 = "10";
        // Para cada tipo de valor preciso de uma função nova na classe
        naoGeneric.Comparar(i1, i2);
        naoGeneric.Comparar(d1, d2);
        naoGeneric.Comparar(s1, s2);


        // Exemplo com Generics
        Console.WriteLine("...generics");
        var generic = new Generics();
        generic.Comparar(i1, i2);
        generic.Comparar(d1, d2);
        generic.Comparar(s1, s2);


        // Generics com 2 ou mais tipos
        Console.WriteLine("...dois ou mais tipos");
        var gen2 = new Generics();
        gen2.CompararTipos(i1, s1);
        gen2.CompararTipos(d1, d2);


        // Generics a nível de classe
        Console.WriteLine("\n...classe genérica");
        var genIntInt = new GenericClass<int, int>();
        genIntInt.CompararMesmoTipo(i1, i2);
        
        var genStrInt = new GenericClass<string, int>();
        genStrInt.CompararTipos(s1, i2);


    }
}