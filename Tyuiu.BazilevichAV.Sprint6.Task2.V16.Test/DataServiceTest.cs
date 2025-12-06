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
                15.19,   // x=-5
                11.67,  // x=-4
                9.0,  // x=-3
                0.0,  // x=-2
                4.08,  // x=-1
                1.5,   // x=0
                -2.28,   // x=1
                -6.52,  // x=2
                -10.19,  // x=3
                -12.76,  // x=4
                -14.68   // x=5
            };
            Assert.AreEqual(11, res.Length);
        }
    }
}
