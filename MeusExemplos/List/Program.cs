

namespace MeuNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // A lista é alocada dinamicamente de foram que o indice 1 sabe aonde fica o indice 2
            // o 2 sabe aonde fica o 3 e etc.
            //Diferente do Array que todo espaço é alocado na instância de forma linear na memória.
            
            
            List<string> list = new List<string>();
            list.Add("Carro");
            list.Add("Moto");
            list.Add("Chuveiro");
            Console.WriteLine("...list");
            MostrarLista(list);



            List<string> strings = new List<string> { "Maria", "João", "José" };
            Console.WriteLine("...strings"); 
            MostrarLista(strings);
        }

        static void MostrarLista<Tipo> (List<Tipo> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"[{i} : {values[i]}]");
            }
        }
    }
}