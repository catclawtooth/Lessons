using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Метод_RESIZE
{
    internal class Program
    {
        static void Resize(ref int[] arr, uint changeIndex, string mySolution)
        {
            if (mySolution == "y")
            {
                uint index = (uint)(arr.Length + changeIndex);
                arr = new int[index];
            }
            else
            {
                uint index = (uint)(arr.Length - changeIndex);
                arr = new int[index];
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            Console.WriteLine("Сейчас размер массива: " + myArray.Length);
            Console.Write("хотите увеличить размер массива (y/n): ");
            string solution = Console.ReadLine();

            if (solution == "y")
                Console.Write("насколько элементов увеличить: ");
            else
                Console.Write("насколько элементов уменьшить: ");

            uint i = uint.Parse(Console.ReadLine());
            Resize(ref myArray, i, solution);

            Console.WriteLine("размер массива равен: " + myArray.Length);



        }
    }
}
