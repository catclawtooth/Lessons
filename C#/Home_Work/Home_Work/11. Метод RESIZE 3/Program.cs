using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Метод_RESIZE_3
{
    internal class Program
    {
        static void InsertStart(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < array.Length; i++)
                newArray[i+1] = array[i];
            array = newArray;
        }


        static void InsertEnd(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[newArray.Length - 1] = value;
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }


        static void InsertBetween(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i+1] = array[i];
            array = newArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 2, -8, 3, 7 };
            int value = 100;
            int index = 2;
            
            InsertStart(ref myArray, value);
            InsertEnd(ref myArray, value);
            InsertBetween(ref myArray, value, index);
            Console.ReadLine();
        }
    }
}
