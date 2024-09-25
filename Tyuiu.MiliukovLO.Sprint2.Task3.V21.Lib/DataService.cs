using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return x * Math.Pow(((x + 9) / (x - 1)), x);
            }
            else if (x == 0)
            {
                return (x * x + 10) / ((x * x) - Math.Sin(x * x) + 12);
            }
            else if (x > -25 && x < 2)
            {
                return Math.Pow((1 + 1 / (x * x)), x);
            }
            else if (x < -25)
            {
                return x + 10 * x - 1 / x;
            }
            else return 0;
        }
    }
}
