using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolesnikovMN.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            m -= 1;
            string month;
            string day = Convert.ToString(m);

            switch(n)
            {
                case 1: month = "01";break;  
                case 2: if (n < 1) { month = "01"; day = "31"; } else { month = "02"; } break;
                case 3: if (n < 1) { month = "02"; day = "28"; } else month = "03"; break;
                case 4: if (n < 1) { month = "03"; day = "31"; } else month = "04"; break;
                case 5: if (n < 1) { month = "04"; day = "30"; } else month = "05"; break;
                case 6: if (n < 1) { month = "05"; day = "31"; } else month = "06"; break;
                case 7: if (n < 1) { month = "06"; day = "30"; } else month = "07"; break;
                case 8: if (n < 1) { month = "07"; day = "31"; } else month = "08"; break;
                case 9: if (n < 1) { month = "08"; day = "31"; } else month = "09"; break;
                case 10: if (n < 1) { month = "09"; day = "30"; } else month = "10"; break;
                case 11: if (n < 1) { month = "10"; day = "31"; } else month = "11"; break;
                case 12: if (n < 1) { month = "11"; day = "30"; } else month = "12"; break;
                default: throw new ArgumentException($"Аргумент должен быть от 1 до 12. Значение {m}");
            }
            if (day.Length < 2)
            {
                day = "0" + day;
            }
            string date = $"{day}.{month}";
            return date;
            
        }
    }
}
