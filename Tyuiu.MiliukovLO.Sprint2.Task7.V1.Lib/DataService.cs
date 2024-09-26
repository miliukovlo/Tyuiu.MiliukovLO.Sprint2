using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y > 0 && (x == y || -x == y))
            {
                return true;
            }
            return false;
        }
    }
}
