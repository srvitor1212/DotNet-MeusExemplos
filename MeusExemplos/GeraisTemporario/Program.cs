

using System.ComponentModel;


namespace geral;

class Program
{
    static void Main(string[] args)
    {


        var nome = "ReportPaymentParameterVBZ6Detail/NovaRVNominal_ago2024_19082024_02341276.csv";

        var teste = nome.Split('/')[1];
        var teste2 = nome.Split('/');

        Console.WriteLine(teste);


    }
}