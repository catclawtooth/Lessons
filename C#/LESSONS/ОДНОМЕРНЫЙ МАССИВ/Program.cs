using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОДНОМЕРНЫЙ_МАССИВ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // тип_элементов_массива [] имя_массива;

            /*Оператор new динамически выделяет память для объекта и возвращает ссылку на эту область памяти.
            Таким образом переменная, определенная в данной конструкции не является объектом, 
            она лишь ссылается на объект, который был физически создан в памяти компьютера оператором new.*/



            int[] myArray;  //  объявляем массив и его тип (массив это ссылочный тип и имя массива является ссылкой)
            myArray = new int[5];  //  0, 1, 2, 3, 4 - [5]
            myArray[1] = 3;  //  Помещаем в ячейку <1> значение <3>
            myArray[0] = 10;

            Console.WriteLine(myArray.Length); //  Вывод колличества элементов массива
            Console.WriteLine(myArray[0]);  //  Извлекаем из массива значение

            Console.ReadLine();
        }
    }
}
