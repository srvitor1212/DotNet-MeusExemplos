using SOLID;
using SOLID.SRP;

Console.WriteLine("Hello World!");

new Modificadores();

Console.WriteLine("=== InjecaoDeDependencia");
var obj = new InjecaoDeDependencia(new DependenciaASerInjetada());
Console.WriteLine(obj.VerificaValor(10));



Console.WriteLine(@"
S — Single Responsibility Principle (Princípio da responsabilidade única)
O — Open-Closed Principle (Princípio Aberto-Fechado)
L — Liskov Substitution Principle (Princípio da substituição de Liskov)
I — Interface Segregation Principle (Princípio da Segregação da Interface)
D — Dependency Inversion Principle (Princípio da inversão da dependência)
");