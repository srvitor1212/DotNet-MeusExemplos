namespace SOLID.LSP.ExemploCorreto;

public class Funcionario
{
    public string Nome { get; private set; }

    private double _percentualPPR = 0.10;

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    //virtual = método que pode ser sobreescrito/override
    public virtual double CalcularSalario(double salario) => salario;

    public virtual double CalculaPPR(double salario) => (salario * _percentualPPR) + salario;
}
