

// Tipos valor como o INT não podem receber nulo;
//int valor = null; // não pode

int? valorNulo = null;
Console.WriteLine($"valor: [{valorNulo}]");
if ( valorNulo == null )
    Console.WriteLine("É nulo");


// outra forma
Nullable<int> valorNuloNullable = null;
Console.WriteLine($"valor: [{valorNuloNullable}]");
if (valorNuloNullable == null)
    Console.WriteLine("É nulo");


// pegar valores padrão
Console.WriteLine("...GetValueOrDefault");
Console.WriteLine(valorNuloNullable.GetValueOrDefault());


// retorna true or false
Console.WriteLine("...HasValue");
Console.WriteLine(valorNuloNullable.HasValue);


// retoran o valor ou uma exception
Console.WriteLine("...value");
//Console.WriteLine(valorNuloNullable.Value); // Gera exception: System.InvalidOperationException: 'Nullable object must have a value.'


// operador de coalescência nulo
Console.WriteLine("...operador de coalescência nulo");
int? x = null;
int? y = 100;

int a = x ?? 5; // se x é nulo, recebe 5
int b = y ?? 7; // se y é nulo, recebe y

Console.WriteLine($"" +
    $"a={a}\n" +
    $"b={b}\n");
