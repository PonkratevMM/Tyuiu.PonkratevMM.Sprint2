using Tyuiu.PonkratevMM.Sprint2.Task7.V15.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task7.V15;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();




        Console.Title = "Спринт #2 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #2                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #7                                        *");
        Console.WriteLine("* Вариант #15                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает     *");
        Console.WriteLine("* исходные данные и вычисляет, находится ли точка с *");
        Console.WriteLine("* координатами X,Y в заштрихованной области.        *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите значние перемнной X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значние перемнной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);


        


        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");

        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }


        Console.ReadKey();

    }

}