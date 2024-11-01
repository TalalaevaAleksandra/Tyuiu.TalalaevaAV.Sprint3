using Tyuiu.TalalaevaAV.Sprint3.Task7.V22.Lib;
namespace Tyuiu.TalalaevaAV.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Талалаева А.В. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага=" + startValue);
            Console.WriteLine("Конец шага="+ stopValue);
            int len=ds.GetMassFunction(startValue, stopValue).Length;
            double[] value;
            value = new double[len];
            value = ds.GetMassFunction(startValue, stopValue);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", startValue, value[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
