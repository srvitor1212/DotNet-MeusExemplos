

namespace POO_Construtores
{
    public class Produto
    {
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return
                $"name: {Name}.\n" +
                $"preço: {Preco}.\n" +
                $"qtd: {Quantidade}.\n";
        }
    }
}
