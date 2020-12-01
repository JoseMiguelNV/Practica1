using System;

namespace PracticaApp.Model
{
    class MathCalculator
    {
        /// <summary>  
        /// Esta función recibe como parámetro un número entero, y reliza la operación para elevar dicho número a la potencia en base a 2.
        /// </summary>
        /// <param name="num1"> Es el número entero recibido como parámetro y es utilizado para elevarlo a la potencia en base 2. </param> 
        /// <returns> Delvuelve como resultado de la función 2^num1, un número real. </returns> 
        public static double CalcularPotenciaBase2(int num1)
        {
            int basePotencia = 2;
            double resultado1 = 1;
            for (int i = 1; i <= num1; i++)
                resultado1 = resultado1 * basePotencia;
            return resultado1;
        }
        /// <summary>
        /// Esta función recibe un número entero como parámetro, y realiza la operación que calcula el Sumatorio de dicho número.
        /// </summary>
        /// <param name="num2"> Es el número entero recibido como parámetro y es utilizado para calcular el sumatorio. </param> 
        /// <returns> Devuelve un número entero como resultado de calcular el Sumatorio. </returns> 
        public static int CalcularSumatorio(int num2)
        {
            int resultado2 = 0;
            for (int i = 0; i <= num2; i++)
                resultado2 += i;
            return resultado2;
        }

        /// <summary>
        /// Esta función recibe un número entero como parámetro, y lo utiliza para calcular el Factorial de dicho número.
        /// </summary>
        /// <param name="num3"> Es el número entero recibído como parámetro y es utilizado para calcular el Factorial. </param> 
        /// <returns> Devuelve un número real como resultado de calcular el Factorial. </returns> 
        public static double CalcularFactorial(int num3)
        {
            double resultado3 = 1;
            for (int i = 1; i <= num3; i++)
                resultado3 *= i;
            return resultado3;
        }

        /// <summary>
        /// Esta función recibe un número entero como parámetro, y realiza un booleano indicando si dicho número es primo o no lo es.
        /// </summary>
        /// <param name="num4"> Es el número entero recibido como parámetro para averiguar si es o no es número primo. </param>
        /// <reutrns> Devuelve un booleano indicando true si el número es primo, o false si no lo es. </reutrns> 
        public static bool EsNumeroPrimo(int num4)
        {
            int a = 0;
            for (int i = 2; i < num4; i++)
            {
                if ((num4 % i) == 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Esta función recibe como parámetro un numero entero y plasma la Sucesión de fibonacci, formada por tántos números como el recibido como parámetro.
        /// </summary>
        /// <param name="num5"> Es el número entero recibido como parámetro, se aplica a la Sucesión de Fibonacci para que ésta tenga tantos números como el aplicado. </param> 
        public static void SerieFibonacci(int num5)
        {
            int i = 0; int num1 = 0; int num2 = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Has elegído el número " + num5 + "!");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comienza la Sucesión!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ResetColor();
            while (i < num5)
            {
                Console.Write(num1 + ", ", num2);
                num2 = num1 + num2;
                num1 = num2 - num1;
                i++;
            }
        }
    }
}
