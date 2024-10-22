using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string day = Convert.ToString(n + 1);
            string month;
            n += 1;

            switch(m)
            {
                case 1:
                    if (n == 32)
                    {
                        month = "02";
                        day = "01";
                    }
                    else
                    {
                        month = "01";
                    }
                    break;
                case 2:
                    if (n == 29)
                    {
                        month = "03";
                        day = "01";
                    }
                    else
                    {
                        month = "02";
                    }
                    break;
                case 3:
                    if (n == 32)
                    {
                        month = "04";
                        day = "01";
                    }
                    else
                    {
                        month = "03";
                    }
                    break;
                case 4:
                    if (n == 31)
                    {
                        month = "05";
                        day = "01";
                    }
                    else
                    {
                        month = "04";
                    }
                    break;
                case 5:
                    if (n == 32)
                    {
                        month = "06";
                        day = "01";
                    }
                    else
                    {
                        month = "05";
                    }
                    break;
                case 6:
                    if (n == 31)
                    {
                        month = "07";
                        day = "01";
                    }
                    else
                    {
                        month = "06";
                    }
                    break;
                case 7:
                    if (n == 32)
                    {
                        month = "08";
                        day = "01";
                    }
                    else
                    {
                        month = "07";
                    }
                    break;
                case 8:
                    if (n == 32)
                    {
                        month = "09";
                        day = "01";
                    }
                    else
                    {
                        month = "08";
                    }
                    break;
                case 9:
                    if (n == 31)
                    {
                        month = "10";
                        day = "01";
                    }
                    else
                    {
                        month = "9";
                    }
                    break;
                case 10:
                    if (n == 32)
                    {
                        month = "11";
                        day = "01";
                    }
                    else
                    {
                        month = "10";
                    }
                    break;
                case 11:
                    if (n == 31)
                    {
                        month = "12";
                        day = "01";
                    }
                    else
                    {
                        month = "11";
                    }
                    break;
                case 12:
                    month = "12";
                    break;
                default:
                    throw new ArgumentException($"Аргумент должен быть от 1 до 12. Значение {m}");
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            string date = $"{day}.{month}";
            return date;
        }
    }
}
