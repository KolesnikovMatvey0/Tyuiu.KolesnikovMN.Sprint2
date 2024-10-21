using Tyuiu.KolesnikovMN.Sprint2.Task2.V17.Lib;

namespace Tyuiu.KolesnikovMN.Sprint2.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            
            bool wait = true;
            var res = ds.CheckDotInShadedArea (x, y);
            
            Assert.AreEqual(wait, res);
        }
    }
}