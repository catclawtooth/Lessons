﻿using System;

namespace МАССИВЫ_И_ЦИКЛЫ__ВЫВОД__ПЕРЕБОР_МАССИВА_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
