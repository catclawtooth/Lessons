using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Метод_выводящий_строку
{
    internal class Program
    {
        static void OutputString(string symbol, uint symbolsCount)
        {
            for (int i = 1; i <= symbolsCount; i++)
            {
                Console.WriteLine($"{symbol}: {i}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string inputSymbol = Console.ReadLine();


            Console.Write($"Сколько раз вывести {inputSymbol} на экран?: ");
            uint numberOfCharacters = uint.Parse(Console.ReadLine());


            OutputString(inputSymbol, numberOfCharacters);
        }
    }
}
