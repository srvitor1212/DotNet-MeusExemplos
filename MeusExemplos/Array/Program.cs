

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // O array aloca a memória de forma continua, tornando mais performático
            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = random.Next();

            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine($"idx: {i}, value: {vetor[i]}");


            // Alocando classes no vetor
            MinhaClasse[] classes = new MinhaClasse[100];

            for (int i = 0; i < classes.Length; i++)
            {
                classes[i] = new MinhaClasse();
                classes[i].NomeProduto = "Nome do produto";
                classes[i].Preco = random.Next(0,100);
            }
        }
    }
}