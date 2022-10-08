using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULL
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] array = null;
            return array;
        }
        static int[] GetArray2()
        {
            int[] array = new int[] { 1, 2, 3 };
            return array;
        }
        static void Main(string[] args)
        {

            bool b;  //  false

            int a;  //  0

            double d;  //  0

            Random r;  //  nuul

            int[] arr;  //  null

            //MyClass myclass;  //  null

            //MyStruct myStruct;  //  null

            // Ключевале слово <null> можно использовать только с сылочными типами


            // ------------------------------------------- Оператор объединения с <null> - ??--------------------------------------

            string str = null;
            string result;
            if (str ==  null)
            {
                result = "Нет данных";
            }
            else
            {
                result = str;
            }
            Console.WriteLine(result);


            //  с помощью оператора <??> все выглядит проще
            string str2 = null;
            string result2 = str2 ?? String.Empty; // <String.Empty> - пустая строка, или <""> или <"нет данных">.
            Console.WriteLine("Колличество символов в строке: " + result2.Length);


            //-----------------------------------  Оператор присваивания объединения с <null> - <??=>-----------------------------------

            //  Чтобы оператор <??=> работал в версии 7.3 необходимо добавить <LangVersion>8.0</LangVersion> в файл .csproj
            string str3 = null;  //  если значение все таки есть, то проверка не переопределит эту переменную
            str3 ??= string.Empty;  //str3 = str3 ?? string.Empty;  //  .NET FrameWork   
            Console.WriteLine("Колличество символов в строке 2: " + str3.Length);

            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("Колличество символов в массиве: " + myArray.Length);


            //-------------------------------------------------Оператор условного - <?.>----------------------------------------------

            int[] myArray2 = GetArray2();
            Console.WriteLine("Сумма элементов массива: " + myArray2.Sum());

            // но что будет если все таки придет значение <null>? Будет исключение
            //и что бы обработать это исключение можно пойти путем создания <if> - <else>
            int[] myArray3 = GetArray();
            if (myArray3 == null)
            {
                Console.WriteLine("Сумма элементов массива через IF = 0 ");
            }
            else
            {
                Console.WriteLine("Сумма элементов массива через IF: " + +myArray3.Sum());
            }
            // Либо использовать оператор <?.>
            int[] myArray4 = GetArray();
            Console.WriteLine("Сумма элементов массива через ?.: " + myArray4?.Sum()); //  можно добавить дефолтное значение вместе с оператором <??> - <+ (myArray4?.Sum() ?? 0));>
            // Прежде чем обращаться к массиву <myArray4>, пытаться сложить его элементы, будет выполнена проверка на <null>
            // Если в момент вызова оператора <?.> в массиве <myArray4> будет <null>, то дальнейший код выполнятся не будет
        }
    }
}
