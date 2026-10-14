using Tyuiu.PonkratevMM.Sprint2.Task3.V30.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task3.V30;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();




        Console.Title = "Спринт #2 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #2                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #3                                        *");
        Console.WriteLine("* Вариант #30                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое   *");
        Console.WriteLine("* значение функции Y с использованием вложенных     *");
        Console.WriteLine("* оператор if-else, где пользователь вводит значение*");
        Console.WriteLine("* переменной X с клавиатуры. Округлить полученное   *");
        Console.WriteLine("* значение до трех знаков после запятой;            *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);



        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("Значение функции = " + res);

       
        Console.ReadKey();

    }

}