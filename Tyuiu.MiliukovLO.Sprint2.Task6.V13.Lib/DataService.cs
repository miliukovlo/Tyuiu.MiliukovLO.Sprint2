using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MiliukovLO.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    } else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 2:
                    if (n < 29)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 3:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 4:
                    if (n < 30)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 5:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 6:
                    if (n < 30)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 7:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 8:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 9:
                    if (n < 30)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 10:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 11:
                    if (n < 30)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                case 12:
                    if (n < 31)
                    {
                        return $"{g}.{m}.{n+1}";
                    }
                    else
                    {
                        return $"{g}.{m+1}.{1}";
                    }
                default:
                        return $"{g}.{m}.{n+1}";

            }
         }
    }
}
