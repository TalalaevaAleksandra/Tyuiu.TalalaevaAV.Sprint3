using Tyuiu.TalalaevaAV.Sprint3.Task7.V22.Lib;
namespace Tyuiu.TalalaevaAV.Sprint3.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len=stopValue-startValue+1;
            double[] wait;
            wait = new double[len];
            wait[0] =8.04 ;
            wait[1] = 6.68;
            wait[2] =  4.84;
            wait[3] =  1.76;
            wait[4] = 0.45;
            wait[5] =0.5;
            wait[6] = -0.87;
            wait[7] = -2.42;
            wait[8] =-3.88;
            wait[9] =-6.83;
            wait[10] =-8.88 ;
            double[] res;
            res = new double[len];
            res=ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}