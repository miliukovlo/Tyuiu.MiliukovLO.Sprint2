using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (
                y == 3 && x == 3
                ||
                y == 3 && x == 4
                ||                
                y == 3 && x == 5
                ||
                y == 3 && x == 9
                ||
                y == 3 && x == 12
                ||
                y == 4 && x == 3
                ||
                y == 4 && x == 4
                ||
                y == 4 && x == 5
                ||
                y == 4 && x == 9
                ||
                y == 4 && x == 12
                ||
                y == 5 && x == 5
                ||
                y == 5 && x == 6
                ||
                y == 5 && x == 7
                ||
                y == 5 && x == 8
                ||
                y == 5 && x == 9
                ||
                y == 5 && x == 12
                ||
                y == 6 && x == 5
                ||
                y == 6 && x == 6
                ||
                y == 6 && x == 7
                ||
                y == 6 && x == 8
                ||
                y == 6 && x == 9
                ||
                y == 6 && x == 12
                ||
                y == 6 && x == 13
                ||
                y == 7 && (x > 2 && x < 14)
                ||
                y == 8 && x == 4
                ||
                y == 8 && (x > 7 || x < 14)
                ||
                y == 9 && x == 4
                ||
                y == 9 && x == 8
                ||
                y == 9 && x == 9
                ||
                y == 9 && x == 10
                ||
                y == 10 && x == 4
                ||
                y == 10 && x == 8
                ||
                y == 10 && x == 9
                ||
                y == 10 && x == 10
                ||
                y == 11 && x == 3
                ||
                y == 11 && x == 4
                ||
                y == 11 && x == 8
                ||
                y == 11 && x == 9
                ||
                y == 11 && x == 10
                ||
                y == 11 && x == 11
                ||
                y == 11 && x == 12
                ||
                y == 12 && x == 4
                ||
                y == 12 && x == 8
                ||
                y == 12 && x == 9
                ||
                y == 12 && x == 10
                ||
                y == 13 && x == 4
                ||
                y == 14 && x == 5
                ||
                y == 14 && x == 6
                ) 
            {
                return true; 
            } 
            else 
            {
                return false; 
            }
        }
    }
}
