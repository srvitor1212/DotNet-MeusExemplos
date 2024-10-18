namespace CalculoHoras;

public class Marcacao
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Dep { get; set; }
    public DateTime Batida { get; set; }

    public Marcacao(int id, string nome, string dep, DateTime dataHora)
    {
        Id = id;
        Nome = nome;
        Dep = dep;
        Batida = dataHora;
    }
}
