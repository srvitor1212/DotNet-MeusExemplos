

namespace POO_Encapsulamento
{
    public class ProdutoProperty
    {
        public ProdutoProperty(string name, double preco, int quantidade)
        {
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

        //public
        public string Name;
        public double Preco;
        public int Quantidade;
        //private
        private string _propriedadePrivada = "Não Informado";
        public string PropriedadePrivada
        {
            get { return _propriedadePrivada; }
            set {
                if (value.Length >= 3)
                    _propriedadePrivada = value;
            }
        }

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
