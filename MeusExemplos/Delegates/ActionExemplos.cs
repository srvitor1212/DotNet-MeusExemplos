namespace Delegates;


public class ActionExemplos
{
    public static void Exemplo()
    {
        Action<string> mostrarMensagem = FuncaoShowMsg;
        mostrarMensagem("top d+");


        
        var contaVitor = new ContaCorrente("Vitor", 1000);
        var contaMaria = new ContaCorrente("Maria", 1200);
        Console.WriteLine($"{contaVitor}{contaMaria}");

        DescontarValores(contaVitor.Debito, 200m);
        DescontarValores(contaVitor.DebitoBonus, 50m);
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
    public decimal BonusNovoCliente { get; set; }

    public ContaCorrente(string nome, decimal saldo)
    {
        Nome = nome;
        BonusNovoCliente = saldo * 0.30m;
        Saldo = saldo + BonusNovoCliente;
    }

    public void Debito(decimal valor)
        => Saldo -= valor;

    public void DebitoBonus(decimal valor)
        => BonusNovoCliente -= valor;

    public override string ToString()
    {
        return $"Conta do {Nome} | Saldo R$ {Saldo} | Bonus R$ {BonusNovoCliente}\n";
    }
}
