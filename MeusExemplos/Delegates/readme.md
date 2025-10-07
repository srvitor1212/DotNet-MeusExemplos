# O que é um delegate no C#?

Um delegate é um tipo seguro que representa uma referência para um método.

Ele funciona como um "ponteiro de função" (similar ao conceito em C/C++), mas com verificação de tipo feita pelo compilador.

Em outras palavras, um delegate permite armazenar métodos em variáveis e invocá-los indiretamente.

## DELEGATES nativos do }C#
O C# já vem com delegates genéricos prontos que facilitam muito o trabalho, evitando que você precise criar seus próprios tipos de delegate manualmente.

Os principais são Action, Func e Predicate.

## Action

- Representa um método que não retorna valor (void).
- Pode receber 0 a 16 parâmetros.

## Func

- Representa um método que retorna um valor.
- O último tipo genérico é sempre o tipo de retorno.
- Pode receber 0 a 16 parâmetros.

## Predicate

- Representa um método que recebe um parâmetro e retorna bool.
- Muito usado para filtragem.