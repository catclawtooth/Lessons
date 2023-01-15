using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM_перечисления_
{
    internal class Program2 // создание собственного ENUM
    {
        enum DayOfWeek :byte // указываем тип данных в котором собираемся хранить
        {
            Mondey = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Mondey;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // Выводим в консоль тип данных использующийся в нашем enum

            Console.WriteLine(dayOfWeek);

        }
    }
}
