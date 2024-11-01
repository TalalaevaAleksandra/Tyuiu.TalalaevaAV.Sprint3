using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TalalaevaAV.Sprint3.Task7.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len=stopValue-startValue+1;
            value=new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0) 
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(2 * x) / 2) - 1.5 * x)), 2);
                    value[count] = y;
                    count++;
                }
                if (x == 0)
                {
                    value[count]=0;
                    count++;
                }
            }   
            return value;
        }
    }
}
