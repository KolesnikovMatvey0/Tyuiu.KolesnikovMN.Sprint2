using Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int n = 9;
            int m = 2;

            var res = ds.FindDateOfNextDay(m, n);
            string wait = "10.02";
            
            Assert.AreEqual(wait, res);
        }
    }
}