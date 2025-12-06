using Tyuiu.BazilevichAV.Sprint6.Task0.V17.Lib;
namespace Tyuiu.BazilevichAV.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 6.695;
            Assert.AreEqual(wait, res);
        }
    }
}
