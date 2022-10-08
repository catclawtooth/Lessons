using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMS
{
    internal class Program
    {

        //  <params> Используется в качестве модификатора параметров.
        //  Он может выполнять какие либо действия с перечисленными в метод параметрами. Их может быть сколь угодно много.



        static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }


        static int Sum2(string mesege, params int[] parameters) 
        {
            int result = 0;
            return result;
        }



        static void Main(string[] args)
        {

            // Если нет необходимости передавать метод в массив целиком,
            //мы можем использовать модификатор <params> и добавлять значения через запятую

            int result = Sum();  //  Метод вернет "0"
            int result2 = Sum(5, 10);  //  Метод веренет "15"         (5, 10 ... n); =>  15 + n

            // У <params> есть ограничения:
            // 1. Массив использующий модификатор <params> всегда должен идти в качестве последнего параметра в методе.

            // Если запись будет оформлена правильно, то параметры перечисляются следующим образом
            int result3 = Sum2("test", 5, 10, 15);

            // 2. В одном методе не может быть двух параметров с модификатором <params>.
        }

    }
}
