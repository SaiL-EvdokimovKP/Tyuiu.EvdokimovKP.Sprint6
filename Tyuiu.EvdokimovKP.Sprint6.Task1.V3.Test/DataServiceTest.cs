using Tyuiu.EvdokimovKP.Sprint6.Task1.V3.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int stopValue = 5;
            int startValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] massWait = new double[11];
            massWait[0] = 19.81;
            massWait[1] = 16.79;
            massWait[2] = 13.87;
            massWait[3] = 10.98;
            massWait[4] = 7.94;
            massWait[5] = 3.00;
            massWait[6] = 3.23;
            massWait[7] = -0.45;
            massWait[8] = -3.79;
            massWait[9] = -6.97;
            massWait[10] = -10.00;
            CollectionAssert.AreEqual(res, massWait);
        }
    }
}
