using Tyuiu.PonkratevMM.Sprint2.Task2.V22.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task2.V22;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        


        Console.Title = "Спринт #2 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #2                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #2                                        *");
        Console.WriteLine("* Вариант #22                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые  *");
        Console.WriteLine("* значения с клавиатуры и вычисляет находится ли    *");
        Console.WriteLine("* точка с координатами X,Y в заштрихованной области.*");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите значение переменной X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);


        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        if (res)
        {
            Console.WriteLine("Точка находиться в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находиться в заштрихованной области");
        }

        Console.ReadKey();

    }

}