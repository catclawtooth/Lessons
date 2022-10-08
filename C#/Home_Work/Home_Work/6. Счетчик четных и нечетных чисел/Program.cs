using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Счетчик_четных_и_нечетных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {

            uint evenNumberCount = 0; // Четные числа (счетчик)
            uint oddNumberCount = 0;  // Нечетные числа (счетчик)
            int evenNamberSum = 0;  // Четные числа (сумма)
            int oddNamberSum = 0;  // Нечетные числа (сумма)

            Console.WriteLine("Введите начало диапазона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона");
            int limit = int.Parse(Console.ReadLine());

            while(currentValue <= limit) // цикл для счетчика
            {
                if (currentValue % 2 == 0)  // проверка на четность
                {
                    evenNumberCount++;
                    evenNamberSum = evenNamberSum + currentValue; // Обычная запись (не сокращенная)
                }
                else
                {
                    oddNumberCount++;
                    oddNamberSum += currentValue;  // Сокращенная запись
                }
                currentValue++;
            }

            Console.WriteLine("Колличество четных чисел " + evenNumberCount);
            Console.WriteLine("Колличество нечетных чисел " + oddNumberCount);
            Console.WriteLine("Сумма четных чисел " + evenNamberSum);
            Console.WriteLine("Сумма нечетных чисел " + oddNamberSum);

            Console.ReadLine();
        }
    }
}
