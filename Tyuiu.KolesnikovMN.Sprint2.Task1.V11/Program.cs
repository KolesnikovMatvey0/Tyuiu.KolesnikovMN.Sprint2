using Tyuiu.KolesnikovMN.Sprint2.Task1.V11.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task1.V11
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("*  последовательность можно чередовать, но использовать один раз в        *");
            Console.WriteLine("*  выражении) и логических операций (|, &, ||, &&, !, ^,                  *");
            Console.WriteLine("*  последовательность операций не должна нарушаться), а также             *");
            Console.WriteLine("*  арифметических выражений, которая вернет логическую последовательность *");
            Console.WriteLine("*  (массив): (False, False, True, False, True, False), при a = 145,       *");
            Console.WriteLine("*  b = 156, c = 142, d = 117                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 145, b = 156, c = 142, d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
                Console.WriteLine(res[i]);
            Console.ReadKey();
            
        }
    }
}
