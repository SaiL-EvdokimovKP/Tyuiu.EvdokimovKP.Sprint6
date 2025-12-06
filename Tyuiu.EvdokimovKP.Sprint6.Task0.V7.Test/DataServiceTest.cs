using Tyuiu.EvdokimovKP.Sprint6.Task0.V7.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.211;
            Assert.AreEqual(res, wait);
        }
    }
}
