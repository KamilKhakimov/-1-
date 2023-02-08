using System;
// Метод половинного деления
namespace ConsoleApp1
{
    internal class Program
    {
        static double func(double a)
        {
            return Math.Pow(a, 3) - Math.Pow(a, 2) - 7 * a + 5;
        }
        static void IterationRun(double a, double b)
        {
            double eps = Math.Pow(10,-16); //0.0000000000000001
            double x1 = 0, x0 = 0;
            int it = 0;
            do
            {
                x1 = x0;
                x0 = (a + b) / 2;
                if ((func(a) > 0 && func(x0) < 0) || (func(a) < 0 && func(x0) > 0))
                    b = x0;

                else if ((func(b) > 0 && func(x0) < 0) || (func(b) < 0 && func(x0) > 0))
                    a = x0;

                it++;
                System.Console.WriteLine(x0);
            }
            while (Math.Abs(x0 - x1) > eps);
            System.Console.WriteLine();
            System.Console.WriteLine("x = " + x0 + "\nКоличество итераций: " + it + "\n");
            System.Console.WriteLine("----------------------------------------------------\n");
        }
        static void Print()
        {
            System.Console.WriteLine("Введите первую границу графика: ");
            double one = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите вторую границу графика: ");
            double two = Convert.ToDouble(System.Console.ReadLine());
            IterationRun(one, two);
        }
        static void Run()
        {
            Print();
            Print();
            Print();
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
//(2, 3)   //(0, 1)   //(-3, -2);