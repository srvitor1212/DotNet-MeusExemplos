using SOLID;

Console.WriteLine("Hello World!");

new a1_Modificadores();


Console.WriteLine("=== InjecaoDeDependencia");
var obj = new InjecaoDeDependencia(new DependenciaASerInjetada());

Console.WriteLine(obj.VerificaValor(10));