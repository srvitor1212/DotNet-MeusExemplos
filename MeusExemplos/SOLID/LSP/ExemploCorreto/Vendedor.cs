namespace SOLID.LSP.ExemploCorreto;

public class Vendedor : Funcionario
{
    private double bonus = 1500;

    private double _percentualPPR = 0.20;

    public Vendedor(string nome) : base(nome)
    {
    }

    //override os métodos da classe base
    public override double CalcularSalario(double salario) => salario + bonus;

    public override double CalculaPPR(double salario) => (salario * _percentualPPR) + salario;


}
