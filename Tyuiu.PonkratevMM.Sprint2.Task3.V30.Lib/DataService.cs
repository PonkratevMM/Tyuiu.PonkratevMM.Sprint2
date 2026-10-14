using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PonkratevMM.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
         
            double y = 0;
            

            
            if (x > 1)
            {
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    double num1 = x * x - Math.Cos(x * x) - 3;
                    double d = x * x - Math.Sin(x * x) - 2;
                    y = num1 / d;
                }
                else
                {
                    if (x > -34 && x < 2)
                    {
                        y = Math.Pow(1 + 1 / (x * x), x);
                    }
                    else
                    {
                        if (x < -34)
                        {
                            y = x + 10 * x - (1.0 / x);
                        }


                    }

                }
            }
            return Math.Round(y, 3);
        }
        
    }


}





