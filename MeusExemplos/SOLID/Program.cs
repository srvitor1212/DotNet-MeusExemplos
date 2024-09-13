using SOLID;
using SOLID.OCP;

Console.WriteLine("Hello World!");

new Modificadores();

Console.WriteLine("=== InjecaoDeDependencia");
var obj = new InjecaoDeDependencia(new DependenciaASerInjetada());
Console.WriteLine(obj.VerificaValor(10));



Console.WriteLine(@"
S — SRP Single Responsibility Principle (Princípio da responsabilidade única)
O — OCP Open-Closed Principle (Princípio Aberto-Fechado) aberto para extenção, fechado para modificação
L — LSP Liskov Substitution Principle (Princípio da substituição de Liskov)
I — ISP Interface Segregation Principle (Princípio da Segregação da Interface)
D — DIP Dependency Inversion Principle (Princípio da inversão da dependência)
");

Console.WriteLine("=== exemplo OCP");
var produto = new ProdutoCorretoOCP(1, "TB 50'");
produto.SetValorVenda(2890.99m);
produto.SetCusto(1650.00m);
Console.WriteLine($"{produto.Nome} com margem de % {produto.MargemLucro()}");
