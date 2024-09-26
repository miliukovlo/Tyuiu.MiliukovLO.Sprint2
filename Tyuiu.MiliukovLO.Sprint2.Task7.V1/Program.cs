using Tyuiu.MiliukovLO.Sprint2.Task7.V1.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #7                                                               ");
        Console.WriteLine("* Вариант #1                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные            ");
        Console.WriteLine("* вещественные значения) и вычисляет, находится ли точка с координатами X,Y");
        Console.WriteLine("* в заштрихованной области.                                                ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите значние х:                                                       ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CheckDotInShadedArea(x, y));

        Console.ReadKey();
    }
}