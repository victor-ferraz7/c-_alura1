using System;

namespace testandoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicionais");


            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;

            if(quantidadePessoas >= 2)
            {
                 acompanhado = true;
            }
            else
            {
                 acompanhado = false;
            }
            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja Bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
        }
    }
}
