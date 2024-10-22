using Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int n = 8;
            int m = 9;

            var res = ds.FindDateOfNextDay(m, n);
            string wait = "09.09";
            
            Assert.AreEqual(wait, res);
        }
    }
}