using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa 4");

            double salario;
            salario = 1300.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // casting 

            short qtdProdutos;
            qtdProdutos = 150;
            float altura = 1.80f;

            Console.WriteLine("Salario em Inteiro:" + salarioEmInteiro);
            Console.WriteLine("Quantidade Produtos:" + qtdProdutos);
            Console.WriteLine("Altura:" + altura);

            Console.ReadLine();
        }
    }
}
