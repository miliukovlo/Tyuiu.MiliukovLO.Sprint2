using Tyuiu.MiliukovLO.Sprint2.Task6.V13.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #6                                                               ");
        Console.WriteLine("* Вариант #13                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:          ");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным            ");
        Console.WriteLine("* g, n и m определить дату следующего дня. Заданный год является високосным");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите значние х:                                                       ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние z:                                                       ");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDateOfNextDay(x, y,z));

        Console.ReadKey();
    }
}