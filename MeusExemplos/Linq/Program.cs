

using System.Diagnostics;
using System.Linq; // Não precisa dar using
// https://learn.microsoft.com/pt-br/dotnet/csharp/linq/get-started/introduction-to-linq-queries


namespace Linq;
class Program
{
    static void Main(string[] args)
    {
        var listaVazia = new LinkedList<string>();
        var lista = new List<string>();
        lista.Add("Cachorro");
        lista.Add("Gato");
        lista.Add("Cavalo");
        lista.Add("Elefante");
        lista.Add("Passaro");

        var listaIdades = new List<int>();
        listaIdades.Add(18);
        listaIdades.Add(22);
        listaIdades.Add(19);
        listaIdades.Add(33);
        listaIdades.Add(17);


        Console.WriteLine("===== First");
        Console.WriteLine(lista.First());
        Console.WriteLine(listaVazia.FirstOrDefault("Não achei"));

        Console.WriteLine("===== Any");
        Console.WriteLine(lista.Any(x => x == "Gato"));
        Console.WriteLine(lista.Any(x => x == "Lebre"));

        Console.WriteLine("===== All");
        Console.WriteLine(listaIdades.All(x => x >= 18));
        Console.WriteLine(listaIdades.All(x => x >= 15));

        Console.WriteLine("===== Count");
        Console.WriteLine(lista.Count);
        Console.WriteLine(lista.Count(x => x.ToLower() == "gato"));

        Console.WriteLine("===== ElementAt");
        Console.WriteLine(lista.ElementAt(2));

        Console.WriteLine("===== Take");
        foreach (var item in lista.Take(3))
            Console.WriteLine(item);
        Console.WriteLine("=");
        foreach (var item in lista.Take(3..5))
            Console.WriteLine(item);

        Console.WriteLine("===== Where");
        Console.WriteLine(lista.Where(x => x.ToLower() == "passaro"));
        Console.WriteLine("=");
        foreach (var item in lista.Where(x =>
                                            (x.ToLower() == "passaro") ||
                                            (x.ToLower() == "gato")))
            Console.WriteLine(item);




        Console.WriteLine("================ Como ignorar nulos na lista");
        var listaNulls = new List<Membro>()
        {
            null,
            new Membro(){ Nome = "José", Idade = 22 },
            new Membro(){ Nome = "Maria", Idade = 22 },
            null,
            new Membro(){ Nome = "Vitor", Idade = 22 },
            null,
        };

        Console.WriteLine("=== primeiro da lista, retorna null");
        var res1 = listaNulls.FirstOrDefault(); 
        Console.WriteLine("res1={0}", res1 == null ? "é nulo" : res1);

        Console.WriteLine("=== não consegue encontrar porque tem nullos na lista");
        //var res2 = listaNulls.FirstOrDefault(x => x.Nome == "Vitor"); // vai dar EXCEPTION: Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        //Console.WriteLine("res2={0}", res2 == null ? "é nulo" : res2);

        Console.WriteLine("=== condição para ignorar nulos");
        var res3 = listaNulls.FirstOrDefault(x => x != null && x.Nome == "Vitor");
        Console.WriteLine("res3={0}", res3 == null ? "é nulo" : res3.Nome);

        Console.WriteLine("=== condição para ignorar nulos usando x?");
        var res4 = listaNulls.FirstOrDefault(x => x?.Nome == "Vitor");
        Console.WriteLine("res4={0}", res4 == null ? "é nulo" : res4.Nome);

    }
}



class Membro()
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}


















