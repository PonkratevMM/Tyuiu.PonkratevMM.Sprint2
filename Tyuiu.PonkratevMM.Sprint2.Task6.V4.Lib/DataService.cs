using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PonkratevMM.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            string result;
            switch (value)
            {
                case 1:
                    result = "пики";
                    break;
                case 2:
                    result = "трефы";
                    break;
                case 3:
                    result = "бубны";
                    break;
                case 4:
                    result = "червы";
                    break;
                default:
                    result = "Неверный номер карты";
                    break;
            }
            return result;
        }
    }
}
