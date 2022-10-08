using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАРАМЕТРЫ__НЕОБЯЗАТЕЛЬНЫЕ_И_ИМЕНОВАННЫЕ_
{
    internal class Program
    {



        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Переменная а = " + a);
                Console.WriteLine("Переменная b = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;
        }



        static void Main(string[] args)
        {


            // НЕОБЯЗАТЕЛЬНЫЕ ПАРАМЕТРЫ


            int result = Sum(5, 2, true);  //  Параметры по умолчанию не зависят от их кол-ва и всегда находятся в конце списка


            // ИМЕНОВАННЫЕ_ ПАРАМЕТРЫ


            int firstValue = 5;
            int secondValue = 2;

            int result2 = Sum(enableLogging: true, b: secondValue, a: firstValue);

            // Указывается конкретный параметр и значение которое необходимо присвоить
            // Порядок указывания параметров не обязателен
        }
    }
}
