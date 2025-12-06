using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.EvdokimovKP.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int res = 0;
            double[] res2 = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 0.5) == 0)
                {
                    res2[res] = 0;
                }
                else
                {
                    res2[res] = Math.Round(5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5)),2);
                }
                res++;
            }
            return res2;
        }
    }
}
