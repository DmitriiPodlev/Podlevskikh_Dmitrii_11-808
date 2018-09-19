using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr13
{
    class Program
    {
        static void Main(string[] args)
        {
            //  side - сторона квадратного участка, r - радиус окружности(длина веревки), s - искомая площадь, angle - центральный угол
            double side = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double s;
            if (side > 2 * r)
            {
                s = Math.PI * r * r;
                Console.WriteLine(s);
                return;
            }
            if (side <= r)
            {
                s = side * side;
                Console.WriteLine(s);
                return;
            }
            if (side < 2 * r)
            {
                double angle = Math.Acos(side / 2 / r);
                s = Math.PI * r * r - 4 * (angle * r * r - side / 2 * r * Math.Sin(angle));
                Console.WriteLine(s);
                return;
            }
        }
    }
}
