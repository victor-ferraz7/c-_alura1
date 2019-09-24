using System;

namespace Aliquota
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3900.0;
            int aliquota = ' ';

            if (salario >= 1900.0 && salario <= 2800)
            {
                aliquota = 142;
                Console.Write("Salário :" + salario + " Aliquota:" + aliquota);

            }
            else if (salario > 2800 && salario < 3751)
            {
                aliquota = 375;
                Console.Write("Salário :" + salario + " Aliquota:" + aliquota);
            }
            else if(salario >= 3751)
            {
                aliquota = 675;
                Console.Write("Salário :" + salario + " Aliquota:" + aliquota);
            }

        }
    }
}
