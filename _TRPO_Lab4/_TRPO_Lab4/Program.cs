using System;

namespace _TRPO_Lab4
{
    class Program
    {

        static double Sum = 0;

        static double Func(double x) => Math.Sqrt(Math.Pow(x, 2) - 0.64) / x;
        // ОДЗ: Все, кроме от -0.8 до 0.8
        static int NullReturner(double x)
        {
            if(x.ToString() == "0,8")
            {
                Sum += Func(0.8);
                Console.WriteLine($"Функция: {Func(0.8)} Сумма: {Sum}");
                return 0;
            }
            Console.WriteLine("Выход за ОДЗ!");
            return 0;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                for (double i = a; i < b; i += 0.1)
                {
                    Sum += !Double.IsNaN(Func(i)) ? Func(i) : NullReturner(i);
                    if (!Double.IsNaN(Func(i)))
                    {
                        Console.WriteLine($"Функция: {Func(i)} Сумма: {Sum}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Низ цикла больше верха");
                Main();
            }
            Console.ReadKey();
        }

    }
}
