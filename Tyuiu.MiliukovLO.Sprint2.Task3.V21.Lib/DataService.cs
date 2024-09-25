﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * Math.Pow((x + 9) / (x - 1) - 3, x), 3);
            }
            else if (x == 0)
            {
                return Math.Round((x * x + 10) / ((x * x) - Math.Sin(x * x) + 12), 3);
            }
            else if (x > -25 && x < 2)
            {
                return Math.Round(Math.Pow((1 + 1 / (x * x)), x), 3);
            }
            else if (x < -25)
            {
                return Math.Round(x + 10 * x - 1 / x, 3);
            }
            else return 0;
        }
    }
}
