// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool valChange = true;

            while (valChange)
            {
                Console.Clear();
                System.Console.WriteLine("Coloque o primeiro valor: ");
                float value1 = float.Parse(Console.ReadLine());
                System.Console.WriteLine("Coloque o segundo valor: ");
                float value2 = float.Parse(Console.ReadLine());

                short choice = Menu();

                switch (choice)
                {
                    case 1:
                        {
                            Soma(value1, value2);
                            break;
                        }
                    case 2:
                        {
                            Subtracao(value1, value2);
                            break;
                        }
                    case 3:
                        {
                            Multipicacao(value1, value2);
                            break;
                        }
                    case 4:
                        {
                            Divicao(value1, value2);
                            break;
                        }
                    case 5:{
                        Console.Clear();
                        System.Console.WriteLine("Obrigado!");
                        valChange = false;
                        break;
                    }
                    default:
                        Menu();
                        break;
                }
            }
        }

        static short Menu()
        {

            System.Console.Clear();
            System.Console.WriteLine("------------------------------------------------------------------------------");
            System.Console.WriteLine("1 - Soma; 2 - Subtração; 3 - Multiplicação; 4 - Divisão; 5 - Sair da execução");
            System.Console.WriteLine("Digite a operação que quer ser realizada: ");
            short choice = short.Parse(Console.ReadLine());
            System.Console.WriteLine("------------------------------------------------------------------------------");
            return choice;
        }

        static void Soma(float value1, float value2)
        {
            Console.Clear();
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"O resultado da soma de {value1} + {value2} é: {value1 + value2}");
            System.Console.WriteLine("-----------------------");
            Console.ReadKey();
        }

        static void Subtracao(float value1, float value2)
        {
            Console.Clear();
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"O resultado da subtração de {value1} - {value2} é: {value1 - value2}");
            System.Console.WriteLine("-----------------------");
            Console.ReadKey();
        }

        static void Multipicacao(float value1, float value2)
        {
            Console.Clear();
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"O resultado da multiplicação de {value1} * {value2} é: {value1 * value2}");
            System.Console.WriteLine("-----------------------");
            Console.ReadKey();
        }

        static void Divicao(float value1, float value2)
        {
            Console.Clear();
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"O resultado da divição de {value1} / {value2} é: {value1 / value2}");
            System.Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}