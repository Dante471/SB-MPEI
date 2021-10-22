using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LabWork2
    {
        static void Main(string[] args) { 
        Console.WriteLine("Лабораторная №2:\n" +
                    "Вычисление выражения: ");
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
        double result = Math.Sqrt(Math.Pow(Math.Pow(x, 4), 0.2) + Math.Pow(Math.Pow(x, 4 - x), 0.2)) + Math.Log(Math.Abs(x - 20.5));
        Console.WriteLine("Результат вычисления при x = " + x + ": " + result);
        }
    }
}
