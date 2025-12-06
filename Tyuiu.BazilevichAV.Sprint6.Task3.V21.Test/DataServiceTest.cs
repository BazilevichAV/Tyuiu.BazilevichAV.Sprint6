using Tyuiu.BazilevichAV.Sprint6.Task3.V21.Lib;
namespace Tyuiu.BazilevichAV.Sprint6.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
        {26, -15,   7,   1,  -4},
        {14,  26,  22,  17,  27},
        {-8,  31,  22,  34,   4},
        {-18,  16,  -2,  16,  27},
        {5,   2,  -4,  16,  15}
            };

            int[,] result = ds.Calculate(matrix);
            
            Assert.AreEqual(-18, result[0, 0]); 
            Assert.AreEqual(-8, result[1, 0]);  
            Assert.AreEqual(5, result[2, 0]);   
            Assert.AreEqual(14, result[3, 0]); 
            Assert.AreEqual(26, result[4, 0]);

            // Первая строка (бывшая строка 3)
            Assert.AreEqual(-18, result[0, 0]);
            Assert.AreEqual(16, result[0, 1]);
            Assert.AreEqual(-2, result[0, 2]);
            Assert.AreEqual(16, result[0, 3]);
            Assert.AreEqual(27, result[0, 4]);

            // Вторая строка (бывшая строка 2)
            Assert.AreEqual(-8, result[1, 0]);
            Assert.AreEqual(31, result[1, 1]);
            Assert.AreEqual(22, result[1, 2]);
            Assert.AreEqual(34, result[1, 3]);
            Assert.AreEqual(4, result[1, 4]);

            // Третья строка (бывшая строка 4)
            Assert.AreEqual(5, result[2, 0]);
            Assert.AreEqual(2, result[2, 1]);
            Assert.AreEqual(-4, result[2, 2]);
            Assert.AreEqual(16, result[2, 3]);
            Assert.AreEqual(15, result[2, 4]);

            // Четвертая строка (бывшая строка 1)
            Assert.AreEqual(14, result[3, 0]);
            Assert.AreEqual(26, result[3, 1]);
            Assert.AreEqual(22, result[3, 2]);
            Assert.AreEqual(17, result[3, 3]);
            Assert.AreEqual(27, result[3, 4]);

            // Пятая строка (бывшая строка 0)
            Assert.AreEqual(26, result[4, 0]);
            Assert.AreEqual(-15, result[4, 1]);
            Assert.AreEqual(7, result[4, 2]);
            Assert.AreEqual(1, result[4, 3]);
            Assert.AreEqual(-4, result[4, 4]);
        }
    }
}
