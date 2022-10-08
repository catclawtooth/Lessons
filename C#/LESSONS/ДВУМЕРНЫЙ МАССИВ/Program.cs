using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДВУМЕРНЫЙ_МАССИВ
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                                 // ДВУМЕРНЫЙ ПРЯМОУГОЛЬНЫЙ МАССИВ


            //тип_данных[,] имя_массива; - создание массива

            // Создаем ярлык который должен указавать на контейнер с данными в памяти. Его значение сейчас <null>
            int[,] myArray1;
            // Обращаемся по имени созданного массива.
            // Используем оператор <new>.
            // И указываем тип данных соответствующий созданному массиву 
            myArray1 = new int[3, 5]; //  Выделили место в оперативной памяти под этот массив
                                      //  3 - количество строк, 5 - количество колонок (столбцов)
                                      // либо же можно записать так
            int[,] myArray = new int[3, 5];

            myArray[0, 2] = 99; //  Помещаем значение по указанным координатам

            Console.WriteLine(myArray[0, 2]);

            int[,] myArray2 = new int[3, 5]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,5,65,78,13}
            };
            Console.WriteLine("\n" + myArray2[0, 2]);


            // Немного упростим
            int[,] myArray3 = new int[,] // допускается не заполнять, размер укажется автоматически при компиляции
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,5,65,78,13}
            };
            Console.WriteLine("\n" + myArray3[1, 3]);


            // Еще Немного упростим
            int[,] myArray4 =  // допускается не заполнять, размер и место в памяти <new> укажется автоматически при компиляции
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,5,65,78,13}
            };
            Console.WriteLine("\n" + myArray4[2, 4] + "\n");







                                                  // ВЫВОД ДВУМЕРНОГО ПРЯМОУГОЛЬНОГО МАССИВА

            int[,] myArray5 =
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,5,65,78,13},
                {6,3,151,5,65}
            };
            foreach (var item in myArray5)
            {
                Console.Write(item + " ");
            }

            //  <Rank> показывает размерность массива
            Console.WriteLine($"\n\nРазмерность массива: {myArray5.Rank}");

            // Колличество элементов в массиве
            Console.WriteLine($"\nКолличество элементов в массиве: {myArray5.Length}"); 

            // .GetLength - Узнать колличество элементов в заданном измерении (размерности)
            // Колличество элементов в первом измерении < .GetLength(0) > (строки)
            Console.WriteLine($"\nКолличество строк в массиве: {myArray5.GetLength(0)}");

            // Колличество элементов во втором измерении < .GetLength(1) > (столбцы и т.д.)
            Console.WriteLine($"Колличество столбцов в массиве: {myArray5.GetLength(1)}");


            Console.WriteLine("\n\nВывод массива в виде матрицы (таблицы)\n");
            int hight = myArray5.GetLength(0);
            int width = myArray5.GetLength(1);

            for (int y = 0; y < hight; y++)
            {
                Console.Write(myArray5[y,0] + " ");
                for (int x = 1; x < width; x++)
                {
                    Console.Write(myArray5[y,x] + " ");
                }
                Console.WriteLine();
            }

            // Либо
            Console.WriteLine();
            for (int y = 0; y < myArray5.GetLength(0); y++)
            {
                for (int x = 0; x < myArray5.GetLength(1); x++)
                {
                    Console.Write(myArray5[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
