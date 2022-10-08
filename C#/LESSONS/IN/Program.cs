using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IN
{

    //используя модификатор параметров <IN> в отличии от <ref> и <out> мы его изменить не можем
    // Не можем присвоить ему никакое новое значение, он становится только для чтения
    // Это нужно для того что бы улучшить быстродействие программы и уменьшить колличество используемой памяти


    internal class Program
    {

        static void Foo(in int value)
        {
            Console.WriteLine(value);  //  (value == 5) Можем только прочитать <value>, изменить не можем
            //value = 10; // Не удается присвоить значение переменная "in int", так как это переменная только для чтения IN  
        }


        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);
        }
    }
}
