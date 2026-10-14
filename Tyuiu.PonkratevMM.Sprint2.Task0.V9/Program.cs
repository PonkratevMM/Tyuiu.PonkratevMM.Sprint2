using Tyuiu.PonkratevMM.Sprint2.Task0.V9.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task0.V9;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 1054;
        int y = 375;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);


        Console.Title = "Спринт #2 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #2                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #0                                        *");
        Console.WriteLine("* Вариант #9                                        *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу из операций сравнений          *");
        Console.WriteLine("* и арифметических выражений,которая вернет         *");
        Console.WriteLine("* логическую последовательность при                 *");
        Console.WriteLine("* x = 1054, y = 375                                 *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");


        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();

    }

}