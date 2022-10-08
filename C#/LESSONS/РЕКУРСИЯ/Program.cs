using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РЕКУРСИЯ
{
    internal class Program
    {


        static void Foo()
        {
            Console.WriteLine("Foo");
            Foo();
        }

        //  Вызов методом самого себя называется рекурсией

        static void Main(string[] args)
        {
            Foo();
        }
    }
}
