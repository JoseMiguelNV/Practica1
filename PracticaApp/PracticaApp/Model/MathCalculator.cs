using System;

namespace PracticaApp.Model
{
    class MathCalculator
    {
        /// <summary>  
        /// Esta función recibe un número introducido por el usuario, y reliza la operación para elevar dicho número a la potencia en base a 2.
        /// </summary>
        /// <param name="num1"></param> Es el número utilizado para elevarlo a la potencia en base 2.
        /// <returns></returns> Delvuelve el resultado de la función 2^num1.
        public static double Numero2Potencia(double num1)
        {
            int basePotencia = 2;
            double resultado1 = 1;
            int i = 1;
            while (i <= num1)
            {
                resultado1 = resultado1 * basePotencia;
                i++;
            }
            return resultado1;
        }
        /// <summary>
        /// Esta función recibe un número introducido por el usuario, y realiza la operación que calcula el Sumatorio de dicho número.
        /// </summary>
        /// <param name="num2"></param> Es el número utilizado para calcular el sumatorio.
        /// <returns></returns> Devueve el resultado de la función Sumatorio.
        public static int Sumatorio(int num2)
        {
            int resultado2 = 0;
            for (int i = 0; i <= num2; i++)
            {
                resultado2 += i;
            }
            return resultado2;
        }
        /// <summary>
        /// Esta función devuelve un número real fruto de la operación de calcular el Factorial de un número recibido como parámetro.
        /// </summary>
        /// <param name="num3"></param> Es el número utilizado para calcular el Factorial.
        /// <returns></returns> Devuelve el resultado de la función Factorial.
        public static long Factorial(double num3)
        {
            long resultado3 = 1;
            for (int i = 1; i <= num3; i++)
            {
                resultado3 *= i;
            }
            return resultado3;

        }
        /// <summary>
        /// Esta función devuelve un booleano indicando si el número recibido como parámetro es primo o no.
        /// </summary>
        /// <param name="num4"></param> Es el número el cual queremos saber si es primo o no.
        /// <reutrns></reutrns> indica true si el numero es primo, false en caso contrario.
        public static bool NumeroPrimo(int num4)
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
        /// Esta función devuelve la Sucesión de fibonacci, formada por tántos números como el recibido como parámetro.
        /// </summary>
        /// <param name="num5"></param> Es el número que se aplica a la Sucesión de Fibonacci
        public static int SerieFibonacci(int num5)
        {
            int i = 0; int num1 = 0; int num2 = 1;
            Console.WriteLine("Has elegído el número " + num5 + " !!!");
            Console.WriteLine("Comienza la Sucesión!");
            Console.WriteLine("---------------------");
            while (i < num5)
            {
                Console.Write(num1 + ", ", num2);
                num2 = num1 + num2;
                num1 = num2 - num1;
                i++;
            }
            return i++;

        }

    }
}
