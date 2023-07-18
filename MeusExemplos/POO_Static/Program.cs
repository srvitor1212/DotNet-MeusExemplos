

// Classe com prefixo static pode ser chamada sem precisar ser instânciada
// Exemplo de instânciação: MinhaClasse minhaClasse = new MinhaClasse();


namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...iniciando");
            Console.WriteLine( StaticClass.Circunferencia(5.0) );
            Console.WriteLine( StaticClass.Volume(3.0) );
            // StaticClass obj = new StaticClass(); //não pode


            // Por não ter statis na class, pode ser instânciada
            // Mas as funções que tem static não podem ser usadas
            ClassMembrosStaticos membrosStaticos = new ClassMembrosStaticos();
            Console.WriteLine("...membros staticos");
            Console.WriteLine( membrosStaticos.Pi_Liberado );
            Console.WriteLine( membrosStaticos.Volume_Liberado(10) );
            // Console.WriteLine( membrosStaticos.Pi ); //não pode
        }
    }
}