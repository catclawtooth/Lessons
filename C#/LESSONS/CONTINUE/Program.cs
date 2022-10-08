using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTINUE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;  // прерываем выполнение цикла <for> и возвращаемся к его началу
                }
                Console.WriteLine(i);  //  <2> не выведется в консоль из-за прерывания
            }

        }
    }
}
