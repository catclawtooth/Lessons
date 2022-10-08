using System;

namespace TREUGOLNIKI
{
    internal class TREEANGEL
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите высоту треугольника");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите символ");
                string simbol = Console.ReadLine();



                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(simbol);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();



                for (int i = height; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(simbol);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();



                for (int i = 0; i < height; i++)
                {
                    for (int j = height - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(simbol);
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();



                for (int i = 0; i < height; i++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = height; j > i; j--)
                    {
                        Console.Write(simbol);
                    }
                    Console.WriteLine();

                }
            }

        }
    }
}
