

// (condição) ? valor_se_verdadeiro : valor_se_false
string res = (1 > 2) ? "SIM" : "NÃO";
System.Console.WriteLine(res);

// outro exemplo
double preco = 100;
double desconto = (preco > 200) ? preco * 0.10 : preco * 0.15;
System.Console.WriteLine("Preço R$ " + preco + " desconto R$ " + desconto);

preco = 1000;
desconto = (preco > 200) ? preco * 0.10 : preco * 0.15;
System.Console.WriteLine("Preço R$ " + preco + " desconto R$ " + desconto);


Console.WriteLine("===== usando função static");
var valor = IsValid(4) ? $"é menor que 10" : "não válido";
Console.WriteLine($"valor: {valor}");

static bool IsValid(int valor)
{
    if (valor < 10) 
        return true;
    
    return false;
}