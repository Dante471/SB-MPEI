using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            lab1();
            lab2();
        }

            public static void lab1() 
            {
                Console.WriteLine("\n===========================");

                Console.WriteLine("Лабораторная №1:\n" +
                    "Вычисление среднего арифметического квадратов и модулей двух чисел: ");
                Console.WriteLine("Введите первое число: ");
                double num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double num2 = int.Parse(Console.ReadLine());
                double num1Sq = Math.Pow(num1, 2);
                double num2Sq = Math.Pow(num2, 2);
                double averageNumSq = (num1Sq + num2Sq) / 2;
                Console.WriteLine("Среднее арифметическое квадратов чисел " + num1 + " и " + num2 + " составляет " + averageNumSq);
                double num1Abs = Math.Abs(num1);
                double num2Abs = Math.Abs(num2);
                double averageNumAbs = (num1Abs + num2Abs) / 2;
                Console.WriteLine("Среднее арифметическое модулей чисел " + num1 + " и " + num2 + " составляет " + averageNumAbs);
            }


            public static void lab2()
            {
                Console.WriteLine("Лабораторная №2:\n"+ "Вычисление выражения: ");
                Console.WriteLine("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(Math.Pow(Math.Pow(x, 4), 0.2) + Math.Pow(Math.Pow(x, 4 - x), 0.2)) + Math.Log(Math.Abs(x - 20.5));
                Console.WriteLine("Результат вычисления при x = " + x + ": " + result);
            }

    }
}

