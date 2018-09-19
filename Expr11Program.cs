using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr11
{
    class Program
    {
        static void Main(string[] args)
        {
            // hour - количество часов
            // minute - количество минут
            // angle - искомый угол
            int hour = Convert.ToInt16(Console.ReadLine());
            // переводим часы в минуты
            hour = hour % 12 * 5;
            int minute = Convert.ToInt16(Console.ReadLine());
            int angle = Math.Abs(minute - hour) * 6;
            Console.WriteLine(angle);
            Console.ReadKey();
        }
    }
}
