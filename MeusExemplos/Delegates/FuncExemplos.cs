namespace Delegates;
public class FuncExemplos
{
    public static void Exemplo()
    {
        Func<string> func = RetValor;
        Console.WriteLine($"Func sempre retorna algo: {func()}");


        Func<int, string, string> funcDois = RetValor;
        var retorno = funcDois(98, "reais");
        Console.WriteLine($"Func sempre retorna algo: {retorno}");


        var exemplo1 = ExecutarComportamento(DescontarPercentil, 100);
        var exemplo2 = ExecutarComportamento(AplicarPercentil, 100);
        Console.WriteLine($"exemplo1: {exemplo1} | exemplo2: {exemplo2} ");
    }





    private static string RetValor()
    {
        return "valor retorno";
    }
    private static string RetValor(int val, string str)
    {
        return $"valor retorno é {val} com {str}.";
    }

    private static decimal ExecutarComportamento(
        Func<int, int, decimal> calculador,
        int valor)
    {
        var result = calculador(valor, 7);

        return result;
    }

    private static decimal DescontarPercentil(int valor, int percent)
    {
        decimal percentConvertido = (decimal)percent / 100;
        return valor - (valor * percentConvertido);
    }
    private static decimal AplicarPercentil(int valor, int percent)
    {
        decimal percentConvertido = (decimal)percent / 100;
        return valor + (valor * percentConvertido);
    }
}
