namespace SOLID.LSP.ExemploCorreto;

public class Gerente : Funcionario
{
    private double bonus = 3000;

    private double _percentualPPR = 0.35;

    public Gerente(string nome) : base(nome)
    {
    }

    //override os métodos da classe base
    public override double CalcularSalario(double salario) => salario + bonus;

    public override double CalculaPPR(double salario) => (salario * _percentualPPR) + salario;

}
