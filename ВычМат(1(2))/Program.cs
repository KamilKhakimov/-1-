using System;

namespace ВычМат1_2
{
    // Метод простых итераций

    namespace ConsoleApp2
    {
        internal class Program
        {
            static double func(double a)
            {
                return -5 / (Math.Pow(a, 2) - a - 7);
            }
            static void IterationRun(double a, double b)
            {
                double eps = 0.0001;

                double x1 = a, x0 = b;
                int it = 0;
                do
                {
                    x1 = func(x0);
                    x0 = x1;
                    it++;
                    Console.WriteLine(x0);
                } while (Math.Abs(x1 - func(x1)) > eps);

                Console.WriteLine();

                Console.WriteLine("\n x = " + x0 + " count iteration:" + it);
            }
            static void Main(string[] args)
            {
                IterationRun(2, 3);
                IterationRun(0, 1);
                //IterationRun(-3, -2);
            }
        }
    }
}
