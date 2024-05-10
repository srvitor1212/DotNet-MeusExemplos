namespace ArquivoCSV
{
    internal class FakeCSV
    {
        public void GerarCSV(int linhas)
        {
            var nomeArquivo = "meu_arquivo.csv";
            var rand = new Random();

            using (var writer = new StreamWriter(nomeArquivo))
            {
                writer.WriteLine("id;nome;valor");
                for (int i = 0; i < linhas; i++)
                {
                    writer.WriteLine($"{i};Nome do registro;{rand.NextDouble()}");
                }
            }

            Console.WriteLine("Arquivo gerado: {0}\\{1}", Directory.GetCurrentDirectory(), nomeArquivo);
        }
    }
}
