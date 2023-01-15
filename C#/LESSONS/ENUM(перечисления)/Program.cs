using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM_перечисления_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор программы:");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum{key}\tKeyCode{keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали enter");
                }
            }
        }
    }
}
