

Console.WriteLine("...running");


Console.WriteLine("For Simples");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("\n\nWhile Simples");
bool executando = true;
int contador = 0;
while (executando)
{
    Console.WriteLine($"Contador: {contador}");
    if (contador == 10)
        executando = false;
    else
        contador++;
}


Console.WriteLine("\n\nWhile Interromper no meio");
contador = 0;
while (true)
{
    Console.WriteLine($"Contador: {contador}");
    if (contador == 5)
        break;
    else
        contador++;
}


Console.WriteLine("...foreach");
string[] nomes = new string[] { "Maria", "João", "Bob" };
foreach (string s in nomes)
    Console.WriteLine(s);