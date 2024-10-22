using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            n += 1;
            string month;
            switch(m)
            {
                case 1:
                    if (n == 32)
                    {
                        month = "Февраль";
                        n = 1;
                    }
                    else
                    {
                        month = "Январь";
                    }
                    break;
                case 2:
                    if (n == 29)
                    {
                        month = "Март";
                        n = 1;
                    }
                    else
                    {
                        month = "Февраль";
                    }
                    break;
                case 3:
                    if (n == 32)
                    {
                        month = "Апрель";
                        n = 1;
                    }
                    else
                    {
                        month = "Март";
                    }
                    break;
                case 4:
                    if (n == 31)
                    {
                        month = "Май";
                        n = 1;
                    }
                    else
                    {
                        month = "Апрель";
                    }
                    break;
                case 5:
                    if (n == 32)
                    {
                        month = "Июнь";
                        n = 1;
                    }
                    else
                    {
                        month = "Май";
                    }
                    break;
                case 6:
                    if (n == 31)
                    {
                        month = "Июль";
                        n = 1;
                    }
                    else
                    {
                        month = "Июнь";
                    }
                    break;
                case 7:
                    if (n == 32)
                    {
                        month = "Август";
                        n = 1;
                    }
                    else
                    {
                        month = "Июль";
                    }
                    break;
                case 8:
                    if (n == 32)
                    {
                        month = "Сентябрь";
                        n = 1;
                    }
                    else
                    {
                        month = "Август";
                    }
                    break;
                case 9:
                    if (n == 31)
                    {
                        month = "Октябрь";
                        n = 1;
                    }
                    else
                    {
                        month = "Сентябрь";
                    }
                    break;
                case 10:
                    if (n == 32)
                    {
                        month = "Ноябрь";
                        n = 1;
                    }
                    else
                    {
                        month = "Октябрь";
                    }
                    break;
                case 11:
                    if (n == 31)
                    {
                        month = "Декабрь";
                        n = 1;
                    }
                    else
                    {
                        month = "Ноябрь";
                    }
                    break;
                case 12:
                    month = "Декабрь";
                    break;
                default:
                    throw new ArgumentException($"Аргумент должен быть от 1 до 12. Значение {m}");
            }
            string day = Convert.ToString(n);
            string date = $"{day} {month} ";
            return date;
        }
    }
}
