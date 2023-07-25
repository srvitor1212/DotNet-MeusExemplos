

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse momento aloca memória
            MeuStruct meuStruct;

            // Mas não pode mostrar pois precisa ser inicializada
            //Console.WriteLine(meuStruct); // não pode

            // Uma forma de inicializar é essa:
            meuStruct.X = 1;
            meuStruct.Y = 2;
            Console.WriteLine(meuStruct);

            // Outra forma de inicializar é essa:
            meuStruct = new MeuStruct();
            Console.WriteLine(meuStruct);

            // Diferente de Ponteiros, cada um tem seu espaço em memória
            var teste = meuStruct;
            teste.X = 100; 
            teste.Y = 200;
            Console.WriteLine($"" +
                $"meuStruct.: {meuStruct}\n" +
                $"teste.....: {teste}\n");

        }
    }
}