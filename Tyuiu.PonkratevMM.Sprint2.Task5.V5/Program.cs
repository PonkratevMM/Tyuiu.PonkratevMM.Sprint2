using Tyuiu.PonkratevMM.Sprint2.Task5.V5.Lib;
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
        Console.WriteLine("* Задание #5                                        *");
        Console.WriteLine("* Вариант #5                                        *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Игральным картам условно присвоены следующие      *");
        Console.WriteLine("* порядковые номера в зависимости от их достоинства:*");
        Console.WriteLine("* «валету» — 11, «даме» — 12, «королю» — 13,        *");
        Console.WriteLine("* «тузу» — 14. Порядковые номера остальных карт     *");
        Console.WriteLine("* соответствуют их названиям. По заданному номеру   *");
        Console.WriteLine("* карты k  определить достоинство соответствующей   *");
        Console.WriteLine("* карты.                                            *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите номер карты: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string res;
        if ((num < 5) || (num > 14))
        {
            res = "Введенно неверное значение!";

        }
        else
        {
            res = "Это карта: " + ds.FindCardValue(num);
        }


        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine(res);


        Console.ReadKey();

    }

}