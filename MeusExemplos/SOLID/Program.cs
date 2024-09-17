using SOLID;
using SOLID.DIP.ExemploCorreto;
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

I — ISP Interface Segregation Principle (Princípio da Segregação da Interface) Ter várias interfaces específicas. Uma interface não pode forçar uma classe a implementar um método que não vai usar.

D — DIP Dependency Inversion Principle (Princípio da inversão da dependência)
");

Console.WriteLine("=== exemplo OCP");
var produto = new ProdutoCorretoOCP(1, "TB 50'");
produto.SetValorVenda(2890.99m);
produto.SetCusto(1650.00m);
Console.WriteLine($"{produto.Nome} com margem de % {produto.MargemLucro()}");


Console.WriteLine("\n\n=== exemplo LSP");
SOLID.LSP.ExemploErrado.Funcionario vitor = new SOLID.LSP.ExemploErrado.Gerente("Gerente Vitor");
SOLID.LSP.ExemploErrado.Funcionario mario = new SOLID.LSP.ExemploErrado.Vendedor("Vendedor Mario");
/*  O objeto "vitor" é um Gerente e por consequência é um Funcionario, porém, ao tentar usar o método de Gerente
    o código quebra conforme linha abaixo. Isso é uma violação do princípio LSP. */
//Console.WriteLine($"{vitor.Nome} salário {vitor.CalcularSalario(4000)}");
Console.WriteLine($"vitor é do tipo: {vitor.GetType()}");

/*  Outro exemplo é esse caso aonde ao invés de usar os 20% da classe vendedor, usou os 10% da classe base Funcionario */
Console.WriteLine($"mario é do tipo: {mario.GetType()}");
Console.WriteLine($"{mario.Nome} salário {mario.CalculaPPR(1000)}");

Console.WriteLine("= exemplo correto");
SOLID.LSP.ExemploCorreto.Funcionario robson = new SOLID.LSP.ExemploCorreto.Gerente("Gerente Robson");
Console.WriteLine($"{robson.Nome} tem um salário de {robson.CalcularSalario(1000)}, e ppr de {robson.CalculaPPR(1000)}");


Console.WriteLine("\n\n=== exemplo DIP");
var recuperar = new RecuperarSenha(new ConexaoSqlServer());
recuperar.Recuperar();