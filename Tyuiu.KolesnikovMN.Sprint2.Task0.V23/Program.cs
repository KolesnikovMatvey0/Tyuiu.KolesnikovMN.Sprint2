﻿using Tyuiu.KolesnikovMN.Sprint2.Task0.V23.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("*  последовательность операций не должна нарушаться) и арифметических     *");
            Console.WriteLine("*  выражений, которая вернет логическую последовательность(массив):       *");
            Console.WriteLine("*  (True, False, True, True, False, True),  при x = 105, y = 795          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
                Console.WriteLine(res[i]);
            Console.ReadKey();
        }
    }
}
