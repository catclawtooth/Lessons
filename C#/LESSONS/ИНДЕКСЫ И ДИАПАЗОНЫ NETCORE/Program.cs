

namespace ИНДЕКСЫ_И_ДИАПАЗОНЫ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                             <====
            //               ^8 ^7  ^6  ^5  ^4  ^3  ^2  ^1       ^0 == myArray.Length
            int[] myArray = { 5, 6, 78, 54, 96, 74, 21, 15 }; // [8] == ^0
            //                0  1   2   3   4   5   6   7        0 == 5
            //                             ====>

            int[] myArray2 = myArray[1..4]; // диапазон элементов массива (<4> в диапазон не входит)   [4..]   [..8 == ^0 == myArray.Length]
            Console.WriteLine(myArray[^1]);  // индекс первого элемента с конца массива

            

            Index myIndex = ^2;
            //  <Index> это тип данных. Является структурой и хранится в стэке

            Console.WriteLine("\n\n" + myArray[myIndex]);

            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
            // <value> - Индекс элемента массива. <isFromEnd> - булевая переменная
            // если <true> то перебираем массив с конца, если <false> то сначала
            // Зависит от наличия символа <^> (циркумфлЕкс)


            Index myindex2 = new Index(3, true);  //^3
            // Означает Элемент под индексом <3>, отсчет с конца массива
            // <false> значение по умолчанию и не обязательно пишется

            Console.WriteLine(myindex2);


            Range myRange = 0..3;  
            //создаем структуру
            int[] myArray3 = myArray[myRange]; 
            //  создаст массив с элементами 0, 1, 2 

            Range myRange2 = new Range(1, 4);  //  1..4
            int[] myArray5 = myArray[myRange2];

            Range myRange3 = ^4..^1;  
            //создаем структуру           
            int[] myArray4 = myArray[myRange3];
            //  Упрощенно - 
            //  int [] myArray4 = myArray[^4..^1];
            //  Все равно создается структура, но мы не выносим ее в отдельную переменную


            //ИНДЕКСЫ_И_ДИАПАЗОНЫ могут работать не только с массивами, но и со строками

            string str = "Hello World !!! =)";

            Console.WriteLine(str[0]); //  H
            Console.WriteLine(str[^2..]);  //  =)
            Console.WriteLine(str[0..6]);  //  Hello
            Console.WriteLine(str[6..11]);  //  World

            foreach (var item in str[0..^0])
            {
                Console.Write($"{item}   ");
            }
            Console.WriteLine("\n");
            foreach (var item in str[1..6])
            {
                Console.WriteLine($"{item} \n ");
            }

            Range myRange4 = new Range(0, 3);
            string myArray6 = str[myRange4];  //  Hel

            string myArray7 = str[..^13]; //  Hello
            



        }
    } 
}
