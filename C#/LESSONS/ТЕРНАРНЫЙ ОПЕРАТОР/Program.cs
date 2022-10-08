using System;
namespace ТЕРНАРНЫЙ_ОПЕРАТОР
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  переменная = [первый операнд - условие] ? [второй операнд <if_true>] : [третий операнд <if_else>];

            bool accessAllowed;
            string passOrigin = "qwerty";
            string passInPut = Console.ReadLine();

            //if (passOrigin == passInPut)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}
            //Console.WriteLine(accessAllowed);

            accessAllowed = passOrigin == passInPut ? true : false;  //  Запись этого в одну строчку с помощью тернарного оператора

            Console.WriteLine(accessAllowed);
            Console.ReadLine();
        }
    }
}
