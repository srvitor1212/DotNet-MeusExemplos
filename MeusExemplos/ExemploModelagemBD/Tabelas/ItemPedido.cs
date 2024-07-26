namespace ExemploModelagemBD.Tabelas;
public class ItemPedido
{
    public int PedidoId { get; set; }

    public int ProdutoId { get; set; }


    public Pedido Pedido { get; set; }
    public Produto Produto { get; set; }
}
