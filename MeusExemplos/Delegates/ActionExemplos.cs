namespace Delegates;


public class ActionExemplos
{
    public static void Exemplo()
    {
        Action<string> mostrarMensagem = FuncaoShowMsg;
        mostrarMensagem("top d+");


        
        var contaVitor = new ContaCorrente("Vitor", 800m);
        var contaMaria = new ContaCorrente("Maria", 300m);
        Console.WriteLine($"{contaVitor}{contaMaria}");

        DescontarValores(contaVitor.Debito, 20m);
        DescontarValores(contaVitor.Debito, -2000m);
        DescontarValores(contaMaria.Debito, 120m);
        Console.WriteLine($"{contaVitor}{contaMaria}");
    }







    private static void FuncaoShowMsg(string message)
    {
        Console.WriteLine($"Olá mundo! {message}");
    }

    private static void DescontarValores(
        Action<decimal> funcaoDebitar,
        decimal valorDescontado)
    {
        if (valorDescontado > 0)
        {
            funcaoDebitar(valorDescontado);
        }
    }
}

internal class ContaCorrente
{
    public string Nome { get; set; }
    public decimal Saldo { get; set; }

    public ContaCorrente(string nome, decimal saldo)
    {
        Nome = nome;
        Saldo = saldo;
    }

    public void Debito(decimal valor)
        => Saldo = valor > Saldo ? 0 : Saldo - valor;

    public override string ToString()
    {
        return $"Conta do {Nome}\n" +
            $"Saldo R$ {Saldo}\n\n";
    }
}
