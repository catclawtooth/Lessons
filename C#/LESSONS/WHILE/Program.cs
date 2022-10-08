using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
             while (true)           //пока <true>, то выполняем действие в цикле (бесконечный цикл)
             {                      //если <false>, то в цикл не входим
                Console.WriteLine("действие");
             }
        }
    }
}
