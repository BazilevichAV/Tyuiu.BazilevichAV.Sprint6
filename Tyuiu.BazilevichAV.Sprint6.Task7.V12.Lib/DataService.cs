using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BazilevichAV.Sprint6.Task7.V12.Lib
{
  
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = 10;
            int cols = 10;
            int targetColumn = 8;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    // Проверяем, есть ли значение в ячейке
                    if (j < values.Length && !string.IsNullOrWhiteSpace(values[j]))
                    {
                        int value = int.Parse(values[j].Trim());

                        // Если это 9-й столбец и значение не равно 10
                        if (j == targetColumn && value != 10)
                        {
                            matrix[i, j] = 0;
                        }
                        else
                        {
                            matrix[i, j] = value;
                        }
                    }
                    else
                    {
                        // Если ячейка пустая, записываем 0
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

            

        public int[,] GetMatrixAndTransform(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = 10;
            int cols = 10;
            int targetColumn = 8;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j].Trim());
                }
            }

            return matrix;
        }
    }
}

