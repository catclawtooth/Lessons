using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Рекурсия_2
{
    internal class Program
    {


        static void ArraySum(int[] array, int i = 0, int sum  = 0)
        {
            if (i >= array.Length)
            {
                Console.WriteLine(sum);
                return;
            }
            sum += array[i];
            ArraySum(array, i+1, sum);
        }



        static void Main(string[] args)
        {
            int[] myArray = { 10, -2, 13, -48, 51, -4 };
            ArraySum(myArray);
            
        }
    }
}
