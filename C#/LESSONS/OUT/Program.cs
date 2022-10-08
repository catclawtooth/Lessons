using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUT
{
    // И в <REF> и в <OUT> параметр в метод передается по ссылке, а не копирует значение
    // Разница в том что <OUT> обязывает присваивать какое-либо значение внутри метода

    internal class Program
    {


        static void Foo(ref int value)
        {
            Console.WriteLine(value); //  Для <REF> Переменная не обязательно должна быть изменена
        }


        static void Bar(out int value)
        {
            value = 5;  //  Для <OUT> Обязательно присвоение какого-либо значения
        }


        static void Main(string[] args)
        {
            int a = 10;

            Foo(ref a);  //  a == 10
            Console.WriteLine("a = " + a);

            Bar(out a);  //  a == 5
            Console.WriteLine("a = " + a);

            // Возможно обьявление переменной <a> прям во время вызова метода <Bar>,
            //  а уже внутри самого метода ей будет присвоено значение "5"

            Bar(out int b);  //  b == 5
            Console.WriteLine("b = " + b);


            //----------------------------------------------------------------------------------
            //ПРИМЕР
            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);
        }
    }
}
