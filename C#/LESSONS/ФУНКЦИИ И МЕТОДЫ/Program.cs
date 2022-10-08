using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФУНКЦИИ_И_МЕТОДЫ
{

    
    internal class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }
        static void Main(string[] args)
        {

            //   модификаторы тип_возвращаемого_значения название_метода(параметры)
            //   {
            //      тело метода  
            //   }

            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Program.Sum(a, b);
            Sum(a, b); //  то же самое если внутри класса <Program>

            c = Sum(a, b);

            Console.WriteLine(c);
        }
    }
}
