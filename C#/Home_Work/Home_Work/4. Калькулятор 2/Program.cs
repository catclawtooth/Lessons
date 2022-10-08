using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Калькулятор_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Calculator===========");

            Console.WriteLine("Enter number one");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number two");
            double numberTwo = double.Parse(Console.ReadLine());

            m1:

            Console.WriteLine("Choose an operation + - * /");
            string action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(numberOne + numberTwo);
            }
            else if (action == "-")
            {
                Console.WriteLine(numberOne - numberTwo);
            }
            else if (action == "*")
            {
                Console.WriteLine(numberOne * numberTwo);
            }
            else if (action == "/")
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(numberOne / numberTwo);
                }
            }
            else 
            {
                
                Console.WriteLine("Invalid symbol! ");
                goto m1;
            }
        }
    }
}
