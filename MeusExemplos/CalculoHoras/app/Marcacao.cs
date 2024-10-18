namespace CalculoHoras.app;

public class Marcacao
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime Batida { get; set; }

    public Marcacao(int id, string nome, DateTime dataHora)
    {
        Id = id;
        Nome = nome;
        Batida = dataHora;
    }
}
