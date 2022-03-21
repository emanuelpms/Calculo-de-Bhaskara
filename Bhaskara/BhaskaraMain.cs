using System;
using System.Collections.Generic;

namespace Bhaskara
{
    class BhaskaraMain
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            bool continua = true;
            char continuar;

            do
            {
                Console.WriteLine("============ Calculadora de Bhaskara ================ \n\n\n");

                Console.WriteLine("Digite o valor de A: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("========================================================");

                Console.WriteLine("Digite o valor de B: ");
                b = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("========================================================");

                Console.WriteLine("Digite o valor de C: ");
                c = Convert.ToDouble(Console.ReadLine());

                CalculoBhaskara.Bhaskara(a, b, c);

                Console.WriteLine("Deseja realizar mais calculos? {S} - Sim {N} - Não");
                continuar = Convert.ToChar(Console.ReadLine().ToLower());

                if (continuar == 'N')
                {
                    continua = false;
                }
                else
                {
                    continua = true;
                }


            } while (continua);


        }

        
        

    }
}
