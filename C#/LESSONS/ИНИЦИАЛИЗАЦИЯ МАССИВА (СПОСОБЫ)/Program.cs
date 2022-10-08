using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИНИЦИАЛИЗАЦИЯ_МАССИВА__СПОСОБЫ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] {5,6,8,7,9};  //  ПРИСВАИВАЕМ ЗНАЧЕНИЯ ЭЛЕМЕНТАМ МАССИВА (ОБЯЗАТЕЛЬНО каждому элементу!!!)
            
            int[] myArray2 = new int[] { 5, 6, 8, 7 };  //  если заранее не знаем сколько элементов массива (он сам определит размер)
            
          //int[] myArray2 = new int[];  неверная запись (необходимо указать размер массива)
            
            int[] myArray3 = { 5, 6, 8, }; //  допускается не указывать тип данных или и тип и оператор <new> и <[]> в случае явного указания колличества элементов
            
            int[] myArray4 = new [] { 5, 6, 8, 7 }; //  в случае явного указания типа данных <int> можно не указывать


        }

    }
}
