using PracticaApp.Model;
using PracticaApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaApp.Controller
{
    class Programa
    {
        public void Run()
        {
            byte option = 0;
            do
            {
                UserInterface.ShowMainMenu();
                try
                {
                    option = Convert.ToByte(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            int num1 = UserInterface.AskFor2Potencia();
                            int resultado1 = MathCalculator.Numero2Potencia(num1);
                            Console.WriteLine("La poténcia de 2 elevado a " + num1 + " es " + resultado1 + ".");
                            break;
                        case 2:
                            int num2 = UserInterface.AskSumatorio();
                            int resultado2 = MathCalculator.Sumatorio(num2);
                            Console.WriteLine("El Sumatorio de " + num2 + " es " + resultado2 + ".");
                            break;
                        case 3:
                            double num3 = UserInterface.AskForFactorialNumber();
                            double resultado3 = MathCalculator.Factorial(num3);
                            Console.WriteLine("El Factorial de " + num3 + " es " + resultado3 + ".");
                            break;
                        case 4:
                            int num4 = UserInterface.AskForNumPrimo();
                            MathCalculator.NumeroPrimo(num4);
                            break;
                        case 5:
                            UserInterface.AskForFibonacci();
                            MathCalculator.SerieFibonacci();
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                            Console.WriteLine("Esta ha sido la Sucesión de Fibonacci con sus primeros 80 números... que la disfrutes!");
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Hasta pronto!");
                            Environment.Exit(0);
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("¡Error de formato! Vuelve a comenzar introduciendo un número entero!");
                    Console.WriteLine();
                }
            } while (option != 6);
        }
    }
}
