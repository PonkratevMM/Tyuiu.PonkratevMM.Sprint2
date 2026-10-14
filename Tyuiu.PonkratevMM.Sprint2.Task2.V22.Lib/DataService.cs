using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PonkratevMM.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x == 3)
                res = (y >= 3 && y <= 7) || (y >= 10 && y <= 11);
            else if (x == 4)
                res = (y >= 3 && y <= 11) || y == 14;
            else if (x == 5)
                res = (y >= 3 && y <= 14);
            else if (x == 6)
                res = (y >= 5 && y <= 11) || y == 14;
            else if (x == 7)
                res = (y >= 5 && y <= 7) || y == 14;
            else if (x == 8)
                res = (y >= 5 && y <= 7) || y == 14;
            else if (x == 9)
                res = (y >= 3 && y <= 9) || y == 14;
            else if (x == 10)
                res = (y >= 3 && y <= 9) || y == 14;
            else if (x == 11 || x == 12)
                res = (y >= 3 && y <= 7) || (y >= 10 && y <= 11);
            else if (x == 13)
                res = (y >= 6 && y <= 7);
            else
                res = false;

            return res;







        }
    }
}
