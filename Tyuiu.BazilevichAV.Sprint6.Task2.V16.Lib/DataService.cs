using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BazilevichAV.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
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
                    result = -0.5;
                }
                else
                {
                    result = Math.Cos(x) / (x - 0.4) + Math.Sin(x) * (8 * x) + 2;
                }

                res[index] = Math.Round(result, 2);
                index++;
            }

            return res;
        }
    }
}
