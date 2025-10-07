# O que � um delegate no C#?

Um delegate � um tipo seguro que representa uma refer�ncia para um m�todo.

Ele funciona como um "ponteiro de fun��o" (similar ao conceito em C/C++), mas com verifica��o de tipo feita pelo compilador.

Em outras palavras, um delegate permite armazenar m�todos em vari�veis e invoc�-los indiretamente.

## DELEGATES nativos do }C#
O C# j� vem com delegates gen�ricos prontos que facilitam muito o trabalho, evitando que voc� precise criar seus pr�prios tipos de delegate manualmente.

Os principais s�o Action, Func e Predicate.

## Action

- Representa um m�todo que n�o retorna valor (void).
- Pode receber 0 a 16 par�metros.

## Func

- Representa um m�todo que retorna um valor.
- O �ltimo tipo gen�rico � sempre o tipo de retorno.
- Pode receber 0 a 16 par�metros.

## Predicate

- Representa um m�todo que recebe um par�metro e retorna bool.
- Muito usado para filtragem.