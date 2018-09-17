using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            // hour-количество часов
            int hour = Convert.ToInt16(Console.ReadLine());
            // angle-угол в градусах
            int angle;
            if (hour < 12)
            {
                angle = hour * 30;
            }
            else
            {
                angle = (hour - 12) * 30;
            }
            Console.WriteLine(angle);
        }
    }
}
