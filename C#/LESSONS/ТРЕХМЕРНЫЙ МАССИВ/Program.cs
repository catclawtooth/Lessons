using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРЕХМЕРНЫЙ_МАССИВ
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[,,] myArray =
            {//(полка [0], тетрадь [0] - если добавлять еще размерность)
                {//страница [0]
                    {2,3,5 },//строка[0], столбец[0];[1];[2]
                    {9,7,4 },//строка[1], столбец[0];[1];[2]
                },

                {//страница [1]
                    {2,3,5 },//строка[0], столбец[0];[1];[2]
                    {9,7,4 },//строка[1], столбец[0];[1];[2]
                },

                {//страница [2]
                    {2,3,5 },//строка[0], столбец[0];[1];[2]
                    {9,7,4 },//строка[1], столбец[0];[1];[2]
                },
            };


                                    //  Ввод данных в прямоугольный массив 



            Random myRandom = new Random();

            int[,,,] myArray2 = new int[2, 3, 4, 5];

            for (int k = 0; k < myArray2.GetLength(0); k++)
            {
                for (int z = 0; z < myArray2.GetLength(1); z++)
                {
                    for (int y = 0; y < myArray2.GetLength(2); y++)
                    {
                        for (int x = 0; x < myArray2.GetLength(3); x++)
                        {
                            myArray2[k, z, y, x] = myRandom.Next(100, 200);
                        }
                        
                    }
                }
            }
                                    // Вывод данных в консоль

            for (int k = 0; k < myArray2.GetLength(0); k++)
            {
                Console.WriteLine($"\n\tКнига №: {k + 1}");
                for (int z = 0; z < myArray2.GetLength(1); z++)
                {
                    Console.WriteLine($"\nСтраница №: {z + 1}\n");
                    for (int y = 0; y < myArray2.GetLength(2); y++)
                    {
                        for (int x = 0; x < myArray2.GetLength(3); x++)
                        {
                            Console.Write(myArray2[k, z, y, x] + " ");
                        }
                        Console.WriteLine();
                    }
                    
                }
            }

                                     //  Ввод данных в зубчатый массив


            Random myRandom2 = new Random();

            int[][][] myArray3 = new int[myRandom2.Next(2, 5)][][]; // Присвоили рандомное число страниц
            for (int z = 0; z < myArray3.Length; z++)
            {
                myArray3[z] = new int[myRandom2.Next(5)][]; // Генерируем колличество строк
                for (int y = 0; y < myArray3[z].Length; y++)
                {
                    myArray3[z][y] = new int[myRandom2.Next(5)];  // Генерируем колличество столбцов
                    for (int x = 0; x < myArray3[z][y].Length; x++)
                    {
                        myArray3[z][y][x] = myRandom2.Next(10,50);  // Генерируем значения в массиве
                    }
                }
            }
                                      // Вывод данных в консоль

            for (int z = 0; z < myArray3.Length; z++)
            {
                Console.WriteLine($"\nСтраница №: {z + 1}\n");
                for (int y = 0; y < myArray3[z].Length; y++)
                {
                    for (int x = 0; x < myArray3[z][y].Length; x++)
                    {
                        Console.Write(myArray3[z][y][x] + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
