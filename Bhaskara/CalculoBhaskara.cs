using System;
using System.Collections.Generic;
using System.Text;

namespace Bhaskara
{
    class CalculoBhaskara
    {
        public static void Bhaskara(double a, double b, double c)
        {
            double delta, raiz, x1, x2;

            delta = (b * b) - (4 * a * c);
            raiz = Math.Sqrt(delta);

            x1 = (-b + raiz) / (2 * a);
            x2 = (-b - raiz) / (2 * a);

            
            if (delta < 0)
            {
                Console.WriteLine("Esta equação do segundo grau não possui raizes reais ");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Esta equação do segundo grau possui uma raiz real ");
                Console.WriteLine($"O valor de X1 = {Math.Round(x1, 0)} e do X2 = {Math.Round(x2, 0)}");

            }
            else
            {
                Console.WriteLine("Esta equação do segundo grau possui duas raizes reais");
                Console.WriteLine($"O valor de X1 = {Math.Round(x1, 0)} e do X2 = {Math.Round(x2, 0)}");
            }

        }
    }
}
