

namespace POO_Encapsulamento
{
    public class Produto
    {
        public Produto(string name, double preco, int quantidade)
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
        private string PropriedadePrivada = "Não Informado";

        public string getPropriedadePrivada()
        {
            return PropriedadePrivada;
        }

        public void setPropriedadePrivada(string propriedadePrivada)
        {
            if (propriedadePrivada.Length >= 3)
                this.PropriedadePrivada = propriedadePrivada;
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
