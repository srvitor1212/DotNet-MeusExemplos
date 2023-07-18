

namespace POO_Construtores
{
    public class ProdutoSobrecarga
    {
        public ProdutoSobrecarga(string name)
        {
            Name = name;
            this.Preco = 9999.99;
        }

        public ProdutoSobrecarga(string name, double preco, int quantidade)
        {
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

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
