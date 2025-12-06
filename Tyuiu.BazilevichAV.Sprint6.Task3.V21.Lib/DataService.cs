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

            // Собираем значения первого столбца
            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = resultMatrix[i, 0];
            }

            // Сортируем значения первого столбца
            Array.Sort(firstColumn);

            // Записываем отсортированные значения обратно в первый столбец
            for (int i = 0; i < rows; i++)
            {
                resultMatrix[i, 0] = firstColumn[i];
            }

            return resultMatrix;
        }
    }
}
