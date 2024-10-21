using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolesnikovMN.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (b < d) | (c == a);
            res[1] = (b == d) & (c > a);
            res[2] = (b > d) || (c == a);
            res[3] = (b > d) && (c == a);
            res[4] = !(b < d);
            res[5] = (b > d) ^ (c < a);

            return res;
        }
    }
}
