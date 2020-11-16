using System;

namespace PracticaApp.Model
{
    class MathCalculator
    { 
        public static int Numero2Potencia(int num1)
        {
            int basePotencia = 2;
            int resultado1 = 1;
            int i = 1;
            while (i <= num1)
            {
                resultado1 = resultado1 * basePotencia;
                i++;
            }
            return resultado1;
        }

        public static int Sumatorio(int num2)
        {
            int resultado2 = 0;
            for (int i = 0; i <= num2; i++)
            {
                resultado2 += i;
            }
            return resultado2;
        }

        public static double Factorial(double num3)
        {
            double resultado3 = 1;
            for (int i = 1; i <= num3; i++)
            {
                resultado3 *= i;
            }
            return resultado3;

        }
        public static void NumeroPrimo(int num4)
        {
            int a = 0;
            for (int i = 1; i < (num4 + 1); i++)
            {
                if (num4 % i == 0)
                    a++;
            }
            if (a != 2)
            {
                Console.WriteLine();
                Console.WriteLine("El número " + num4 + " No es primo");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El número " + num4 + " Si es primo");
            }
            Console.ReadLine();
        }

        public static void SerieFibonacci()
        {
            double i = 0; double num1 = 0; double num2 = 1;
            Console.WriteLine();
            Console.WriteLine("comienza la Sucesión!");
            Console.WriteLine("---------------------");
            while (i < 80)
            {
                Console.Write(num1 + ", ", num2);
                num2 = num1 + num2;
                num1 = num2 - num1;
                i++;
            }

        }

    }
}
