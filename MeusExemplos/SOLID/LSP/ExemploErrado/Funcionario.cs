namespace SOLID.LSP.ExemploErrado;

public class Funcionario
{
    public string Nome { get; private set; }

    private double _percentualPPR = 0.10;

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public double CalculaPPR(double salario) => (salario * _percentualPPR) + salario;
}
