using Tyuiu.MiliukovLO.Sprint2.Task0.V17.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #0                                                               ");
        Console.WriteLine("* Вариант #17                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=           ");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических       ");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):         ");
        Console.WriteLine("* при x = 1065, y = 755                                                    ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("* Введите значние х:                                                       ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        var res = ds.GetCompareOperations(x, y);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}