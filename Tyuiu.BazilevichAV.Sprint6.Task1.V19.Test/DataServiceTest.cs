using Tyuiu.BazilevichAV.Sprint6.Task1.V19.Lib;
namespace Tyuiu.BazilevichAV.Sprint6.Task1.V19.Test
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
            double[] expected =
            {
                4.67,   // x=-5
                0.43,  // x=-4
                -8.26,  // x=-3
                -9.87,  // x=-2
                -3.98,  // x=-1
                1.00,   // x=0
                0.02,   // x=1
                -1.87,  // x=2
                3.74,  // x=3
                16.43,  // x=4
                24.67   // x=5
            };
            Assert.AreEqual(11, res.Length);
        }
    }
}
