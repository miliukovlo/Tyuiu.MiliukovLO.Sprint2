using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task4.V9.Lib
{
    public class DataService : ISprint2Task4V9
    {
        public double Calculate(double x, double y)
        {
            double z = x + 5 < y + 2 ? Math.Round(Math.Pow(7 + (1 / x * x), y),3) : Math.Round((Math.Pow(x, 4) - 3 / y),3);
            return z;
        }
    }
}
