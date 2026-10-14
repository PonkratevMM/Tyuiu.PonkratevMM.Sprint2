using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PonkratevMM.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double dist = x * x + y * y;

            if (y >= 0 && dist >= 1.0 && dist <= 4.0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }

}
   

