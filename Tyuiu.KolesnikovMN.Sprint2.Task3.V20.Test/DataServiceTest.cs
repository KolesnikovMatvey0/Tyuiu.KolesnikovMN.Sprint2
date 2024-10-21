using Tyuiu.KolesnikovMN.Sprint2.Task3.V20.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            var res = ds.Calculate(x);
            double wait = 0.905;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -100;
            var res = ds.Calculate(x);
            double wait = -1099.99;
            Assert.AreEqual(wait, res);
        }
    }
}