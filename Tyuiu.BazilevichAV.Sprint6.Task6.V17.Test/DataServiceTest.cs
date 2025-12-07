using Microsoft.ApplicationInsights;
using Tyuiu.BazilevichAV.Sprint6.Task6.V17.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BazilevichAV.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}