using Tyuiu.MiliukovLO.Sprint2.Task4.V9.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #4                                                               ");
        Console.WriteLine("* Вариант #24                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c использованием");
        Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y с ");
        Console.WriteLine("* c клавиатуры, если x+5<y+2, то z=(7+1/x^2)^y иначе x^4-3/y               ");
        Console.WriteLine("* до трех знаков после запятой                                             ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите значние х:                                                       ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadKey();
    }
}