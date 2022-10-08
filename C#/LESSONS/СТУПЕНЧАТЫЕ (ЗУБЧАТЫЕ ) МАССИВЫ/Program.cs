using System;
namespace СТУПЕНЧАТЫЕ__ЗУБЧАТЫЕ___МАССИВЫ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] myArray = new int[3][];  //  Зубчатый
            int[,] mayArray2 = new int[3, 5]; //  Прямоугольный

            //  Размерность
            int myArrayRank = myArray.Rank;  //  ==1
            int myArray2Rank = mayArray2.Rank;  //  ==2

            //  Колличество элементов
            int myArrayLangth = myArray.Length;  //  ==3
            int myArray2Langth = mayArray2.Length;  //  ==15
            //  вслучае с зубчатым массивом он понимается как одномерный массив, элементами которого являются массивы
            //  Мы объявили зубчатый массив (на стр. 14), но элементы внутри него, которые являются массивами, не ссылаются -
            //   - ни на какое место в памяти и содерэат дефолтное значение  <null> .

            //                                    {int[5]}  {null}  {null}
            myArray[0] = new int[5];  //  myArray == [0]     [1]     [2]
            myArray[1] = new int[2];
            myArray[2] = new int[10];  //  Заполнили элементы зубчатого массива, массивами с определенной размерностью

            myArray[0][3] = 55;  //  ввод данных по индексу

            Console.WriteLine(myArray[0][3] + "\n\n");  //  вывод данных по индексу




            //  Наполняем массив и выводим в консоль
            Random myRandom = new Random();

            for (int y = 0; y < myArray.Length; y++)
            {
                for (int x = 0; x < myArray[y].Length; x++)
                {
                    myArray[y][x] = myRandom.Next(100, 200);
                }        
                
            }
            for (int y = 0; y < myArray.Length; y++)
            {
                for (int x = 0; x < myArray[y].Length; x++)
                {
                    Console.Write(myArray[y][x] + "\t"); 
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
