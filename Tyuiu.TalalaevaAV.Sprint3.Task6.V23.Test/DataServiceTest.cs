using Tyuiu.TalalaevaAV.Sprint3.Task6.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int res=ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 34;
            Assert.AreEqual(res,wait);
        }
    }
}