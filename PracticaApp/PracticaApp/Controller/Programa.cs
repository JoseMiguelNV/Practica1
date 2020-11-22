﻿using PracticaApp.Model;
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
            int option = 0;
            do
            {
                option = UserInterface.ShowMainMenu();
                {
                    //option = Convert.ToInt32(Console.ReadLine());
                    
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            int num1 = UserInterface.AskFor2Potencia();
                            //if (num1 == int.minValue)
                            // console writeline....
                            double resultado1 = MathCalculator.CalculoPotencia(num1);
                            Console.WriteLine("La poténcia de 2^" + num1 + " es " + resultado1 + ".");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            int num2 = UserInterface.AskSumatorio();
                            int resultado2 = MathCalculator.CalcularSumatorio(num2);
                            Console.WriteLine("El Sumatorio de " + num2 + " es " + resultado2 + ".");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            int num3 = UserInterface.AskForFactorialNumber();
                            double resultado3 = MathCalculator.CalcularFactorial(num3);
                            Console.WriteLine("El Factorial de " + num3 + " es " + resultado3 + ".");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            int num4 = UserInterface.AskForNumPrimo();
                            bool es_primo = MathCalculator.EsNumeroPrimo(num4);
                            if (es_primo)
                                Console.WriteLine("El número " + num4 + " no es Prímo.");
                            else
                                Console.WriteLine("El número " + num4 + " es Prímo.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            int num5 = UserInterface.AskForFibonacci();
                            MathCalculator.SerieFibonacci(num5);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 0:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Lamento mucho que te vayas...");
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-------------");
                            Console.WriteLine("Hasta pronto!");
                            Console.WriteLine("-------------");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("               ");
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("  VIVA ESPAÑA  ");
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("               ");
                            Console.ResetColor();

                            break;
                        default:
                           
                            if (option >= 6)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Has introducido un número muy elevado, introduce un número del 1 al 5.");
                                Console.ResetColor();
                            }
                            break;

                    }

                }
               
            } while (option != 0);
      
            
        }
    }
}
