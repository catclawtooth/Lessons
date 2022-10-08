using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {



                                            //Цикл выполняется -       Что делаем с переменной каждый раз -
            //Стартовая позиция счетчика    - до тех пор пока          - проходя через цикл
            for (int j = 0;                     j<=10;                  j = j + 1 /*  'j++'  */)
            {
                Console.WriteLine("Hello " + j);     // Пока 'i<=10' <true> выполняется тело цикла ('Hello 0..10')
                                                     // Если 'i<=10' <false> выходим из цикла
            }




            // Допускается запись (бесконечный цикл)
            for (;;)  
            {
                Console.WriteLine("Hello ");
                System.Threading.Thread.Sleep(300);  // Замедление потока выполнения
                break;  // Остановит выполнение бесконечного цикла
            }


            // выносим <i> из скобок цикла (допускается выносить и условие и счетчик)
            int i = 0;  
            for (; i < 3; i++)
            {
                Console.WriteLine("For 1 - " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("For 2 - " + i);
            }


            // несколько условий
            for (int k = 0, l = 5; k < 10 && l <= 12; k++, l++)  
            {
                Console.WriteLine("k: " + k);
                Console.WriteLine("l: " + l);
            }



            // ======FOR В ОБРАТНОМ ПОРЯДКЕ========
            for (int k = 5; k >= 0; k--)  //  можно и так for (int k = int.Parse(Console.ReadLine()); k >= 0; k--) 
            {                               //  НО НЕ ЖЕЛАТЕЛЬНО!!!
                Console.WriteLine(k);
            }


            Console.ReadLine();

        } 
    }
}
