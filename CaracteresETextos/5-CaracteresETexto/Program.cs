using System;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            primeiraLetra = (char)61; // tabela AScii

            string texto = "Alura Cursos de Tecnologia ";

            Console.WriteLine("Primeira letra do Alfabeto : " + primeiraLetra);
            Console.WriteLine(texto + 2020);
            Console.ReadLine();
        }
    }
}
