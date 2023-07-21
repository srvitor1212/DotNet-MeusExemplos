

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...iniciando");
            Produto produto = new Produto("TV", 1200.99, 3);
            Console.WriteLine(produto);
            //Posso alterar as propriedades
            produto.Name = "XPTO";
            produto.Preco = 1;
            produto.Quantidade = 1;
            //produto.PropriedadePrivada = "texto"; //não pode
            Console.WriteLine(produto);

            
            Console.WriteLine("...usando set");
            produto.setPropriedadePrivada("ab");
            Console.WriteLine(produto);
            produto.setPropriedadePrivada("Teste");
            Console.WriteLine(produto);


            Console.WriteLine("...usando property");
            ProdutoProperty prop = new ProdutoProperty("carro", 25000.0, 1);
            Console.WriteLine(prop);
            Console.WriteLine($"prop: {prop.PropriedadePrivada}");
            prop.PropriedadePrivada = "ab";
            Console.WriteLine($"prop2: {prop.PropriedadePrivada}");
            prop.PropriedadePrivada = "teste";
            Console.WriteLine($"prop2: {prop.PropriedadePrivada}");
        }
    }
}