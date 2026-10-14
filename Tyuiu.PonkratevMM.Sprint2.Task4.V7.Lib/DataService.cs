using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PonkratevMM.Sprint2.Task4.V7.Lib
{
    public class DataService : ISprint2Task4V7
    {
        public double Calculate(double x, double y)
        {

            double b1 = Math.Pow(1 + (Math.Sqrt(x + 3) / (x * x)), y);


            double b2 = Math.Pow(x, 3) + 2 * x + (6 + 4 / (y * y));


            double z = (x - 10 > y + 2) ? b1 : b2;


            return Math.Round(z, 3);
        }
    }
}
