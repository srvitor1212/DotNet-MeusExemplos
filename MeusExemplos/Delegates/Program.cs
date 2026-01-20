using Delegates;


/*
Em C#, um delegate é um tipo que representa uma referência para um método.
Ele funciona como um ponteiro de função seguro, permitindo armazenar, passar e chamar métodos de forma dinâmica.

- porque usar delegates ao invés de passar o objeto como um parâmetro ?
Passar um objeto como parâmetro → você passa dados.
Passar um delegate como parâmetro → você passa comportamento (um método que será executado).
 */

// Action<T> - Representa um método que não retorna valor (void)
ActionExemplos.Exemplo();

// Func - Representa um método que retorna um valor
FuncExemplos.Exemplo();

// Predicate - Representa um método que recebe um parâmetro e retorna bool