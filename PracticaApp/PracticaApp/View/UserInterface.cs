using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PracticaApp.View
{
    class UserInterface
    {
        public static int ShowMainMenu()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**************");
                Console.WriteLine("MENÚ PRINCIPAL");
                Console.WriteLine("**************");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1)  Potencia en base 2.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2)  Sumatorio.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("3)  Factorial.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("4)  Números Primos.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("5)  Serie Fibonacci.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("0)  Salir.");
                Console.ResetColor();
                Console.WriteLine();
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número del 1 al 5 para seleccionar una opción, recuerda que pulsado 0 saldrás de la app.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return -1;
        }

        public static int AskFor2Potencia()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-------------------");
                Console.WriteLine("Potencia en base 2:");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("La opcíón elegída calcula el resultado de la Potencia en Base 2 (2^) del número que decidas introducir.");
                Console.WriteLine();
                Console.WriteLine("Introduce un número para elevarlo en base a 2 y obtener su poténcia.");
                Console.ResetColor();
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número.");
                Console.ResetColor();
            }
            return -1;

        }

        public static int AskSumatorio()
        {
            try
            {
                Console.WriteLine("----------");
                Console.WriteLine("Sumatorio:");
                Console.WriteLine("----------");
                Console.WriteLine();
                Console.WriteLine("La opción elegída calcula el resultado del sumatorio del número que decidas introducir.");
                Console.WriteLine();
                Console.WriteLine("Introduce un número para calcular su Sumatório.");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número.");
                Console.ResetColor();
                Console.Clear();
            }
            return -1;
        }

        public static double AskForFactorialNumber()
        {
            try
            {
                Console.WriteLine("----------");
                Console.WriteLine("Factorial:");
                Console.WriteLine("----------");
                Console.WriteLine();
                Console.WriteLine("La opción elegída calcula el resultado del Factorial del número que decidas introducir.");
                Console.WriteLine();
                Console.WriteLine("Introduce un número para calcular su factorial.");
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número.");
                Console.ResetColor();
            }
            return -1;
        }

        public static int AskForNumPrimo()
        {
            try
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Números Prímos:");
                Console.WriteLine("---------------");
                Console.WriteLine();
                Console.WriteLine("La opción elegída muestra si el número que decidas introducir es, o no es Número Prímo.");
                Console.WriteLine();
                Console.WriteLine("Introduce un número para realizar la comprobación.");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número.");
                Console.ResetColor();
            }
            return -1;
        }

        public static int AskForFibonacci()
        {
            try
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Sucesión de Fibonacci:");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine("La opción elegída reproduce la Sucesión de Fibonacci incluyendo tántos números como el número que decidas introducir.");
                Console.WriteLine();
                Console.WriteLine("Introduce un número para comenzar la Sucesión.");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error de formato! Introduce un número.");
                Console.ResetColor();
            }
            return -1;
        }
    }
}

