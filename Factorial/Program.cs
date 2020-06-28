using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            Console.WriteLine("Факториал: " + Factorial(b));
        }

        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }
    }
}
