using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    class Program
    {
        static void Main(string[] args)
        {
            //введем координаты прямой L (x1,y1), (x2,y2) и точки А (x3,y3)
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            // нужно найти координаты точки (x4,y4)
            double x4, y4;
            // к1, b1 - коэффициенты прямой L, к2, b2 - коэффициенты прямой P
            double k1, b1, k2, b2;
            k1 = (y2 - y1) / (x2 - x1);
            b1 = y1 - (x1 * (y2 - y1) / (x2 - x1));
            k2 = -1 / k1;
            b2 = y3 + (x3 * (x2 - x1) / (y2 - y1));
            x4 = (b1 - b2) / (k2 - k1);
            y4 = x4 * k2 + b2;
            Console.WriteLine(x4);
            Console.WriteLine(y4);
            Console.ReadKey();
        }
    }
}
