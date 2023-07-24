

namespace POO_Encapsulamento
{
    public class ProdutoAutoProperty
    {
        public ProdutoAutoProperty(string name, double preco, int quantidade)
        {
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

        //public
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Quantidade { private get; set; }
        public string PropriedadePrivada { get; private set; }

        public override string ToString()
        {
            return
                $"name: {Name}.\n" +
                $"preço: {Preco}.\n" +
                $"qtd: {Quantidade}.\n" +
                $"private: {PropriedadePrivada}.\n";
        }
    }
}
