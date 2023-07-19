using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Construtores
{
    public class ProdutoThis
    {
        public ProdutoThis()
        {
            this.Quantidade = 10;
        }

        public ProdutoThis(string name, double preco) : this()
        {
            Name = name;
            Preco = preco;
        }

        public ProdutoThis(string name, double preco, int quantidade) : this(name, preco)
        {
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
