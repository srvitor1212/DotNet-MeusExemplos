

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
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        //private
        private string PropriedadePrivada { get; set; } = "Não Informado";

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
