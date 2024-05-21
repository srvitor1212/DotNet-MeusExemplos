namespace ArquivoCSV
{
    internal class FakeCSV
    {
        public string dir { get; set; }
        public string path { get; set; }

        public void GerarCSV(int linhas)
        {
            var nomeArquivo = "meu_arquivo.csv";
            if ( !File.Exists(nomeArquivo) )
            {
                Console.WriteLine("gerando csv...");

                var rand = new Random();
                using (var writer = new StreamWriter(nomeArquivo))
                {
                    writer.WriteLine("id;nome;valor");
                    for (int i = 0; i < linhas; i++)
                    {
                        writer.WriteLine($"{i};Nome do registro;{rand.NextDouble()}");
                    }
                }
            }

            this.dir = Directory.GetCurrentDirectory();
            this.path = this.dir + @"\" +nomeArquivo;

            Console.WriteLine("Arquivo gerado: {0}\\{1}", Directory.GetCurrentDirectory(), nomeArquivo);
        }
    }
}
