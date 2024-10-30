using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TalalaevaAV.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double mult = 1;
            do
            {
                mult = mult * ((Math.Pow(value, 3) * startValue) + 2);
                startValue++;
            }
            while (startValue<=stopValue);
            return Math.Round(mult,3);
        }
    }
}
