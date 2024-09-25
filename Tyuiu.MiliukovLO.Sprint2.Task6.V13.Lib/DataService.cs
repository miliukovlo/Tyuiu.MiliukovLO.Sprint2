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
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 2:
                    if (n < 29)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 3:
                    if (n < 31)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 4:
                    if (n < 30)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 5:
                    if (n < 31)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 6:
                    if (n < 30)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 7:
                    if (n < 31)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 8:
                    if (n < 31)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 9:
                    if (n < 30)
                    {
                        return $"0{n + 1}.0{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.0{m + 1}.{g}";
                    }
                case 10:
                    if (n < 31)
                    {
                        return $"0{n + 1}.{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.{m+1}.{g}";
                    }
                case 11:
                    if (n < 30)
                    {
                        return $"0{n + 1}.{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.{m+1}.{g}";
                    }
                case 12:
                    if (n < 31)
                    {
                        return $"0{n+1}.{m}.{g}";
                    }
                    else
                    {
                        return $"0{1}.{1}.{g}";
                    }
                default:
                        return $"{g}.{m}.{n+1}";

            }
         }
    }
}
