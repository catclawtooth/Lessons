using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Метод_RESIZE_4
{
    internal class Program
    {


        static void DeliteFirst(ref int[] array)
        {
            DeliteIndex(ref array, 0);
        }


        static void DeliteLast(ref int[] array)
        {
            DeliteIndex(ref array, array.Length - 1);
        }


        static void DeliteIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i+1];
            }
            array = newArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1,2, -8, 3, 7,14,45,100 };
            int index = 2;
            DeliteIndex(ref myArray, index);
            DeliteFirst(ref myArray);
            DeliteLast(ref myArray);

            Console.Read();
        }
    }
}
