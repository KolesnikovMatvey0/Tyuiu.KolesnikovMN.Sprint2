using Tyuiu.KolesnikovMN.Sprint2.Task6.V8.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int n = 1;
            int m = 9;
            var res = ds.FindDateOfPreviousDay(m, n);
            string wait = "31.08";

            Assert.AreEqual(wait, res);
        }
    }
}