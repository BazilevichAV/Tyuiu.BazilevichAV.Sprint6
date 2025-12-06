using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BazilevichAV.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;

                // Обработка особого случая x = -2
                if (x == -2)
                {
                    result = 0.0;
                }
                else
                {
                    // Формула: cos(x) + cos(x)/(x+2) - 3x
                    result = Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x;
                }

                res[index] = Math.Round(result, 2);
                index++;
            }

            return res;
        }
    }
}
