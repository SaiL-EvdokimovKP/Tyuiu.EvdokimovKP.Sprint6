using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.EvdokimovKP.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double y = (Math.Pow(x, 3)) / (2 * (Math.Pow((x + 5), 2)));
            return Math.Round(y, 3);
        }
    }
}
