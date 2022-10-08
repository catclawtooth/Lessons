using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Рекурсия_1
{
    internal class Program
    {


        static void ArrayOutput(int[] array, int i = 0)
        {
            if (i >= array.Length) return;

            Console.WriteLine(array[i]);
           
            ArrayOutput(array, i + 1);
        }



        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5,  };
            ArrayOutput(myArray);
        }
    }
}
