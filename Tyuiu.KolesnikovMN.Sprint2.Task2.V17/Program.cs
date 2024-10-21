using Tyuiu.KolesnikovMN.Sprint2.Task2.V17.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу на, которая запрашивает целые значения с клавиатуры *");
            Console.WriteLine("*   и вычисляет находится ли точка с координатами X,Y в заштрихованной    *");
            Console.WriteLine("*  области.                                                               *");
            Console.WriteLine("*  (True, False, True, True, False, True),  при x = 105, y = 795          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;

            Console.WriteLine("ВВедите значение переменной X: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("ВВедите значение переменной Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            var res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res == true)
            {
                Console.WriteLine("Точка находится в заштихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштихованной области");
            }

            Console.ReadKey();
        }
    }
}
