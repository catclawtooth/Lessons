using System;

namespace _4.Калькулятор_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("========Calculator===========");
                double numberOne, numberTwo;
                string action;



                try
                {
                    Console.WriteLine("Enter number one");
                    numberOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number two");
                     numberTwo = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;  // Дальше код выполнятся не будет, вернемся в начало цикла <while>
                }


                m1:


                Console.WriteLine("Choose an operation + - * /");
                action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        Console.WriteLine(numberOne + numberTwo);
                        break;
                    case "-":
                        Console.WriteLine(numberOne - numberTwo);
                        break;
                    case "*":
                        Console.WriteLine(numberOne * numberTwo);
                        break;
                    case "/":
                        if (numberTwo == 0)
                            Console.WriteLine("0");
                        else
                            Console.WriteLine(numberOne / numberTwo);
                        break;
                    default:
                        goto m1;
                        continue;
                }
                Console.WriteLine("Очистить???");
                Console.ReadLine();
            }
        }
    }
}
