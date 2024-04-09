using System.ComponentModel;

namespace MeusEnum;

// Exemplo básico de enum com os dias da semana
public enum DiasDaSemana
{
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sábado,
    Domingo
}

// Exemplo de enum com valores atribuídos manualmente
public enum Nota
{
    A = 10,
    B = 8,
    C = 6,
    D = 4,
    F = 0
}

// Exemplo de enum com atributos personalizados
public enum Direcao
{
    [Description("Sentido Norte")]
    Norte,
    [Description("Sentido Sul")]
    Sul,
    [Description("Sentido Leste")]
    Leste,
    [Description("Sentido Oeste")]
    Oeste
}

// Exemplo de enum com flags
[Flags]
public enum Opcoes
{
    Nenhuma = 0,
    Opcao1 = 1 << 0,
    Opcao2 = 1 << 1,
    Opcao3 = 1 << 2,
    Opcao4 = 1 << 3
}