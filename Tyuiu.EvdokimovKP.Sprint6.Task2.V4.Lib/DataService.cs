using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.EvdokimovKP.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int res = 0;
            double[] res2 = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 2) == 0)
                {
                    res2[res] = 0;
                }
                else
                {
                    res2[res] = Math.Round(((((5 * x) + 2.5)/ (Math.Sin(x) + 2))) + 2 * x + 2, 2);
                }
                res++;
            }
            return res2;
        }
    }
}
