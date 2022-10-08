using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11.Метод_RESIZE_2
{
    internal class Program
    {
        static void Resize <T>(ref T[] array, int modifiedIndex)  //  <T> - Type (принимает входным параметром любой тип данных)
        {
            T[] modifiedArray = new T[modifiedIndex];
            for (int i = 0; i < array.Length && i < modifiedArray.Length; i++)
            {
                modifiedArray[i] = array[i];
            }
            array = modifiedArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5, -9, 7 };
            int i = 2;
            Resize(ref myArray, i);
            Console.WriteLine(myArray.Length);

            string[] strArray = { "test", "Hello", "world" };
            int i2 = 4;
            Resize(ref strArray, i2);
        }
    }
}
