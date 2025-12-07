using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BazilevichAV.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;

                if (x == 0)
                {
                    result = 0.0;
                }
                else
                {
                    result = Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + (2 * x);
                }

                res[index] = Math.Round(result, 2);
                index++;
            }

            return res;
        }
    }
}
