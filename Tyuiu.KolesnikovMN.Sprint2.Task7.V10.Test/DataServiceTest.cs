using Tyuiu.KolesnikovMN.Sprint2.Task7.V10.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 1;

            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}