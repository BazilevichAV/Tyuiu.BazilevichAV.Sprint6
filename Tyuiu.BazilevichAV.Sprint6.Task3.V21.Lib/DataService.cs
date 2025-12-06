using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BazilevichAV.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (resultMatrix[i, 0] > resultMatrix[j, 0])
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = resultMatrix[i, k];
                            resultMatrix[i, k] = resultMatrix[j, k];
                            resultMatrix[j, k] = temp;
                        }
                    }
                }
            }

            return resultMatrix;
        }
    }
}
