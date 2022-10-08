using System;
namespace BREAK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                string msg = Console.ReadLine();

                if (msg == "exit")  //  Выйдем из цикла после ввода слова <exit>
                {
                    break;   
                }
            }

        }
    }
}
