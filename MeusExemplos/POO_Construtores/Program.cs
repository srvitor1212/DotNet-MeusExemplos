﻿

namespace POO_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...iniciando");


            // Sem um construtor os valores são iniciados vazios
            Produto produto = new Produto();
            Console.WriteLine(produto);


            // Classe com só um construtor, obriga a criar com valores
            Console.WriteLine("...produto construtor");
            //ProdutoConstrutor p1 = new ProdutoConstrutor(); //Não permite
            ProdutoConstrutor p1 = new ProdutoConstrutor("Televisão", 1200.99, 4);
            Console.WriteLine(p1);


            // Mais de uma forma de instânciar o objeto
            Console.WriteLine("...produto sobrecarga");
            ProdutoSobrecarga p2 = new ProdutoSobrecarga("Video Game");
            Console.WriteLine(p2);

            ProdutoSobrecarga p3 = new ProdutoSobrecarga("Carro Chevrolet", 50000.99, 2);
            Console.WriteLine(p3);

        }
    }
}