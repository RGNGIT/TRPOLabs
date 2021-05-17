using System;

namespace _TRPO_Lab4
{
    class Program
    {

        static double Func(double x) => Math.Sqrt(Math.Pow(x, 2) - 0.64) / x;

        static bool Check(double a, double b)
        {

            return true;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (Check(a, b))
            {
                double Sum = 0;
                for (double i = a; i < b; i += 0.1)
                {
                    Sum += Func(i);
                    Console.WriteLine($"Функция: {Func(i)} Сумма: {Sum}");
                }
            }
            Console.ReadKey();
        }

    }
}
