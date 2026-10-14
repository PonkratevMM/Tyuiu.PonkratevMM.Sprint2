using Tyuiu.PonkratevMM.Sprint2.Task6.V4.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task5.V5;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();




        Console.Title = "Спринт #2 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #2                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #6                                        *");
        Console.WriteLine("* Вариант #4                                        *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Мастям игральных карт условно присвоены следующие *");
        Console.WriteLine("* порядковые номера: масти «пики» — 1, масти        *");
        Console.WriteLine("* «трефы» — 2, масти «бубны» — 3, масти «червы» — 4 *");
        Console.WriteLine("* По заданному номеру масти m определить название   *");
        Console.WriteLine("* соответствующей масти.                            *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите номер масти: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string res;
        if ((num < 1) || (num > 4))
        {
            res = "Введенно неверное значение!";

        }
        else
        {
            res = "Это масть: " + ds.FindCardSuit(num);
        }


        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine(res);


        Console.ReadKey();

    }

}