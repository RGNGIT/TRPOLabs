using System;

namespace _TRPO_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число:");
                SimplifyCout(Convert.ToInt32(Console.ReadLine()));
            }
            catch(FormatException)
            {
                Console.WriteLine("Введен неверный формат числа или не число!");
            }
            Console.ReadKey();
        }

        static void SimplifyCout(int Value)
        {
            for(int i = 0; i < Value; i++)
            {
                if(isSimple(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool isSimple(int Num)
        {
            if (Num == 4)
            {
                return false;
            }
            for (int i = 2; i < Num / 2; i++)
            {
                if(Num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
