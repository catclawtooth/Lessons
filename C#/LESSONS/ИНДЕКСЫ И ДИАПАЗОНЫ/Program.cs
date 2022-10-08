using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИНДЕКСЫ_И_ДИАПАЗОНЫ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 78, 54, 96, 74, 21, 15 };
            int[] myArray2 = myArray[1..4]; // диапазон элементов массива
            Console.WriteLine(myArray[^1]);  // индекс первого элемента с конца массива

        }
    }
}
