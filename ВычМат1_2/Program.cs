using System;

namespace ВычМат1_2 // Ньютон
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0, xn, xnp1, e;

            e = 1;
            x0 = 1;
            xn = x0 - ((Math.Pow(x0, 3) - Math.Pow(x0, 2) - 7*x0 + 5) / (3* Math.Pow(x0, 2) - 2*x0 - 7));
            xnp1 = xn - ((Math.Pow(xn, 3) - Math.Pow(xn, 2) - 7 * xn + 5) / (3 * Math.Pow(xn, 2) - 2 * xn - 7));
            int it = 0;
            do  //-2,536633778951825
                //-2,536633778951825
            {
                xn = xnp1;
                xnp1 = xn - (Math.Pow(xn, 3) - Math.Pow(xn, 2) - 7 * xn + 5) / (3 * Math.Pow(xn, 2) - 2 * xn - 7);
                it++;

                System.Console.WriteLine(xnp1);
            } while (xn - xnp1 >= e); //xnp1 - xn > e
            
            System.Console.WriteLine(xnp1 + " Колво итераций " + it);
        }
    }
} //(2, 3)   //(0, 1)   //(-3, -2);
