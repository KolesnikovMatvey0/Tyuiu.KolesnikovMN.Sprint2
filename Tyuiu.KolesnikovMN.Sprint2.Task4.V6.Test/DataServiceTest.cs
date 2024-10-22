using Tyuiu.KolesnikovMN.Sprint2.Task4.V6.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditions1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);
            double wait = 1;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditions2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 11;

            var res = ds.Calculate(x, y);
            double wait = 129;

            Assert.AreEqual(wait, res);
        }
    }
}