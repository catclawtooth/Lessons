using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Метод_для_поиска_индекса_элемента_массива
{
    internal class Program
    {
        static int IndexOf(int[] array,int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                    return i;
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random myRandom = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = myRandom.Next(minValue, maxValue);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"|{array[i]}| ");
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите размер одномерного массива: ");
                uint arraySize = uint.Parse(Console.ReadLine());
                Console.WriteLine("\nГенерация массива... ");
                int[] myArray = GetRandomArray(arraySize, -10, 20);

                PrintArray(myArray);

                Console.Write("\n\nВведите значение элемента массива для поиска его индекса: ");
                int input = int.Parse(Console.ReadLine());

                int index = IndexOf(myArray, input);
                Console.WriteLine($"\n\tмассив[{index}] = {input}");


                Console.WriteLine("\n\n\nНажмите любую клавишу чтобы очистить поле");
                Console.ReadLine();
            }
            
        }
    }
}
