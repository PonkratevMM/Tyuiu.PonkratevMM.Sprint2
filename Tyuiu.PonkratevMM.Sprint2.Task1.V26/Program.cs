using Tyuiu.PonkratevMM.Sprint2.Task1.V26.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task1.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 654;
        int b = 671;
        int c = 874;
        int d = 137;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);


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
        Console.WriteLine("* и логических операций, а также арифметических     *");
        Console.WriteLine("* выражений, которая вернет логическую              *");
        Console.WriteLine("* последовательность , при a = 654, b = 671,        *");
        Console.WriteLine("* c = 874, d = 137                                  *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");


        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);

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