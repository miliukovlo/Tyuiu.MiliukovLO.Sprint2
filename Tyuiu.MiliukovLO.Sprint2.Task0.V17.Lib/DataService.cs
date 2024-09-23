using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = [x == y, x != y, x < y, y > x, x <= y, y >= x];
            return result;
        }
    }
}
