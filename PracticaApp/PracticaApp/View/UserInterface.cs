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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                     ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           MENÚ PRINCIPAL            ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                                     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elige una de las siguientes opciones:");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1)  Potencia en base 2.");
            Console.WriteLine("2)  Sumatorio.");
            Console.WriteLine("3)  Factorial.");
            Console.WriteLine("4)  Números Primos.");
            Console.WriteLine("5)  Serie Fibonacci.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0)  Salir.");
            Console.ResetColor();
            Console.WriteLine();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error de formato! Introduce un número del 1 al 5 para seleccionar una opción, recuerda que pulsado 0 saldrás de la app.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return UserInterface.ShowMainMenu();
        }

        public static int AskFor2Potencia()
        {   
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato no válido! Introduce esta vez un número entero.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();    
            }
            return UserInterface.AskFor2Potencia();
        }

        public static int AskForSumatorio()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------");
            Console.WriteLine("Sumatorio:");
            Console.WriteLine("----------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La opción elegída calcula el resultado del sumatorio del número que decidas introducir.");
            Console.WriteLine();
            Console.WriteLine("Introduce un número para calcular su Sumatório.");
            Console.ResetColor();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato no válido! Introduce esta vez un número entero.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return UserInterface.AskForSumatorio();
        }

        public static int AskForFactorialNumber()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------");
            Console.WriteLine("Factorial:");
            Console.WriteLine("----------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La opción elegída calcula el resultado del Factorial del número que decidas introducir.");
            Console.WriteLine();
            Console.WriteLine("Introduce un número para calcular su factorial.");
            Console.ResetColor();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato no válido! Introduce esta vez un número entero.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return UserInterface.AskForFactorialNumber();
        }

        public static int AskForNumPrimo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------");
            Console.WriteLine("Números Prímos:");
            Console.WriteLine("---------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La opción elegída muestra si el número que decidas introducir es, o no es Número Prímo.");
            Console.WriteLine();
            Console.WriteLine("Introduce un número para realizar la comprobación.");
            Console.ResetColor();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato no válido! Introduce esta vez un número entero.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return UserInterface.AskForNumPrimo();
        }

        public static int AskForFibonacci()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------");
            Console.WriteLine("Sucesión de Fibonacci:");
            Console.WriteLine("----------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La opción elegída reproduce la Sucesión de Fibonacci incluyendo tántos números como el número que decidas introducir.");
            Console.WriteLine();
            Console.WriteLine("Introduce un número para comenzar la Sucesión.");
            Console.ResetColor();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato no válido! Introduce esta vez un número entero que no supere las 4 cifras.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            return UserInterface.AskForFibonacci();
        }
    }
}

