using Tyuiu.MiliukovLO.Sprint2.Task1.V24.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #1                                                               ");
        Console.WriteLine("* Вариант #24                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          ");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в          ");
        Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,                  ");
        Console.WriteLine("* последовательность операций не должна нарушаться), а также арифметических");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):         ");
        Console.WriteLine("* (True, False, True, False, True, False), при                             ");
        Console.WriteLine("* a = 325, b = 325, c = 242, d = 324                                       ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int x, y,w,z;
        Console.WriteLine("* Введите значние х:                                                       ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние w:                                                       ");
        w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние z:                                                       ");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        var res = ds.GetLogicOperations(x, y, w, z);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}