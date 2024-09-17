namespace SOLID.LSP.ExemploErrado;

public class Gerente : Funcionario
{
    private double bonus = 3000;

    private double _percentualPPR = 0.35;

    public Gerente(string nome) : base(nome)
    {
    }

    public double CalcularSalario(double salario) => salario + bonus;

    //new = indica que eu sei que esse método está ocultando o método da classe base com o mesmo nome
    public new double CalculaPPR(double salario) => (salario * _percentualPPR) + salario;

}
