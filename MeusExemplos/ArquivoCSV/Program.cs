

using ArquivoCSV;
using System.Diagnostics;

namespace teste;
class Program
{
    static void Main(string[] args)
    {
        //https://www.youtube.com/watch?v=SdXIGCU8xuE&ab_channel=EximiaCo-Excel%C3%AAnciaTecnol%C3%B3gica

        var csv = new FakeCSV();
        csv.GerarCSV(10_000_000);
        Console.WriteLine(csv.dir);
        Console.WriteLine(csv.path);



        // Carrega todo o arquivo csv em memória
        Console.WriteLine("\n\n");
        var antes0 = GC.CollectionCount(0);
        var antes1 = GC.CollectionCount(1);
        var antes2 = GC.CollectionCount(2);

        var sw = new Stopwatch();
        sw.Start();

        //CarregarTudoNaMemoria(csv.path);
        CarregaParcialNaMemoria(csv.path);

        sw.Stop();
        Console.WriteLine($"Tempo....: {sw.ElapsedMilliseconds} ms");
        Console.WriteLine($"Gen0.....: {GC.CollectionCount(0) - antes0}");
        Console.WriteLine($"Gen1.....: {GC.CollectionCount(1) - antes1}");
        Console.WriteLine($"Gen2.....: {GC.CollectionCount(2) - antes2}");
        Console.WriteLine($"Memória..: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
    }

    private static void CarregarTudoNaMemoria(string filePath)
    {
        Console.WriteLine(">>> CarregarTudoNaMemoria");

        var lines = File.ReadAllLines(filePath);
        var sum = 0d;
        var res = 0d;

        foreach (var line in lines)
        {
            var colunas = line.Split(';');
            double.TryParse(colunas[2], out res);
            sum += res;
        }

        Console.WriteLine(">>> sum={0}", sum);
    }

    private static void CarregaParcialNaMemoria(string filePath)
    {
        Console.WriteLine(">>> CarregaParcialNaMemoria");


        var sum = 0d;
        var res = 0d;
        string line;

        using (var arquivo = File.OpenRead(filePath))
        using (var reader = new StreamReader(arquivo))
        while ((line = reader.ReadLine()) != null)
        {
            var colunas = line.Split(';');
            double.TryParse(colunas[2], out res);
            sum += res;
        }


        Console.WriteLine(">>> sum={0}", sum);

    }
}