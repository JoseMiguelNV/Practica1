using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PracticaApp.View
{
    class UserInterface
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---- Bienvenido ----");
            Console.WriteLine();
            Console.WriteLine("Elige una de las siguientes opciones:");
            Console.WriteLine();
            Console.WriteLine("1.- Potencia en base 2");
            Console.WriteLine("2.- Sumatorio");
            Console.WriteLine("3.- Factorial");
            Console.WriteLine("4.- Números Primos");
            Console.WriteLine("5.- Serie Fibonacci");
            Console.WriteLine("6.- Salir");
            Console.WriteLine();
        }

        public static int AskFor2Potencia()
        {
            Console.WriteLine("Introduce un número para elevarlo en base a 2 y obtener su poténcia.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int AskSumatorio()
        {
            Console.WriteLine("Introduce un número para calcular su Sumatório.");
            return Convert.ToInt32(Console.ReadLine());
        } 

        public static double AskForFactorialNumber()
        {
            Console.WriteLine("Introduce un número para calcular su factorial.");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static int AskForNumPrimo()
        {
            Console.WriteLine("Introduce un número para comprobar si es Número Primo.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void AskForFibonacci()
        {
            Console.WriteLine("Introduce cualquier número para iniciar la Sucesión de Fibonacci.");
            Convert.ToInt32(Console.ReadLine());
        }

        public static void Exit()
        {
            Environment.Exit(0);

        }
    }
}
