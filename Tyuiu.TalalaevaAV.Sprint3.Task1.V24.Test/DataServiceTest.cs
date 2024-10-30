using Tyuiu.TalalaevaAV.Sprint3.Task1.V24.Lib;
namespace Tyuiu.TalalaevaAV.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 12;
            double sum = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.186;
            Assert.AreEqual(wait, sum);
        }
    }
}