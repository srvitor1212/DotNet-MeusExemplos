using SOLID;

Console.WriteLine("Hello World!");

new Modificadores();

Console.WriteLine("=== InjecaoDeDependencia");
var obj = new InjecaoDeDependencia(new DependenciaASerInjetada());
Console.WriteLine(obj.VerificaValor(10));



Console.WriteLine(@"
S — SRP Single Responsibility Principle (Princípio da responsabilidade única)
O — OCP Open-Closed Principle (Princípio Aberto-Fechado)
L — LSP Liskov Substitution Principle (Princípio da substituição de Liskov)
I — ISP Interface Segregation Principle (Princípio da Segregação da Interface)
D — DIP Dependency Inversion Principle (Princípio da inversão da dependência)
");