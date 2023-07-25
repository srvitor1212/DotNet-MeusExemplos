

namespace Ponteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esse caso abaixo é chamado de TIPO REFERÊNCIA

            // Nesse momento ainda não alocou memória
            MinhaClasse minhaClasse;

            // Agora está alocando memória
            // A var "minhaClasse" aponta para o endereço de memória por exemplo: 0x100022
            minhaClasse = new MinhaClasse("Vitor", 29, 105.90);

            // Aqui cria um novo ponteiro apontado pro mesmo endereço de memória 0x100022
            var outroPonteiro = minhaClasse;
            outroPonteiro.Nome = "João da Silva";
            Console.WriteLine($"" +
                $"minhaClasse....: {minhaClasse.Nome}\n" +
                $"outroPonteiro..: {outroPonteiro.Nome}\n");
        }
    }
}