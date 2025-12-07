using Tyuiu.BazilevichAV.Sprint6.Task4.V28.Lib;
namespace Tyuiu.BazilevichAV.Sprint6.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] expectedValues =
{
                59.49,   // x = -5
                38.47,   // x = -4
                -2.81,   // x = -3
                -19.67,  // x = -2
                -8.42,   // x = -1
                0.0,    // x = 0
                -6.3,    // x = 1
                -20.14,  // x = 2
                -3.51,   // x = 3
                38.13,   // x = 4
                59.6     // x = 5
            };

            Assert.AreEqual(11, res.Length);
        }
    }
}
