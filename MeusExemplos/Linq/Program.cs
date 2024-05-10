

using System.Linq; // Não precisa dar using
// https://learn.microsoft.com/pt-br/dotnet/csharp/linq/get-started/introduction-to-linq-queries

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