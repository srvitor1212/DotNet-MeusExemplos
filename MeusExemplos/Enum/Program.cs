

using MeusEnum;

var diaDaSemana = DiasDaSemana.Quinta;
Console.WriteLine("Dia da semana {0}", diaDaSemana);


Console.WriteLine("===============");
var notaAluno = Nota.A;
Console.WriteLine("Nota do aluno: {0}", notaAluno);
Console.WriteLine("Valor da nota: {0}", (int)notaAluno);

int soma = 2 + (int)notaAluno;
Console.WriteLine("soma: {0}", soma);



Console.WriteLine("===============");
var enumName = Enum.GetName(typeof(Direcao), Direcao.Sul);
Console.WriteLine("Enum name: {0}", enumName);

//private static string GetEnumDescription(int key)
//{
//    var result = (T)Enum.Parse(typeof(T), key.ToString(), true);

//    return EnumExtension.GetDescription(result);
//}

var enumDesciption = (Direcao)Enum.Parse(typeof(Direcao), Direcao.Norte.ToString()); //todo: não ta funcionando corretamente
//var enumDesciption = Enum.Parse(typeof(Direcao), Direcao.Norte.ToString());
Console.WriteLine("Enum description: {0}" , enumDesciption);