using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PonkratevMM.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 1 == 655) | (a == b);
            res[1] = (b - 1 != 669) & (a == a);
            res[2] = (c / 2 < 500) || (d == b);
            res[3] = (d * 2 > 300) && (a + 17 == b);
            res[4] = !(a - 54 <= 599);
            res[5] = (b - 1 >= 671) ^ (a -1 ==a);

            return res;
        }
    }
}
