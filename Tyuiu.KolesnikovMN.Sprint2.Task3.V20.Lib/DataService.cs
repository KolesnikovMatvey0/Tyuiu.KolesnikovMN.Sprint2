using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolesnikovMN.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double res;

            if (x > 1)
            {
                res = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x ==0)
            {
                res = (Math.Pow(x, 2) - Math.Cos(x * x) + 10) / (Math.Pow(x, 2) - Math.Sin(x * x) + 12);
            }
            else if ((-24 < x) && (x < 2))
            {
                res = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else
            {
                res = x + (10 * x) - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
