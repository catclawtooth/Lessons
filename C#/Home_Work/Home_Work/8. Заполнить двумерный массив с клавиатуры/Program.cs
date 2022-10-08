using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Заполнить_двумерный_массив_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 6];

            Random random = new Random();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y,x] =  random.Next(-1000,1000);
                }
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");

            int[,] myArray2 = new int[2, 3];

            for (int y = 0; y < myArray2.GetLength(0); y++)
            {
                for (int x = 0; x < myArray2.GetLength(1); x++)
                {
                    Console.Write($"Введите значение элемента {y},{x}: ");
                    myArray2[y, x] =  int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int y = 0; y < myArray2.GetLength(0); y++)
            {
                for (int x = 0; x < myArray2.GetLength(1); x++)
                {
                    Console.Write(myArray2[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
