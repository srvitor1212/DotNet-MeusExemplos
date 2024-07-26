namespace ExemploModelagemBD.Tabelas;
public class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public int Idade { get; set; }

    public string CPF { get; set; } = string.Empty;


    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
