

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
        executando= false;
    else 
        contador++;
}