using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; ++i)
            {
                Console.Write(i + ": ");
                if (i % 3 == 0)
                {
                    Console.Write("ping ");
                }

                if (i % 5 == 0)
                {
                    Console.Write("pong");
                }

                Console.WriteLine();

            }

            Console.WriteLine("===========================");

            int year = 2104;
            if ((year % 4 != 0 || year % 100 == 0) && year % 400 != 0)
            {
                Console.WriteLine(year + " год не является високосным");
            }
            else
            {
                Console.WriteLine(year + " год является високосным");
            }

            Console.WriteLine("===========================");

            int iter = 0;
            int a = 0;
            int b = 1;
            while (iter < 5)
            {
                ++iter;
                Console.Write(a + " " + b + " ");
                a += b;
                b += a;
            }


            Console.WriteLine("\n===========================");

            double num1 = 4;
            double num2 = 6;
            double num1Sq = Math.Pow(num1, 2);
            double num2Sq = Math.Pow(num2, 2);
            double averageNumSq = (num1Sq + num2Sq) / 2;
            Console.WriteLine("Среднее арифметическое квадратов чисел " + num1 + " и " + num2 + " составляет " + averageNumSq);
            double num1Abs = Math.Abs(num1);
            double num2Abs = Math.Abs(num2);
            double averageNumAbs = (num1Abs + num2Abs) / 2;
            Console.WriteLine("Среднее арифметическое модулей чисел " + num1 + " и " + num2 + " составляет " + averageNumAbs);

        }
    }
}

