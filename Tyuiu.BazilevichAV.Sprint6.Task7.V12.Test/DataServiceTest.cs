using Microsoft.ApplicationInsights;
using Tyuiu.BazilevichAV.Sprint6.Task7.V12.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BazilevichAV.Sprint6.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V12.csv";

            int[,] matrix = ds.GetMatrix(path);

            // Проверяем размеры (10x10)
            Assert.AreEqual(10, matrix.GetLength(0)); // строки
            Assert.AreEqual(10, matrix.GetLength(1)); // столбцы

            // Проверяем несколько значений
            Assert.AreEqual(17, matrix[0, 0]);
            Assert.AreEqual(-13, matrix[1, 1]);
            Assert.AreEqual(17, matrix[5, 5]);
        }

        [TestMethod]
        public void ValidGetMatrixAndTransform()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V12.csv";

            int[,] matrix = ds.GetMatrixAndTransform(path);

            Assert.AreEqual(10, matrix.GetLength(0));
            Assert.AreEqual(10, matrix.GetLength(1));

            Assert.AreEqual(0, matrix[0, 8]);
            Assert.AreEqual(0, matrix[1, 8]);
            Assert.AreEqual(0, matrix[2, 8]);
            Assert.AreEqual(0, matrix[3, 8]);
            Assert.AreEqual(0, matrix[4, 8]);
            Assert.AreEqual(0, matrix[5, 8]);
            Assert.AreEqual(0, matrix[6, 8]);
            Assert.AreEqual(0, matrix[7, 8]);
            Assert.AreEqual(0, matrix[8, 8]);
            Assert.AreEqual(0, matrix[9, 8]);

            // Проверяем, что другие столбцы не изменились
            Assert.AreEqual(17, matrix[0, 0]);
            Assert.AreEqual(-13, matrix[1, 1]);
            Assert.AreEqual(17, matrix[5, 5]);
        }
    }
}