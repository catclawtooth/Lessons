using System;
using System.Linq;

namespace _7.Заполнить_массив_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForInput;
            int arraySize;
            while (true)
            {
                Console.Write("Введите колличество элементов массива:\t");
                arraySize = int.Parse(Console.ReadLine());
                try
                {
                    arrayForInput = new int[arraySize];
                    break;
                }
                catch (Exception)
                {
                //    if (arraySize < 0)
                //    {
                //        Console.WriteLine("\n\nколличество элементов массива не может быть отрицательным");
                //        continue;
                //    }
                //    else if (arraySize is Exception)
                //    Console.WriteLine("колличество элементов массива должно быть цифровым значением");          
                    continue;
                }
            }            
            for (int i = 0; i < arrayForInput.Length; i++)
            {
                Console.Write($"Элемент массива № {i}: \t");
                int input = int.Parse(Console.ReadLine());
                arrayForInput[i] = input;
            }

            //Вывод массива в прямом порядке
            Console.Write("\nВывод массива в прямом порядке\n");
            Console.Write("{ ");
            for (int i = 0; i < arrayForInput.Length; i++)
            {
                Console.Write(arrayForInput[i] + ", ");
            }
            Console.Write("}");

            //Вывод массива в обратном порядке
            Console.Write("\n\nВывод массива в обратном порядке\n");
            Console.Write("{ ");
            for (int i = arrayForInput.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayForInput[i] + ", ");
            }
            Console.Write("}");

            //Cумма четных и нечетных чисел
            int evenElementArraySum = 0;
            int oddElementArraySum = 0;
            for (int i = 0; i < arrayForInput.Length; i++)
            {
                if (arrayForInput[i] % 2 == 0)
                {
                    evenElementArraySum += arrayForInput[i];
                }
                else
                {
                    oddElementArraySum += arrayForInput[i];
                }
               
            }
            Console.WriteLine("\n\nCумма четных чисел = " + evenElementArraySum);
            Console.WriteLine("Cумма нечетных чисел = " + oddElementArraySum);

            Console.WriteLine("\nс использованием метода <массив.Where> - " + arrayForInput.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("с использованием метода <массив.Where> - " + arrayForInput.Where(i => i % 2 != 0).Sum());

            //наименьшее и наибольшее число в массиве
            int smalledNumberArray = arrayForInput[0];
            int bigedNumberArray = arrayForInput[0];

            for (int i = 1; i < arrayForInput.Length; i++)
            {
                if (arrayForInput[i] < smalledNumberArray)
                {
                    smalledNumberArray = arrayForInput[i];
                }
                else if (arrayForInput[i] > bigedNumberArray)
                {
                    bigedNumberArray = arrayForInput[i];
                }
            }
            Console.WriteLine("\nНаименьшее число массива - " + smalledNumberArray);
            Console.WriteLine("Наибольшее число массива - " + bigedNumberArray);

            Console.WriteLine("\nс использованием метода <массив.Min> - " + arrayForInput.Min());  //  необходимо использовать <using System.Linq;> 
            Console.WriteLine("с использованием метода <массив.Max> - " + arrayForInput.Max());  //  т.к этот метод является расширением

            Console.ReadLine();
        }
    }
}
