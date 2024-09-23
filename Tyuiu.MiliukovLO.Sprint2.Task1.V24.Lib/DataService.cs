using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = [
                a == b | c < d,
                a == b & c >= d,
                a != c || b > d,
                a >= d && c > b,
                !(a < c),
                (a != b) ^ (c >= d)
                ];
            return res;
        }
    }
}
