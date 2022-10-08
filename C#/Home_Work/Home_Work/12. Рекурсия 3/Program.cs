using System;

namespace _12.Рекурсия_3
{
    internal class Program
    {


        static int SumArray(int value)
        {
            if (value < 10) return value;

            return value % 10 + SumArray(value / 10);
        }


        static void Main(string[] args)
        {
            int value = 561;
            int result = SumArray(value);
            Console.WriteLine(result);
        }
    }
}
